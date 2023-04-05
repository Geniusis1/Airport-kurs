using Microsoft.EntityFrameworkCore.Migrations;

namespace Airport_kurs.Migrations
{
    public partial class addAccessToUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessLvl",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessLvl",
                table: "Users");
        }
    }
}
