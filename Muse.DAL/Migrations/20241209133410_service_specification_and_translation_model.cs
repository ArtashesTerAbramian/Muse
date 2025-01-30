using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Muse.DAL.Migrations
{
    public partial class service_specification_and_translation_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "service_specification",
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
                    table.PrimaryKey("pk_service_specification", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "service_specification_translation",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    descripton = table.Column<string>(type: "text", nullable: true),
                    service_id = table.Column<long>(type: "bigint", nullable: false),
                    service_specification_id = table.Column<long>(type: "bigint", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    language_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_service_specification_translation", x => x.id);
                    table.ForeignKey(
                        name: "fk_service_specification_translation_service_service_id",
                        column: x => x.service_id,
                        principalTable: "service",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_service_specification_translation_service_specification_ser",
                        column: x => x.service_specification_id,
                        principalTable: "service_specification",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_service_specification_created_date",
                table: "service_specification",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_service_specification_is_deleted",
                table: "service_specification",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_service_specification_translation_created_date",
                table: "service_specification_translation",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_service_specification_translation_is_deleted",
                table: "service_specification_translation",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_service_specification_translation_service_id",
                table: "service_specification_translation",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "ix_service_specification_translation_service_specification_id",
                table: "service_specification_translation",
                column: "service_specification_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "service_specification_translation");

            migrationBuilder.DropTable(
                name: "service_specification");
        }
    }
}
