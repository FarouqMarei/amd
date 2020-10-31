using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autos_Containers_ContainerId",
                table: "Autos");

            migrationBuilder.AlterColumn<int>(
                name: "ContainerId",
                table: "Autos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PaperStatus",
                table: "Autos",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_Containers_ContainerId",
                table: "Autos",
                column: "ContainerId",
                principalTable: "Containers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autos_Containers_ContainerId",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "PaperStatus",
                table: "Autos");

            migrationBuilder.AlterColumn<int>(
                name: "ContainerId",
                table: "Autos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_Containers_ContainerId",
                table: "Autos",
                column: "ContainerId",
                principalTable: "Containers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
