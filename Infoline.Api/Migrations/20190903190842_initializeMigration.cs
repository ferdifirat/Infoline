using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infoline.Api.Migrations
{
    public partial class initializeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_Answers_AnswerId",
                table: "UserAnswers");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.RenameColumn(
                name: "AnswerId",
                table: "UserAnswers",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAnswers_AnswerId",
                table: "UserAnswers",
                newName: "IX_UserAnswers_QuestionId");

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "UserAnswers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_Questions_QuestionId",
                table: "UserAnswers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_Questions_QuestionId",
                table: "UserAnswers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropColumn(
                name: "Answer",
                table: "UserAnswers");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "UserAnswers",
                newName: "AnswerId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAnswers_QuestionId",
                table: "UserAnswers",
                newName: "IX_UserAnswers_AnswerId");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnsweredDate = table.Column<DateTime>(nullable: false),
                    Answers = table.Column<string>(nullable: true),
                    CorrectAnswer = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    Result = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_Answers_AnswerId",
                table: "UserAnswers",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
