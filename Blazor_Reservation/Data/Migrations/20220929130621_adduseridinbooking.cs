using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_Reservation.Data.Migrations
{
    public partial class adduseridinbooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "IdentityUserId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_IdentityUserId1",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_IdentityUserId1",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "IdentityUserId1",
                table: "Bookings");
        }
    }
}
