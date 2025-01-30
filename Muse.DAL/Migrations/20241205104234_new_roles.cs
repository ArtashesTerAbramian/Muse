using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Muse.DAL.Migrations
{
    public partial class new_roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date" },
                values: new object[,]
                {
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null }
                });

            migrationBuilder.InsertData(
                table: "role_translation",
                columns: new[] { "id", "created_date", "is_deleted", "language_id", "modify_date", "name", "role_id" },
                values: new object[,]
                {
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1L, null, "Client", 2L },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2L, null, "Клиент", 2L },
                    { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3L, null, "Հաճախորդ", 2L },
                    { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1L, null, "Salon", 3L },
                    { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2L, null, "Салон", 3L },
                    { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3L, null, "Սալոն", 3L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_translation",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "role_translation",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "role_translation",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "role_translation",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "role_translation",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "role_translation",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3L);
        }
    }
}
