using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAT_Context.Migrations
{
    public partial class ThemDiaChiGV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "GiangViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "GiangViens");
        }
    }
}
