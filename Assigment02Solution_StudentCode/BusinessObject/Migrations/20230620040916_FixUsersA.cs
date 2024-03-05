using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObject.Migrations
{
    public partial class FixUsersA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Publisher_PubId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PubId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HireDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Publisher_PubId",
                table: "Users",
                column: "PubId",
                principalTable: "Publisher",
                principalColumn: "Pub_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Role_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Publisher_PubId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PubId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HireDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Publisher_PubId",
                table: "Users",
                column: "PubId",
                principalTable: "Publisher",
                principalColumn: "Pub_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Role_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
