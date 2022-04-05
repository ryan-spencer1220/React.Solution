using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace React.Solution.Migrations
{
    public partial class AddModules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "something",
                table: "AspNetUsers",
                newName: "NoSQLId");

            migrationBuilder.AddColumn<int>(
                name: "ApiId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FundamentalsOneId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FundamentalsTwoId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Apis",
                columns: table => new
                {
                    ApiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lesson1Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson2Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson3Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson4Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson5Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson6Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModuleComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apis", x => x.ApiId);
                });

            migrationBuilder.CreateTable(
                name: "FundamentalsOnes",
                columns: table => new
                {
                    FundamentalsOneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lesson1Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson2Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson3Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson4Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson5Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson6Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson7Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModuleComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundamentalsOnes", x => x.FundamentalsOneId);
                });

            migrationBuilder.CreateTable(
                name: "FundamentalsTwos",
                columns: table => new
                {
                    FundamentalsTwoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lesson1Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson2Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson3Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson4Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson5Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson6Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson7Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModuleComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundamentalsTwos", x => x.FundamentalsTwoId);
                });

            migrationBuilder.CreateTable(
                name: "NoSQLs",
                columns: table => new
                {
                    NoSQLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lesson1Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson2Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson3Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson4Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson5Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson6Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson7Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModuleComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoSQLs", x => x.NoSQLId);
                });

            migrationBuilder.CreateTable(
                name: "Reduxes",
                columns: table => new
                {
                    ReduxId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lesson1Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson2Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson3Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson4Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson5Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson6Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lesson7Complete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModuleComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reduxes", x => x.ReduxId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apis");

            migrationBuilder.DropTable(
                name: "FundamentalsOnes");

            migrationBuilder.DropTable(
                name: "FundamentalsTwos");

            migrationBuilder.DropTable(
                name: "NoSQLs");

            migrationBuilder.DropTable(
                name: "Reduxes");

            migrationBuilder.DropColumn(
                name: "ApiId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FundamentalsOneId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FundamentalsTwoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "NoSQLId",
                table: "AspNetUsers",
                newName: "something");
        }
    }
}
