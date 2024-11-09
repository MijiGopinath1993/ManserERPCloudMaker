using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPCloudMaker.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookPeropdto",
                table: "Company",
                newName: "BookPeriodto");

            migrationBuilder.RenameColumn(
                name: "BookPeropdfrom",
                table: "Company",
                newName: "BookPeriodfrom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookPeriodto",
                table: "Company",
                newName: "BookPeropdto");

            migrationBuilder.RenameColumn(
                name: "BookPeriodfrom",
                table: "Company",
                newName: "BookPeropdfrom");
        }
    }
}
