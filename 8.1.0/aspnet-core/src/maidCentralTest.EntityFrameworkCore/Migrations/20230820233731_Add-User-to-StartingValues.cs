using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace maidCentralTest.Migrations
{
    /// <inheritdoc />
    public partial class AddUsertoStartingValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "StartingValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "StartingValues",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "StartingValues",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "StartingValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StartingValues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "StartingValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "StartingValues",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StartingValues_CreatorUserId",
                table: "StartingValues",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StartingValues_DeleterUserId",
                table: "StartingValues",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StartingValues_LastModifierUserId",
                table: "StartingValues",
                column: "LastModifierUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_StartingValues_AbpUsers_CreatorUserId",
                table: "StartingValues",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StartingValues_AbpUsers_DeleterUserId",
                table: "StartingValues",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StartingValues_AbpUsers_LastModifierUserId",
                table: "StartingValues",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StartingValues_AbpUsers_CreatorUserId",
                table: "StartingValues");

            migrationBuilder.DropForeignKey(
                name: "FK_StartingValues_AbpUsers_DeleterUserId",
                table: "StartingValues");

            migrationBuilder.DropForeignKey(
                name: "FK_StartingValues_AbpUsers_LastModifierUserId",
                table: "StartingValues");

            migrationBuilder.DropIndex(
                name: "IX_StartingValues_CreatorUserId",
                table: "StartingValues");

            migrationBuilder.DropIndex(
                name: "IX_StartingValues_DeleterUserId",
                table: "StartingValues");

            migrationBuilder.DropIndex(
                name: "IX_StartingValues_LastModifierUserId",
                table: "StartingValues");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "StartingValues");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "StartingValues");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "StartingValues");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "StartingValues");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StartingValues");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "StartingValues");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "StartingValues");
        }
    }
}
