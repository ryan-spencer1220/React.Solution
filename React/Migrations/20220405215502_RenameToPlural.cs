using Microsoft.EntityFrameworkCore.Migrations;

namespace React.Migrations
{
    public partial class RenameToPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Redux",
                table: "Redux");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NoSQL",
                table: "NoSQL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Introduction",
                table: "Introduction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FundamentalsTwo",
                table: "FundamentalsTwo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FundamentalsOne",
                table: "FundamentalsOne");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Api",
                table: "Api");

            migrationBuilder.RenameTable(
                name: "Redux",
                newName: "Reduxes");

            migrationBuilder.RenameTable(
                name: "NoSQL",
                newName: "NoSQLs");

            migrationBuilder.RenameTable(
                name: "Introduction",
                newName: "Introductions");

            migrationBuilder.RenameTable(
                name: "FundamentalsTwo",
                newName: "FundamentalsTwos");

            migrationBuilder.RenameTable(
                name: "FundamentalsOne",
                newName: "FundamentalsOnes");

            migrationBuilder.RenameTable(
                name: "Api",
                newName: "Apis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reduxes",
                table: "Reduxes",
                column: "ReduxId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NoSQLs",
                table: "NoSQLs",
                column: "NoSQLId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Introductions",
                table: "Introductions",
                column: "IntroductionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FundamentalsTwos",
                table: "FundamentalsTwos",
                column: "FundamentalsTwoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FundamentalsOnes",
                table: "FundamentalsOnes",
                column: "FundamentalsOneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apis",
                table: "Apis",
                column: "ApiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reduxes",
                table: "Reduxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NoSQLs",
                table: "NoSQLs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Introductions",
                table: "Introductions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FundamentalsTwos",
                table: "FundamentalsTwos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FundamentalsOnes",
                table: "FundamentalsOnes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apis",
                table: "Apis");

            migrationBuilder.RenameTable(
                name: "Reduxes",
                newName: "Redux");

            migrationBuilder.RenameTable(
                name: "NoSQLs",
                newName: "NoSQL");

            migrationBuilder.RenameTable(
                name: "Introductions",
                newName: "Introduction");

            migrationBuilder.RenameTable(
                name: "FundamentalsTwos",
                newName: "FundamentalsTwo");

            migrationBuilder.RenameTable(
                name: "FundamentalsOnes",
                newName: "FundamentalsOne");

            migrationBuilder.RenameTable(
                name: "Apis",
                newName: "Api");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Redux",
                table: "Redux",
                column: "ReduxId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NoSQL",
                table: "NoSQL",
                column: "NoSQLId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Introduction",
                table: "Introduction",
                column: "IntroductionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FundamentalsTwo",
                table: "FundamentalsTwo",
                column: "FundamentalsTwoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FundamentalsOne",
                table: "FundamentalsOne",
                column: "FundamentalsOneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Api",
                table: "Api",
                column: "ApiId");
        }
    }
}
