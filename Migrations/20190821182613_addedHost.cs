using Microsoft.EntityFrameworkCore.Migrations;

namespace weddingPlanner.Migrations
{
    public partial class addedHost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HostUserId",
                table: "Weddings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weddings_HostUserId",
                table: "Weddings",
                column: "HostUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weddings_Users_HostUserId",
                table: "Weddings",
                column: "HostUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weddings_Users_HostUserId",
                table: "Weddings");

            migrationBuilder.DropIndex(
                name: "IX_Weddings_HostUserId",
                table: "Weddings");

            migrationBuilder.DropColumn(
                name: "HostUserId",
                table: "Weddings");
        }
    }
}
