using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace METABack.Migrations
{
    public partial class directeur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Codeutil",
                table: "Securite_Directeur",
                newName: "Login");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Securite_Directeur",
                newName: "Codeutil");
        }
    }
}
