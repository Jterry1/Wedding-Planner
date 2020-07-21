using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wedders_planners_CreaterPlannerId",
                table: "wedders");

            migrationBuilder.DropIndex(
                name: "IX_wedders_CreaterPlannerId",
                table: "wedders");

            migrationBuilder.DropColumn(
                name: "CreaterPlannerId",
                table: "wedders");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "wedders",
                newName: "PlannerId");

            migrationBuilder.CreateIndex(
                name: "IX_wedders_PlannerId",
                table: "wedders",
                column: "PlannerId");

            migrationBuilder.AddForeignKey(
                name: "FK_wedders_planners_PlannerId",
                table: "wedders",
                column: "PlannerId",
                principalTable: "planners",
                principalColumn: "PlannerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wedders_planners_PlannerId",
                table: "wedders");

            migrationBuilder.DropIndex(
                name: "IX_wedders_PlannerId",
                table: "wedders");

            migrationBuilder.RenameColumn(
                name: "PlannerId",
                table: "wedders",
                newName: "UserId");

            migrationBuilder.AddColumn<int>(
                name: "CreaterPlannerId",
                table: "wedders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_wedders_CreaterPlannerId",
                table: "wedders",
                column: "CreaterPlannerId");

            migrationBuilder.AddForeignKey(
                name: "FK_wedders_planners_CreaterPlannerId",
                table: "wedders",
                column: "CreaterPlannerId",
                principalTable: "planners",
                principalColumn: "PlannerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
