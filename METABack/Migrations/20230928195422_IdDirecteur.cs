using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace METABack.Migrations
{
    public partial class IdDirecteur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Securite_Directeur",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Securite_Directeur",
                table: "Securite_Directeur",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Securite_Directeur",
                table: "Securite_Directeur");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Securite_Directeur");
        }
    }
}
