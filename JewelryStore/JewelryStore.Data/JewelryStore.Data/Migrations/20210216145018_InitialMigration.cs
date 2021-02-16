using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace JewelryStore.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
            //seeder
            migrationBuilder.Sql(@"INSERT INTO Roles(Name) VALUES('normal')");
            migrationBuilder.Sql(@"INSERT INTO Roles(Name) VALUES('privileged')");
            migrationBuilder.Sql(@"INSERT INTO Users(Name,UserName,Password,RoleId,Token) VALUES('normal', 'normal.user', 'normal', 1, '5158bd98-34fc-465c-b7b8-88f998437042')");
            migrationBuilder.Sql(@"INSERT INTO Users(Name,UserName,Password,RoleId,Token) VALUES('privileged', 'privileged.user','privileged', 2, 'cdd4a4c4-8265-46bd-b388-dc13e338d7f9')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
