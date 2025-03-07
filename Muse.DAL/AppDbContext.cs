﻿using Muse.DAL.Models;
using Muse.DAL.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Muse.DAL;

public class AppDbContext : DbContext
{
    private readonly IContextModificatorService _contextModificatorService;
    private readonly ILanguageService _languageService;


    public AppDbContext(DbContextOptions options, IContextModificatorService contextModificatorService, ILanguageService languageService) : base(options)
    {
        _contextModificatorService = contextModificatorService;
        _languageService = languageService;
    }

    public DbSet<Error> Errors { get; set; }
    public DbSet<ErrorTranslation> ErrorTranslations { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<UserSession> UserSessions { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<PermissionTranslation> PermissionTranslations { get; set; }
    public DbSet<MailQueue> MailQueues { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceTranslation> ServiceTranslations { get; set; }
    public DbSet<ServiceSpecification> ServiceSpecifications { get; set; }
    public DbSet<ServiceSpecificationTranslation> ServiceSpecificationTranslations { get; set; }

    public override int SaveChanges()
    {
        AddModificationDate();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        AddModificationDate();
        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);


        foreach (var property in modelBuilder.Model.GetEntityTypes()
                     .SelectMany(t => t.GetProperties())
                     .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
        {
            property.SetColumnType("decimal(18,2)");
        }

        if (_contextModificatorService != null && _contextModificatorService.IsGlobalQueryFiltersEnable)
        {
            modelBuilder.ApplyGlobalFilters<BaseEntity>(e => e.IsDeleted == false);
            modelBuilder.ApplyGlobalFilterForTranslationEntities<BaseTranslationEntity>(e => e.LanguageId == _languageService.LanguageId);
        }

        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }

        modelBuilder.SeedData();
    }

    private void AddModificationDate()
    {
        var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is BaseEntity && (
                e.State == EntityState.Added
                || e.State == EntityState.Modified));

        foreach (var entityEntry in entries)
        {
            ((BaseEntity)entityEntry.Entity).ModifyDate = DateTime.UtcNow;

            if (entityEntry.State == EntityState.Added)
            {
                ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.UtcNow;
            }
        }
    }
}

public static class ModelBuilderExtension
{
    public static void ApplyGlobalFilters<TInterface>(this ModelBuilder modelBuilder,
        Expression<Func<BaseEntity, bool>> expression)
    {
        var entities = modelBuilder.Model
            .GetEntityTypes()
            .Where(x => x.ClrType.BaseType == typeof(BaseEntity))
            .Select(e => e.ClrType);
        foreach (var entity in entities)
        {
            var newParam = Expression.Parameter(entity);
            var newbody = ReplacingExpressionVisitor.Replace(expression.Parameters.Single(), newParam, expression.Body);
            modelBuilder.Entity(entity).HasQueryFilter(Expression.Lambda(newbody, newParam));
        }
    }

    public static void ApplyGlobalFilterForTranslationEntities<TInterface>(this ModelBuilder modelBuilder,
        Expression<Func<BaseTranslationEntity, bool>> expression)
    {
        var entities = modelBuilder.Model
            .GetEntityTypes()
            .Where(x => x.ClrType.BaseType == typeof(BaseTranslationEntity))
            .Select(e => e.ClrType);
        foreach (var entity in entities)
        {
            var newParam = Expression.Parameter(entity);
            var newbody = ReplacingExpressionVisitor.Replace(expression.Parameters.Single(), newParam, expression.Body);
            modelBuilder.Entity(entity).HasQueryFilter(Expression.Lambda(newbody, newParam));
        }
    }
}