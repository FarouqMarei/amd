using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalDate",
                table: "Autos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContainerId",
                table: "Autos",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "RemainingPayment",
                table: "Autos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Autos_ContainerId",
                table: "Autos",
                column: "ContainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_Containers_ContainerId",
                table: "Autos",
                column: "ContainerId",
                principalTable: "Containers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autos_Containers_ContainerId",
                table: "Autos");

            migrationBuilder.DropIndex(
                name: "IX_Autos_ContainerId",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "ArrivalDate",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "ContainerId",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "RemainingPayment",
                table: "Autos");
        }
    }
}
