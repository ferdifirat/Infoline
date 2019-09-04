using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infoline.Api.Migrations
{
    public partial class addAnswerDateToUsersAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AnswerDate",
                table: "UserAnswers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerDate",
                table: "UserAnswers");
        }
    }
}
