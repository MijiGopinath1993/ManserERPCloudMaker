using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPCloudMaker.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VoucherNames",
                table: "VoucherNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceNumberSettings",
                table: "InvoiceNumberSettings");

            migrationBuilder.RenameTable(
                name: "VoucherNames",
                newName: "Vouchernames");

            migrationBuilder.RenameTable(
                name: "InvoiceNumberSettings",
                newName: "Invoicenumbersettings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vouchernames",
                table: "Vouchernames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoicenumbersettings",
                table: "Invoicenumbersettings",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vouchernames",
                table: "Vouchernames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoicenumbersettings",
                table: "Invoicenumbersettings");

            migrationBuilder.RenameTable(
                name: "Vouchernames",
                newName: "VoucherNames");

            migrationBuilder.RenameTable(
                name: "Invoicenumbersettings",
                newName: "InvoiceNumberSettings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VoucherNames",
                table: "VoucherNames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceNumberSettings",
                table: "InvoiceNumberSettings",
                column: "Id");
        }
    }
}
