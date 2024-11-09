using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPCloudMaker.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Permisionpages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pagecode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createdon = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserPassword = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: true),
                    UserEmailId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserSecurityQ1 = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    UserSecurityQ2 = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    UserSecurityA1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserSecurityA2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserDepartment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StoreName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoginSystemName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsLogin = table.Column<bool>(type: "bit", nullable: true),
                    LogoutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SQLUserID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SQLpwd = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: false),
                    CounterID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permisions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
