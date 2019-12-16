using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookio.Data.Migrations
{
    public partial class AddedNumVoters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumVoters",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumVoters",
                table: "Books");
        }
    }
}
