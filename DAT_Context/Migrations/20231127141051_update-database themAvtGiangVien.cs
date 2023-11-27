using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAT_Context.Migrations
{
    public partial class updatedatabasethemAvtGiangVien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "GiangViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "GiangViens");
        }
    }
}
