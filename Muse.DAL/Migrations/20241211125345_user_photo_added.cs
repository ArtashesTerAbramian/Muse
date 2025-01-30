using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Muse.DAL.Migrations
{
    public partial class user_photo_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "photo_url",
                table: "users",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "photo_url",
                table: "users");
        }
    }
}
