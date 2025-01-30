using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Muse.DAL.Migrations
{
    public partial class service_specification_translation_name_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "descripton",
                table: "service_specification_translation",
                newName: "description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "service_specification_translation",
                newName: "descripton");
        }
    }
}
