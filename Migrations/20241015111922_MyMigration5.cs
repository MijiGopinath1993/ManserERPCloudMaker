using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPCloudMaker.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Education = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    DateofJoining = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    DepName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TeamName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Contracttype = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    contractexpirydate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DisconnectDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    workingfor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VisaFrom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CostCat = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Empaddress = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    EmpCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Empcontactno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    emailid = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Peraddress = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    PerCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Percontactno1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Percontactno2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Peremailid = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    RefName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RefAddress = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    RefCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RefContactNo1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RefContactNo2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RefEmailid = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    RefNotes = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    EmpPersonalID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    bankcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    bankacno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Basicsalary = table.Column<double>(type: "float", nullable: true),
                    rateperhour = table.Column<double>(type: "float", nullable: true),
                    SalaryType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    empbankname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    empbankacno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    empbankbranch = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    bankifsccode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    bankmicrcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
