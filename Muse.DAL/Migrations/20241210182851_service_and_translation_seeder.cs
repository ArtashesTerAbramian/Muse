using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Muse.DAL.Migrations
{
    public partial class service_and_translation_seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "service",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null }
                });

            migrationBuilder.InsertData(
                table: "service_translation",
                columns: new[] { "id", "created_date", "description", "is_deleted", "language_id", "modify_date", "name", "service_id" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makeup", false, 1L, null, "Makeup", 1L },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Макияж", false, 2L, null, "Макияж", 1L },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manicure", false, 1L, null, "Manicure", 2L },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Маникюр", false, 2L, null, "Маникюр", 2L },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedicure", false, 1L, null, "Pedicure", 3L },
                    { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Педикюр", false, 2L, null, "Педикюр", 3L },
                    { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brows/Lashes", false, 1L, null, "Brows/Lashes", 4L },
                    { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Брови/ресницы", false, 2L, null, "Брови/ресницы", 4L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "service_translation",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "service_translation",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "service_translation",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "service_translation",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "service_translation",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "service_translation",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "service_translation",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "service_translation",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "service",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "service",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "service",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "service",
                keyColumn: "id",
                keyValue: 4L);
        }
    }
}
