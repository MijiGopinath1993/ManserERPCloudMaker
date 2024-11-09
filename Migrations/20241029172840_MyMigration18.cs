using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPCloudMaker.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LogoFileName",
                table: "Company",
                newName: "LogoImageFile");

            migrationBuilder.CreateTable(
                name: "Productitems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateInc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MRP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rrate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wrate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VATPercentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productitems", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productitems");

            migrationBuilder.RenameColumn(
                name: "LogoImageFile",
                table: "Company",
                newName: "LogoFileName");
        }
    }
}
