using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Muse.DAL.Migrations
{
    public partial class servicespecification_and_translation_seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "service_specification",
                columns: new[] { "id", "created_date", "duration", "is_deleted", "modify_date", "service_id" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 40, 0, 0), false, null, 1L },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), false, null, 1L },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0), false, null, 1L },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0), false, null, 1L },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0), false, null, 1L },
                    { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 30, 0, 0), false, null, 2L },
                    { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), false, null, 2L },
                    { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0), false, null, 2L },
                    { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), false, null, 2L },
                    { 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0), false, null, 2L },
                    { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 30, 0, 0), false, null, 2L },
                    { 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 30, 0, 0), false, null, 2L },
                    { 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), false, null, 3L },
                    { 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0), false, null, 3L },
                    { 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0), false, null, 3L },
                    { 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0), false, null, 3L },
                    { 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), false, null, 4L },
                    { 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), false, null, 4L },
                    { 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), false, null, 4L },
                    { 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), false, null, 4L },
                    { 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), false, null, 4L },
                    { 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), false, null, 4L }
                });

            migrationBuilder.InsertData(
                table: "service_specification_translation",
                columns: new[] { "id", "created_date", "description", "is_deleted", "language_id", "modify_date", "name", "service_id", "service_specification_id" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(without eye makeup) 40 minutes", false, 1L, null, "Everyday Makeup Duration", 1L, null },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(без макияжа глаз) 40 минут", false, 2L, null, "Каждодневный макияж длительность", 1L, null },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(without lashes) 1 hour", false, 1L, null, "Evening Makeup Duration", 1L, null },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(без ресниц) 1 час", false, 2L, null, "Вечерний макияж длительность", 1L, null },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(with lashes) 1 hour 30 minutes", false, 1L, null, "Evening Makeup Duration", 1L, null },
                    { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(с ресницами) 1 час 30 минут", false, 2L, null, "Вечерний макияж длительность", 1L, null },
                    { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(without false lashes) 1 hour 30 minutes", false, 1L, null, "Bridal Makeup Duration", 1L, null },
                    { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(без ресниц) 1 час 30 минут", false, 2L, null, "Макияж невесты длительность", 1L, null },
                    { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(with false lashes) 1 hour 30 minutes", false, 1L, null, "Bridal Makeup Duration", 1L, null },
                    { 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(с ресницами) 1 час 30 минут", false, 2L, null, "Макияж невесты длительность", 1L, null },
                    { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(without nail polish) 30 minutes", false, 1L, null, "Manicure Duration", 2L, null },
                    { 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(без покрытия) 30 минут", false, 2L, null, "Маникюр длительность", 2L, null },
                    { 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(with nail polish) 1 hour", false, 1L, null, "Manicure Duration", 2L, null },
                    { 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(с покрытием) 1 час", false, 2L, null, "Маникюр длительность", 2L, null },
                    { 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 hour 30 minutes", false, 1L, null, "Gel Manicure Duration", 2L, null },
                    { 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 час 30 минут", false, 2L, null, "Гель маникюр длительность", 2L, null },
                    { 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 hour", false, 1L, null, "Japanese Manicure Duration", 2L, null },
                    { 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 час", false, 2L, null, "Японский маникюр длительность", 2L, null },
                    { 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 hours", false, 1L, null, "Simple Design Duration", 2L, null },
                    { 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 часа", false, 2L, null, "Простой дизайн длительность", 2L, null },
                    { 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 hours 30 minutes", false, 1L, null, "Art Design Duration", 2L, null },
                    { 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 часа 30 минут", false, 2L, null, "Арт дизайн длительность", 2L, null },
                    { 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(with gel coating) 2 hours 30 minutes", false, 1L, null, "Extensions Duration", 2L, null },
                    { 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(с гель покрытием) 2 часа 30 минут", false, 2L, null, "Наращивание длительность", 2L, null },
                    { 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(without nail polish) 1 hour", false, 1L, null, "Pedicure Toes Duration", 3L, null },
                    { 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(без покрытия) 1 час", false, 2L, null, "Педикюр пальцы длительность", 3L, null },
                    { 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(without nail polish) 1 hour 30 minutes", false, 1L, null, "Pedicure Toes + Feet Duration", 3L, null },
                    { 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(без покрытия) 1 час 30 минут", false, 2L, null, "Педикюр пальцы + ступни длительность", 3L, null },
                    { 29L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(with nail polish) 1 hour 30 minutes", false, 1L, null, "Pedicure Toes Duration", 3L, null },
                    { 30L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(с покрытием) 1 час 30 минут", false, 2L, null, "Педикюр пальцы длительность", 3L, null },
                    { 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(with nail polish) 2 hours", false, 1L, null, "Pedicure Toes + Feet Duration", 3L, null },
                    { 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(с покрытием) 2 часа", false, 2L, null, "Педикюр пальцы + ступни длительность", 3L, null },
                    { 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 hour", false, 1L, null, "Brows Correction Duration", 4L, null },
                    { 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 час", false, 2L, null, "Коррекция бровей длительность", 4L, null },
                    { 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 hour", false, 1L, null, "Brows Colouring Duration", 4L, null },
                    { 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 час", false, 2L, null, "Окрашивание бровей длительность", 4L, null },
                    { 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 hour", false, 1L, null, "Brows Bleaching Duration", 4L, null },
                    { 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 час", false, 2L, null, "Обесцвечивание бровей длительность", 4L, null },
                    { 39L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 hour", false, 1L, null, "Brows Lamination Duration", 4L, null },
                    { 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 час", false, 2L, null, "Ламинация бровей длительность", 4L, null },
                    { 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 hour", false, 1L, null, "Lashes Lamination Duration", 4L, null },
                    { 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 час", false, 2L, null, "Ламинация ресниц длительность", 4L, null },
                    { 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 hour", false, 1L, null, "Brows + Lashes Lamination Duration", 4L, null },
                    { 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 час", false, 2L, null, "Ламинация бровей + ресниц длительность", 4L, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "service_specification",
                keyColumn: "id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "service_specification_translation",
                keyColumn: "id",
                keyValue: 44L);
        }
    }
}
