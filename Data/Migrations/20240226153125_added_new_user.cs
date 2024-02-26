using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OPC5_BlogApp.Migrations
{
    /// <inheritdoc />
    public partial class added_new_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_PostUserUserId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "PostUserUserId",
                table: "Posts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_PostUserUserId",
                table: "Posts",
                newName: "IX_Posts_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Posts",
                newName: "PostUserUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                newName: "IX_Posts_PostUserUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_PostUserUserId",
                table: "Posts",
                column: "PostUserUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
