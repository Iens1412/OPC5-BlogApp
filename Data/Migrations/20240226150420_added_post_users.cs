using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OPC5_BlogApp.Migrations
{
    /// <inheritdoc />
    public partial class added_post_users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostUserUserId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostUserUserId",
                table: "Posts",
                column: "PostUserUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_PostUserUserId",
                table: "Posts",
                column: "PostUserUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_PostUserUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostUserUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostUserUserId",
                table: "Posts");
        }
    }
}
