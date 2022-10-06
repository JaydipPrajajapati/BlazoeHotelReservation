using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_Reservation.Data.Migrations
{
    public partial class addedapplicationuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_IdentityUserId1",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_IdentityUserId1",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "IdentityUserId1",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "IdentityUserId",
                table: "Bookings",
                newName: "ApplicationUserId");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ApplicationUserId1",
                table: "Bookings",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_ApplicationUserId1",
                table: "Bookings",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_ApplicationUserId1",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_ApplicationUserId1",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Bookings",
                newName: "IdentityUserId");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId1",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_IdentityUserId1",
                table: "Bookings",
                column: "IdentityUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_IdentityUserId1",
                table: "Bookings",
                column: "IdentityUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
