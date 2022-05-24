using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_ZPloy.Migrations
{
    public partial class taskuser4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tasks_TaskID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TaskID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TaskID",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "AppUserTask",
                columns: table => new
                {
                    CompletedTasksTaskID = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTask", x => new { x.CompletedTasksTaskID, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AppUserTask_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserTask_Tasks_CompletedTasksTaskID",
                        column: x => x.CompletedTasksTaskID,
                        principalTable: "Tasks",
                        principalColumn: "TaskID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserTask_UsersId",
                table: "AppUserTask",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserTask");

            migrationBuilder.AddColumn<int>(
                name: "TaskID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TaskID",
                table: "AspNetUsers",
                column: "TaskID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tasks_TaskID",
                table: "AspNetUsers",
                column: "TaskID",
                principalTable: "Tasks",
                principalColumn: "TaskID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
