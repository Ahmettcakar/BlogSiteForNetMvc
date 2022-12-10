using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class profileEducationeditlistprofileEducation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Educations_EducationId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_EducationId",
                table: "Profiles");

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "Educations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ProfileId",
                table: "Educations",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Profiles_ProfileId",
                table: "Educations",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Profiles_ProfileId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_ProfileId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Educations");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_EducationId",
                table: "Profiles",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Educations_EducationId",
                table: "Profiles",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
