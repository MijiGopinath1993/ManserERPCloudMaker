using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPCloudMaker.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemSizeColor",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customergroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accounttype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allowcostcentre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iscomposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadharnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ConperEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allowsendsms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allowsendemail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropColumn(
                name: "ItemSizeColor",
                table: "Company");
        }
    }
}
