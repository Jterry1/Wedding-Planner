using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendants_planners_GuestsPlannerId",
                table: "attendants");

            migrationBuilder.DropIndex(
                name: "IX_attendants_GuestsPlannerId",
                table: "attendants");

            migrationBuilder.DropColumn(
                name: "GuestsPlannerId",
                table: "attendants");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "attendants",
                newName: "PlannerId");

            migrationBuilder.CreateIndex(
                name: "IX_attendants_PlannerId",
                table: "attendants",
                column: "PlannerId");

            migrationBuilder.AddForeignKey(
                name: "FK_attendants_planners_PlannerId",
                table: "attendants",
                column: "PlannerId",
                principalTable: "planners",
                principalColumn: "PlannerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendants_planners_PlannerId",
                table: "attendants");

            migrationBuilder.DropIndex(
                name: "IX_attendants_PlannerId",
                table: "attendants");

            migrationBuilder.RenameColumn(
                name: "PlannerId",
                table: "attendants",
                newName: "UserId");

            migrationBuilder.AddColumn<int>(
                name: "GuestsPlannerId",
                table: "attendants",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_attendants_GuestsPlannerId",
                table: "attendants",
                column: "GuestsPlannerId");

            migrationBuilder.AddForeignKey(
                name: "FK_attendants_planners_GuestsPlannerId",
                table: "attendants",
                column: "GuestsPlannerId",
                principalTable: "planners",
                principalColumn: "PlannerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
