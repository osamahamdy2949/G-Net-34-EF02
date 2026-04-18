using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignmet02.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipBtOrganizerAndProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizerId",
                table: "OrganizerProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizerProfiles_OrganizerId",
                table: "OrganizerProfiles",
                column: "OrganizerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizerProfiles_Organizers_OrganizerId",
                table: "OrganizerProfiles",
                column: "OrganizerId",
                principalTable: "Organizers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizerProfiles_Organizers_OrganizerId",
                table: "OrganizerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_OrganizerProfiles_OrganizerId",
                table: "OrganizerProfiles");

            migrationBuilder.DropColumn(
                name: "OrganizerId",
                table: "OrganizerProfiles");
        }
    }
}
