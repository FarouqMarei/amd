using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autos_LookupValue_AuctionId",
                table: "Autos");

            migrationBuilder.DropForeignKey(
                name: "FK_Autos_LookupValue_BrandId",
                table: "Autos");

            migrationBuilder.DropForeignKey(
                name: "FK_Autos_LookupValue_CityId",
                table: "Autos");

            migrationBuilder.DropForeignKey(
                name: "FK_Autos_LookupValue_DestinationId",
                table: "Autos");

            migrationBuilder.DropForeignKey(
                name: "FK_Autos_LookupValue_LoadPortId",
                table: "Autos");

            migrationBuilder.DropForeignKey(
                name: "FK_LookupValue_Lookup_LookupId",
                table: "LookupValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LookupValue",
                table: "LookupValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lookup",
                table: "Lookup");

            migrationBuilder.RenameTable(
                name: "LookupValue",
                newName: "LookupValues");

            migrationBuilder.RenameTable(
                name: "Lookup",
                newName: "Lookups");

            migrationBuilder.RenameIndex(
                name: "IX_LookupValue_LookupId",
                table: "LookupValues",
                newName: "IX_LookupValues_LookupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LookupValues",
                table: "LookupValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lookups",
                table: "Lookups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_LookupValues_AuctionId",
                table: "Autos",
                column: "AuctionId",
                principalTable: "LookupValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_LookupValues_BrandId",
                table: "Autos",
                column: "BrandId",
                principalTable: "LookupValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_LookupValues_CityId",
                table: "Autos",
                column: "CityId",
                principalTable: "LookupValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_LookupValues_DestinationId",
                table: "Autos",
                column: "DestinationId",
                principalTable: "LookupValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_LookupValues_LoadPortId",
                table: "Autos",
                column: "LoadPortId",
                principalTable: "LookupValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LookupValues_Lookups_LookupId",
                table: "LookupValues",
                column: "LookupId",
                principalTable: "Lookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autos_LookupValues_AuctionId",
                table: "Autos");

            migrationBuilder.DropForeignKey(
                name: "FK_Autos_LookupValues_BrandId",
                table: "Autos");

            migrationBuilder.DropForeignKey(
                name: "FK_Autos_LookupValues_CityId",
                table: "Autos");

            migrationBuilder.DropForeignKey(
                name: "FK_Autos_LookupValues_DestinationId",
                table: "Autos");

            migrationBuilder.DropForeignKey(
                name: "FK_Autos_LookupValues_LoadPortId",
                table: "Autos");

            migrationBuilder.DropForeignKey(
                name: "FK_LookupValues_Lookups_LookupId",
                table: "LookupValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LookupValues",
                table: "LookupValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lookups",
                table: "Lookups");

            migrationBuilder.RenameTable(
                name: "LookupValues",
                newName: "LookupValue");

            migrationBuilder.RenameTable(
                name: "Lookups",
                newName: "Lookup");

            migrationBuilder.RenameIndex(
                name: "IX_LookupValues_LookupId",
                table: "LookupValue",
                newName: "IX_LookupValue_LookupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LookupValue",
                table: "LookupValue",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lookup",
                table: "Lookup",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_LookupValue_AuctionId",
                table: "Autos",
                column: "AuctionId",
                principalTable: "LookupValue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_LookupValue_BrandId",
                table: "Autos",
                column: "BrandId",
                principalTable: "LookupValue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_LookupValue_CityId",
                table: "Autos",
                column: "CityId",
                principalTable: "LookupValue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_LookupValue_DestinationId",
                table: "Autos",
                column: "DestinationId",
                principalTable: "LookupValue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Autos_LookupValue_LoadPortId",
                table: "Autos",
                column: "LoadPortId",
                principalTable: "LookupValue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LookupValue_Lookup_LookupId",
                table: "LookupValue",
                column: "LookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
