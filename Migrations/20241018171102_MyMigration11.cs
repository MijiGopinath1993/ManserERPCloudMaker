using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPCloudMaker.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvoiceNumberSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    printaftersave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    printbarcodeaftersave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Invnumberingmethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allowduplicateinvno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Invnumberstart = table.Column<int>(type: "int", nullable: true),
                    MaxNoofdigits = table.Column<int>(type: "int", nullable: true),
                    Invoiceprefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Invoicepostfix = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceNumberSettings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceNumberSettings");
        }
    }
}
