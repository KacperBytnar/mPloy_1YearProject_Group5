using Microsoft.EntityFrameworkCore.Migrations;

namespace mPloy_FinalProject_group5.Migrations
{
    public partial class taskuser9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserTask");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
