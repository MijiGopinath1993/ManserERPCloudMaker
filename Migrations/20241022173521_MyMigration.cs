using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPCloudMaker.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productunits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GSTRUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productunits", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productunits");
        }



        //constraints: table =>
        //        {
        //            table.PrimaryKey("PK_EnterpriceDocuments", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_EnterpriceDocuments_TechnologyAssets_AssetId",
        //                column: x => x.AssetId,
        //                principalTable: "TechnologyAssets",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_EnterpriceDocuments_AssetId",
        //        table: "EnterpriceDocuments",
        //        column: "AssetId");
    }
}
