using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionMicro.Migrations
{
    public partial class addedAuctionEndedtoAuctionEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mile",
                table: "Items",
                newName: "Mileage");

            migrationBuilder.AddColumn<DateTime>(
                name: "AuctionEnd",
                table: "Auctions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuctionEnd",
                table: "Auctions");

            migrationBuilder.RenameColumn(
                name: "Mileage",
                table: "Items",
                newName: "Mile");
        }
    }
}
