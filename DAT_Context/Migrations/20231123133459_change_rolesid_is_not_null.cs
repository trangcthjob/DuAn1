using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAT_Context.Migrations
{
    public partial class change_rolesid_is_not_null : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Roles_RolesId",
                table: "Accounts");

            migrationBuilder.AlterColumn<Guid>(
                name: "RolesId",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Roles_RolesId",
                table: "Accounts",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Roles_RolesId",
                table: "Accounts");

            migrationBuilder.AlterColumn<Guid>(
                name: "RolesId",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Roles_RolesId",
                table: "Accounts",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
