using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Muse.DAL.Migrations
{
    public partial class bookig_status_with_seeders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_booking_service_service_id",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "fk_booking_service_specification_service_specification_id",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "fk_permission_translation_permissions_permission_id",
                table: "permission_translation");

            migrationBuilder.DropForeignKey(
                name: "fk_role_permission_permissions_permission_id",
                table: "role_permission");

            migrationBuilder.DropForeignKey(
                name: "fk_role_permission_roles_role_id",
                table: "role_permission");

            migrationBuilder.DropPrimaryKey(
                name: "pk_role_permission",
                table: "role_permission");

            migrationBuilder.DropPrimaryKey(
                name: "pk_permission_translation",
                table: "permission_translation");

            migrationBuilder.DropColumn(
                name: "duration",
                table: "booking");

            migrationBuilder.RenameTable(
                name: "role_permission",
                newName: "role_permissions");

            migrationBuilder.RenameTable(
                name: "permission_translation",
                newName: "permission_translations");

            migrationBuilder.RenameColumn(
                name: "booking_date_time",
                table: "booking",
                newName: "date");

            migrationBuilder.RenameIndex(
                name: "ix_role_permission_role_id",
                table: "role_permissions",
                newName: "ix_role_permissions_role_id");

            migrationBuilder.RenameIndex(
                name: "ix_role_permission_permission_id",
                table: "role_permissions",
                newName: "ix_role_permissions_permission_id");

            migrationBuilder.RenameIndex(
                name: "ix_role_permission_is_deleted",
                table: "role_permissions",
                newName: "ix_role_permissions_is_deleted");

            migrationBuilder.RenameIndex(
                name: "ix_role_permission_created_date",
                table: "role_permissions",
                newName: "ix_role_permissions_created_date");

            migrationBuilder.RenameIndex(
                name: "ix_permission_translation_permission_id",
                table: "permission_translations",
                newName: "ix_permission_translations_permission_id");

            migrationBuilder.RenameIndex(
                name: "ix_permission_translation_is_deleted",
                table: "permission_translations",
                newName: "ix_permission_translations_is_deleted");

            migrationBuilder.RenameIndex(
                name: "ix_permission_translation_created_date",
                table: "permission_translations",
                newName: "ix_permission_translations_created_date");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "duration",
                table: "service_specification",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<long>(
                name: "service_id",
                table: "service_specification",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "status_id",
                table: "booking",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "pk_role_permissions",
                table: "role_permissions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_permission_translations",
                table: "permission_translations",
                column: "id");

            migrationBuilder.CreateTable(
                name: "booking_status",
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
                    table.PrimaryKey("pk_booking_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "booking_status_translation",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    status_id = table.Column<long>(type: "bigint", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    language_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_booking_status_translation", x => x.id);
                    table.ForeignKey(
                        name: "fk_booking_status_translation_booking_status_status_id",
                        column: x => x.status_id,
                        principalTable: "booking_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "booking_status",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null }
                });

            migrationBuilder.InsertData(
                table: "booking_status_translation",
                columns: new[] { "id", "created_date", "is_deleted", "language_id", "modify_date", "name", "status_id" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1L, null, "Confirmed", 1L },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2L, null, "Подтверждено", 1L },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3L, null, "Հաստատված", 1L },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1L, null, "Completed", 2L },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2L, null, "Завершено", 2L },
                    { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3L, null, "Կատարված", 2L },
                    { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1L, null, "Cancelled", 3L },
                    { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2L, null, "Отменено", 3L },
                    { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3L, null, "Չեղարկված", 3L }
                });

            migrationBuilder.CreateIndex(
                name: "ix_service_specification_service_id",
                table: "service_specification",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "ix_booking_status_id",
                table: "booking",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "ix_booking_status_created_date",
                table: "booking_status",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_booking_status_is_deleted",
                table: "booking_status",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_booking_status_translation_created_date",
                table: "booking_status_translation",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_booking_status_translation_is_deleted",
                table: "booking_status_translation",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_booking_status_translation_status_id",
                table: "booking_status_translation",
                column: "status_id");

            migrationBuilder.AddForeignKey(
                name: "fk_booking_booking_status_status_id",
                table: "booking",
                column: "status_id",
                principalTable: "booking_status",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_booking_service_specifications_service_specification_id",
                table: "booking",
                column: "service_specification_id",
                principalTable: "service_specification",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_booking_services_service_id",
                table: "booking",
                column: "service_id",
                principalTable: "service",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_permission_translations_permissions_permission_id",
                table: "permission_translations",
                column: "permission_id",
                principalTable: "permissions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_role_permissions_permissions_permission_id",
                table: "role_permissions",
                column: "permission_id",
                principalTable: "permissions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_role_permissions_roles_role_id",
                table: "role_permissions",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_service_specification_service_service_id",
                table: "service_specification",
                column: "service_id",
                principalTable: "service",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_booking_booking_status_status_id",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "fk_booking_service_specifications_service_specification_id",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "fk_booking_services_service_id",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "fk_permission_translations_permissions_permission_id",
                table: "permission_translations");

            migrationBuilder.DropForeignKey(
                name: "fk_role_permissions_permissions_permission_id",
                table: "role_permissions");

            migrationBuilder.DropForeignKey(
                name: "fk_role_permissions_roles_role_id",
                table: "role_permissions");

            migrationBuilder.DropForeignKey(
                name: "fk_service_specification_service_service_id",
                table: "service_specification");

            migrationBuilder.DropTable(
                name: "booking_status_translation");

            migrationBuilder.DropTable(
                name: "booking_status");

            migrationBuilder.DropIndex(
                name: "ix_service_specification_service_id",
                table: "service_specification");

            migrationBuilder.DropIndex(
                name: "ix_booking_status_id",
                table: "booking");

            migrationBuilder.DropPrimaryKey(
                name: "pk_role_permissions",
                table: "role_permissions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_permission_translations",
                table: "permission_translations");

            migrationBuilder.DropColumn(
                name: "duration",
                table: "service_specification");

            migrationBuilder.DropColumn(
                name: "service_id",
                table: "service_specification");

            migrationBuilder.DropColumn(
                name: "status_id",
                table: "booking");

            migrationBuilder.RenameTable(
                name: "role_permissions",
                newName: "role_permission");

            migrationBuilder.RenameTable(
                name: "permission_translations",
                newName: "permission_translation");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "booking",
                newName: "booking_date_time");

            migrationBuilder.RenameIndex(
                name: "ix_role_permissions_role_id",
                table: "role_permission",
                newName: "ix_role_permission_role_id");

            migrationBuilder.RenameIndex(
                name: "ix_role_permissions_permission_id",
                table: "role_permission",
                newName: "ix_role_permission_permission_id");

            migrationBuilder.RenameIndex(
                name: "ix_role_permissions_is_deleted",
                table: "role_permission",
                newName: "ix_role_permission_is_deleted");

            migrationBuilder.RenameIndex(
                name: "ix_role_permissions_created_date",
                table: "role_permission",
                newName: "ix_role_permission_created_date");

            migrationBuilder.RenameIndex(
                name: "ix_permission_translations_permission_id",
                table: "permission_translation",
                newName: "ix_permission_translation_permission_id");

            migrationBuilder.RenameIndex(
                name: "ix_permission_translations_is_deleted",
                table: "permission_translation",
                newName: "ix_permission_translation_is_deleted");

            migrationBuilder.RenameIndex(
                name: "ix_permission_translations_created_date",
                table: "permission_translation",
                newName: "ix_permission_translation_created_date");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "duration",
                table: "booking",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddPrimaryKey(
                name: "pk_role_permission",
                table: "role_permission",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_permission_translation",
                table: "permission_translation",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_booking_service_service_id",
                table: "booking",
                column: "service_id",
                principalTable: "service",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_booking_service_specification_service_specification_id",
                table: "booking",
                column: "service_specification_id",
                principalTable: "service_specification",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_permission_translation_permissions_permission_id",
                table: "permission_translation",
                column: "permission_id",
                principalTable: "permissions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_role_permission_permissions_permission_id",
                table: "role_permission",
                column: "permission_id",
                principalTable: "permissions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_role_permission_roles_role_id",
                table: "role_permission",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
