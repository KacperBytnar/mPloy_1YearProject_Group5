using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_ZPloy.Migrations
{
    public partial class finalone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Inboxes_InboxID",
                table: "Notifications");

            migrationBuilder.DropTable(
                name: "Inboxes");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_InboxID",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "InboxID",
                table: "Notifications");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Notifications",
                newName: "MessageText");

            migrationBuilder.AddColumn<string>(
                name: "PictureName",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isRead",
                table: "Notifications",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureName",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "isRead",
                table: "Notifications");

            migrationBuilder.RenameColumn(
                name: "MessageText",
                table: "Notifications",
                newName: "Message");

            migrationBuilder.AddColumn<int>(
                name: "InboxID",
                table: "Notifications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Inboxes",
                columns: table => new
                {
                    InboxID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inboxes", x => x.InboxID);
                    table.ForeignKey(
                        name: "FK_Inboxes_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_InboxID",
                table: "Notifications",
                column: "InboxID");

            migrationBuilder.CreateIndex(
                name: "IX_Inboxes_UserID",
                table: "Inboxes",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Inboxes_InboxID",
                table: "Notifications",
                column: "InboxID",
                principalTable: "Inboxes",
                principalColumn: "InboxID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
