using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPCloudMaker.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allowcostcentre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadharnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingNoORAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addressline2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addressline3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postalcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Faxnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emailid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creditlimit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    payterms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Defaultdiscount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pricelevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthlybudget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactpersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConperTelnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConperEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
