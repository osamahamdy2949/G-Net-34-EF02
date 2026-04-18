using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignmet02.Migrations
{
    /// <inheritdoc />
    public partial class SelfRelationshipBtEventAndSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_SessionId",
                table: "Events",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Events_SessionId",
                table: "Events",
                column: "SessionId",
                principalTable: "Events",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Events_SessionId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_SessionId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Events");
        }
    }
}
