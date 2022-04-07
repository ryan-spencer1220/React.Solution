using Microsoft.EntityFrameworkCore.Migrations;

namespace React.Migrations
{
    public partial class UpdateAfterMerge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lesson6Complete",
                table: "Apis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Lesson6Complete",
                table: "Apis",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
