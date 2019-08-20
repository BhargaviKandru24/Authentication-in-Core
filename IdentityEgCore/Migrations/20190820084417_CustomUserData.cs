using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityEgCore.Migrations
{
    public partial class CustomUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Id = table.Column<string>(nullable:false)
                }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
