using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPCloudMaker.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Companyname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GSTNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VATNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pincode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emailid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currencysymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decimalsymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecialPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompBankname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompAccNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accperiodfrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Accperiodto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BookPeropdfrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BookPeropdto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminpassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Confpassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagefolderpath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
