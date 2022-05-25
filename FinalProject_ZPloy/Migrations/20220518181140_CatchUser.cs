using Microsoft.EntityFrameworkCore.Migrations;

namespace mPloy_FinalProject_group5.Migrations
{
    public partial class CatchUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "XDUsername",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "lolPassword",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "XDUsername",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lolPassword",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
