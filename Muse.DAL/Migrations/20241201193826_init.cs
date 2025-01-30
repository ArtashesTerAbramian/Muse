using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Muse.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "errors",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_errors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    code = table.Column<string>(type: "text", nullable: false),
                    is_default = table.Column<bool>(type: "boolean", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    photo_name = table.Column<string>(type: "text", nullable: true),
                    link = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_permissions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "static_text",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    key = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_static_text", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "error_translations",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    error_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    language_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_error_translations", x => x.id);
                    table.ForeignKey(
                        name: "fk_error_translations_errors_error_id",
                        column: x => x.error_id,
                        principalTable: "errors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_error_translations_languages_language_id",
                        column: x => x.language_id,
                        principalTable: "languages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "permission_translation",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    permission_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    language_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_permission_translation", x => x.id);
                    table.ForeignKey(
                        name: "fk_permission_translation_permissions_permission_id",
                        column: x => x.permission_id,
                        principalTable: "permissions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "role_permission",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_id = table.Column<long>(type: "bigint", nullable: false),
                    permission_id = table.Column<long>(type: "bigint", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_role_permission", x => x.id);
                    table.ForeignKey(
                        name: "fk_role_permission_permissions_permission_id",
                        column: x => x.permission_id,
                        principalTable: "permissions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_role_permission_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "role_translation",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    language_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_role_translation", x => x.id);
                    table.ForeignKey(
                        name: "fk_role_translation_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    last_name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: false),
                    password_hash = table.Column<string>(type: "text", nullable: false),
                    reset_password_token = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    reset_password_request_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    email_is_verified = table.Column<bool>(type: "boolean", nullable: false),
                    default_language_id = table.Column<long>(type: "bigint", nullable: false),
                    role_id = table.Column<long>(type: "bigint", nullable: false),
                    base_password_is_changed = table.Column<bool>(type: "boolean", nullable: false),
                    email_verification_token = table.Column<string>(type: "text", nullable: true),
                    email_verification_request_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                    table.ForeignKey(
                        name: "fk_users_languages_default_language_id",
                        column: x => x.default_language_id,
                        principalTable: "languages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_users_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "static_text_translation",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    static_text_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    language_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_static_text_translation", x => x.id);
                    table.ForeignKey(
                        name: "fk_static_text_translation_static_text_static_text_id",
                        column: x => x.static_text_id,
                        principalTable: "static_text",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mail_queues",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    is_sent = table.Column<bool>(type: "boolean", nullable: false),
                    failed_count = table.Column<int>(type: "integer", nullable: false),
                    subject = table.Column<string>(type: "text", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false),
                    contact = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_mail_queues", x => x.id);
                    table.ForeignKey(
                        name: "fk_mail_queues_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_sessions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    token = table.Column<string>(type: "text", nullable: false),
                    is_expired = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_sessions", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_sessions_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "errors",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "id", "code", "created_date", "is_active", "is_default", "is_deleted", "link", "modify_date", "name", "photo_name" },
                values: new object[,]
                {
                    { 1L, "en", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, true, false, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "English", null },
                    { 2L, "ru", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, false, false, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Русский", null },
                    { 3L, "am", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, false, false, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Հայերեն", null }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null });

            migrationBuilder.InsertData(
                table: "error_translations",
                columns: new[] { "id", "created_date", "error_id", "is_deleted", "language_id", "modify_date", "name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1L, false, 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Duplicate item" },
                    { 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1L, false, 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Дублированное значение" },
                    { 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1L, false, 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Կրկնվող արժեք" },
                    { 4L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2L, false, 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Cannot remove data with reference" },
                    { 5L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2L, false, 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Нельзя удалить значение со ссылкой" },
                    { 6L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2L, false, 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "չի կարելի ջնջել արժեքը հղումով" },
                    { 7L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3L, false, 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The given value is used" },
                    { 8L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3L, false, 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Данное значение используется" },
                    { 9L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3L, false, 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Տվյալ արժեքը օգտագործվում է" },
                    { 10L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L, false, 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The specified email address is already used!" },
                    { 11L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L, false, 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Указанный электронный адрес уже занят!" },
                    { 12L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L, false, 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Նշված էլ. հասցեն արդեն զբաղված է:" },
                    { 13L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5L, false, 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Email is not verified!" },
                    { 14L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5L, false, 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Адрес эл. почты не подтвержден!" },
                    { 15L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5L, false, 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Էլ. հասցեն հաստատված չէ:" },
                    { 16L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6L, false, 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Your current password is incorrect." },
                    { 17L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6L, false, 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ваш текущий пароль неправильный." },
                    { 18L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6L, false, 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ձեր ընթացիկ գաղտնաբառը սխալ է." },
                    { 19L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7L, false, 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Oops! Link has expired.\nWe'll send a fresh verification email to your inbox, and you can click the link in that one to confirm your account." },
                    { 20L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7L, false, 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Упс! Срок действия ссылки истек.\nМы отправим новое письмо с подтверждением на ваш почтовый ящик, и вы сможете щелкнуть ссылку в нем, чтобы подтвердить свою учетную запись." },
                    { 21L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7L, false, 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Հղումը ժամկետանց է:\nՄենք նոր հաստատող նամակ կուղարկենք Ձեր նշած էլեկտրոնային փոստի հասցեյինց, որի միջոցով կկարողանաք հաստատել Ձեր հաշիվը:" },
                    { 22L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8L, false, 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Oops! Link expired.\nPlease click the \"Forgot password\" button and we will send a new email to the email address you provided, through which you will be able to change your password." },
                    { 23L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8L, false, 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Упс! Срок действия ссылки истек.\n Нажмите кнопку «Забыли пароль», и мы отправим на указанный вами адрес электронной почты новое письмо, с помощью которого вы сможете изменить свой пароль." },
                    { 24L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8L, false, 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Հղումը ժամկետանց է:\nԽնդրում ենք սեղմել «Մոռացել եք գաղտնաբառը» կոճակը և մենք նոր նամակ կուղարկենք Ձեր նշած էլեկտրոնային փոստի հասցեյինց, որի միջոցով կկարողանաք փոխել Ձեր գաղտնաբառը:" },
                    { 25L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 9L, false, 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The old password cannot be reused." },
                    { 26L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 9L, false, 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Старый пароль нельзя заново использовать." },
                    { 27L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 9L, false, 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Հին գաղտնաբառը չի կարելի կրկին օգտագործել:" },
                    { 28L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 10L, false, 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Oops! Something went wrong" },
                    { 29L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 10L, false, 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Упс! Что-то пошло не так" },
                    { 30L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 10L, false, 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ինչ որ բան այնպես չգնաց" }
                });

            migrationBuilder.InsertData(
                table: "role_translation",
                columns: new[] { "id", "created_date", "is_deleted", "language_id", "modify_date", "name", "role_id" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1L, null, "Admin", 1L },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2L, null, "Админ", 1L },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3L, null, "Ադմին", 1L }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "base_password_is_changed", "created_date", "default_language_id", "email", "email_is_verified", "email_verification_request_date", "email_verification_token", "first_name", "is_deleted", "last_name", "modify_date", "password_hash", "phone", "reset_password_request_date", "reset_password_token", "role_id" },
                values: new object[] { 1L, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1L, "admin@gmail.com", false, null, null, "Admin", false, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "AQAAAAEAACcQAAAAED6+5BoYHtAaOo7S+WlTRk5WxUHXKwgearLUEo1nHhe5MXozVtqD/M0/KcdENNJzZQ==", null, null, null, 1L });

            migrationBuilder.CreateIndex(
                name: "ix_error_translations_created_date",
                table: "error_translations",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_error_translations_error_id",
                table: "error_translations",
                column: "error_id");

            migrationBuilder.CreateIndex(
                name: "ix_error_translations_is_deleted",
                table: "error_translations",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_error_translations_language_id",
                table: "error_translations",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_errors_created_date",
                table: "errors",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_errors_is_deleted",
                table: "errors",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_languages_created_date",
                table: "languages",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_languages_is_deleted",
                table: "languages",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_mail_queues_created_date",
                table: "mail_queues",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_mail_queues_is_deleted",
                table: "mail_queues",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_mail_queues_user_id",
                table: "mail_queues",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_permission_translation_created_date",
                table: "permission_translation",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_permission_translation_is_deleted",
                table: "permission_translation",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_permission_translation_permission_id",
                table: "permission_translation",
                column: "permission_id");

            migrationBuilder.CreateIndex(
                name: "ix_permissions_created_date",
                table: "permissions",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_permissions_is_deleted",
                table: "permissions",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_role_permission_created_date",
                table: "role_permission",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_role_permission_is_deleted",
                table: "role_permission",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_role_permission_permission_id",
                table: "role_permission",
                column: "permission_id");

            migrationBuilder.CreateIndex(
                name: "ix_role_permission_role_id",
                table: "role_permission",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "ix_role_translation_created_date",
                table: "role_translation",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_role_translation_is_deleted",
                table: "role_translation",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_role_translation_role_id",
                table: "role_translation",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "ix_roles_created_date",
                table: "roles",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_roles_is_deleted",
                table: "roles",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_static_text_created_date",
                table: "static_text",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_static_text_is_deleted",
                table: "static_text",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_static_text_translation_created_date",
                table: "static_text_translation",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_static_text_translation_is_deleted",
                table: "static_text_translation",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_static_text_translation_static_text_id",
                table: "static_text_translation",
                column: "static_text_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_sessions_created_date",
                table: "user_sessions",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_user_sessions_is_deleted",
                table: "user_sessions",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_user_sessions_user_id",
                table: "user_sessions",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_users_created_date",
                table: "users",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_users_default_language_id",
                table: "users",
                column: "default_language_id");

            migrationBuilder.CreateIndex(
                name: "ix_users_is_deleted",
                table: "users",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_users_role_id",
                table: "users",
                column: "role_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "error_translations");

            migrationBuilder.DropTable(
                name: "mail_queues");

            migrationBuilder.DropTable(
                name: "permission_translation");

            migrationBuilder.DropTable(
                name: "role_permission");

            migrationBuilder.DropTable(
                name: "role_translation");

            migrationBuilder.DropTable(
                name: "static_text_translation");

            migrationBuilder.DropTable(
                name: "user_sessions");

            migrationBuilder.DropTable(
                name: "errors");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "static_text");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
