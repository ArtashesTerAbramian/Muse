using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Muse.DAL.Migrations
{
    public partial class access_denied_error_seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "errors",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date" },
                values: new object[] { 11L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "error_translations",
                columns: new[] { "id", "created_date", "error_id", "is_deleted", "language_id", "modify_date", "name" },
                values: new object[,]
                {
                    { 31L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 11L, false, 1L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Access Denied" },
                    { 32L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 11L, false, 2L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доступ запрещен" },
                    { 33L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 11L, false, 3L, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Հասանելիության սահմանափակում" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "error_translations",
                keyColumn: "id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "error_translations",
                keyColumn: "id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "error_translations",
                keyColumn: "id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 11L);
        }
    }
}
