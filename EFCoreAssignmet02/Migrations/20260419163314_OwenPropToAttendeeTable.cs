using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignmet02.Migrations
{
    /// <inheritdoc />
    public partial class OwenPropToAttendeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Attendees",
                newName: "HomeAddress_Street");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Attendees",
                newName: "HomeAddress_PostalCode");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Attendees",
                newName: "HomeAddress_Country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Attendees",
                newName: "HomeAddress_City");

            migrationBuilder.AlterColumn<string>(
                name: "HomeAddress_Street",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HomeAddress_PostalCode",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HomeAddress_Country",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HomeAddress_City",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HomeAddress_Street",
                table: "Attendees",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "HomeAddress_PostalCode",
                table: "Attendees",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "HomeAddress_Country",
                table: "Attendees",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "HomeAddress_City",
                table: "Attendees",
                newName: "City");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
