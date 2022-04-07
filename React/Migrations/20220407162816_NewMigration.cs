using Microsoft.EntityFrameworkCore.Migrations;

namespace React.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModuleComplete",
                table: "Reduxes");

            migrationBuilder.DropColumn(
                name: "Lesson7Complete",
                table: "NoSQLs");

            migrationBuilder.DropColumn(
                name: "ModuleComplete",
                table: "NoSQLs");

            migrationBuilder.DropColumn(
                name: "ModuleComplete",
                table: "FundamentalsTwos");

            migrationBuilder.DropColumn(
                name: "Lesson7Complete",
                table: "FundamentalsOnes");

            migrationBuilder.DropColumn(
                name: "ModuleComplete",
                table: "FundamentalsOnes");

            migrationBuilder.DropColumn(
                name: "ModuleComplete",
                table: "Apis");

            migrationBuilder.RenameColumn(
                name: "ModuleComplete",
                table: "Introductions",
                newName: "Lesson4Complete");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lesson4Complete",
                table: "Introductions",
                newName: "ModuleComplete");

            migrationBuilder.AddColumn<bool>(
                name: "ModuleComplete",
                table: "Reduxes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Lesson7Complete",
                table: "NoSQLs",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ModuleComplete",
                table: "NoSQLs",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ModuleComplete",
                table: "FundamentalsTwos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Lesson7Complete",
                table: "FundamentalsOnes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ModuleComplete",
                table: "FundamentalsOnes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ModuleComplete",
                table: "Apis",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
