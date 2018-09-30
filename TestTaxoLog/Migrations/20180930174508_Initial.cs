using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTaxoLog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SystemUser",
                columns: table => new
                {
                    SystemUserId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsDisabled = table.Column<bool>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUsers", x => x.SystemUserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemUser");
        }
    }
}
