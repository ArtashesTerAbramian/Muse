using FluentValidation.AspNetCore;
using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.AspNetCore.Authentication;
using Muse.BLL;
using Muse.BLL.Helpers;
using Muse.BLL.Middlewares;
//using Muse.BLL.Validators.EmployeeValidators;
using Muse.DAL;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Serilog;
using Muse.BLL.Validators;
using Serilog.Events;

try
{
    var builder = WebApplication.CreateBuilder(args);

    Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
        .Enrich.FromLogContext()
        .WriteTo.Console()
        .CreateBootstrapLogger();

    builder.Host.UseSerilog(Log.Logger);

    builder.Environment.WebRootPath = builder.Configuration.GetSection("FileSettings").GetSection("FilePath").Value;

    var requestResponseLogger = Log.ForContext("SourceContext", "MyApp.RequestResponseLogging");

    // Add services to the container.
    builder.Services.AddDbContext(builder.Configuration);

    builder.Services.AddHangfire(configuration =>
        configuration
            .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
            .UseSerilogLogProvider()
            .UsePostgreSqlStorage(options =>
                options.UseNpgsqlConnection(builder.Configuration.GetConnectionString("Muse"))));
    builder.Services.AddHangfireServer();

    builder.Services.AddWebServices(builder.Configuration);

    builder.Services.AddCors();
    builder.Services.AddRouting(options => options.LowercaseUrls = true);
    builder.Services.AddControllers().AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
    }).AddFluentValidation(options => options.RegisterValidatorsFromAssembly(typeof(LoginDtoValidator).Assembly));

    builder.Services.AddHttpContextAccessor();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
        {
            Description = "ApiKey must appear in header",
            Type = SecuritySchemeType.ApiKey,
            Name = "Authorization",
            In = ParameterLocation.Header,
            Scheme = "ApiKeyScheme"
        });
        var key = new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "ApiKey"
            },
            In = ParameterLocation.Header
        };
        var requirement = new OpenApiSecurityRequirement
        {
            { key, new List<string>() }
        };
        c.AddSecurityRequirement(requirement);
    });
    
    builder.Services.AddFluentValidationRulesToSwagger();
    
    // builder.Services.AddAuthentication("UserAuth")
        // .AddScheme<AuthenticationSchemeOptions, UserAuthenticationHandler>("UserAuth", null);

    var app = builder.Build();

    await app.DatabaseMigrate();

    app.UseSerilogRequestLogging(options =>
    {
        // Customize the message template
        options.MessageTemplate =
            "{RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms by {Username}";

        // Emit debug-level events instead of the defaults
        options.GetLevel = (httpContext, elapsed, ex) =>
        {
            httpContext.Items["Elapsed"] = elapsed;
            return ex != null ? LogEventLevel.Error : LogEventLevel.Information;
        };

        // Attach additional properties to the request completion event
        options.EnrichDiagnosticContext = (diagnosticContext, httpContext) =>
        {
            diagnosticContext.Set("RequestHost", httpContext.Request.Host.Value);
            diagnosticContext.Set("RequestScheme", httpContext.Request.Scheme);
            diagnosticContext.Set("RequestMethod", httpContext.Request.Method);
            diagnosticContext.Set("RequestPath", httpContext.Request.Path);
            diagnosticContext.Set("StatusCode", httpContext.Response.StatusCode);

            // Set elapsed time
            diagnosticContext.Set("Elapsed", httpContext.Items["Elapsed"]);

            // Include the username
            var username = httpContext.User?.Identity?.Name ?? "Anonymous";
            diagnosticContext.Set("Username", username);
        };

        // Set custom SourceContext
        options.Logger = requestResponseLogger;
    });


    // Configure the HTTP request pipeline.
    // if (app.Environment.IsDevelopment())
    // {
    app.UseSwagger();
    app.UseSwaggerUI();
    // }

    app.UseHangfireDashboard();

    app.UseCors(x =>
    {
        x.SetIsOriginAllowed(_ => true);
        x.AllowAnyMethod();
        x.AllowAnyHeader();
        x.AllowCredentials();
        x.WithExposedHeaders("Content-Disposition");
    });

    app.UseMiddleware<ErrorHandlingMiddleware>();

    app.UseStaticFiles(new StaticFileOptions()
    {
        OnPrepareResponse = ctx =>
        {
            ctx.Context.Response.Headers.Append("Access-Control-Allow-Origin", "*");
            ctx.Context.Response.Headers.Append("Access-Control-Allow-Headers",
                "Origin, X-Requested-With, Content-Type");
        },
        FileProvider =
            new PhysicalFileProvider(builder.Configuration.GetSection("FileSettings").GetSection("FilePath").Value)
    });

    // app.UseSerilogRequestLogging();
    app.UseRouting();

    // app.UseAuthentication();
    // app.UseAuthorization();

    // app.UseMiddleware<AuthorizationMiddleware>();
    app.UseLanguageMiddleware();


    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Logger.Error(ex, "Stopped program because of execution");
}