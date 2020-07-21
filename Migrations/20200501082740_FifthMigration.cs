using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendants_wedders_EventWeddingId",
                table: "attendants");

            migrationBuilder.DropIndex(
                name: "IX_attendants_EventWeddingId",
                table: "attendants");

            migrationBuilder.DropColumn(
                name: "EventWeddingId",
                table: "attendants");

            migrationBuilder.RenameColumn(
                name: "Wedding",
                table: "attendants",
                newName: "WeddingId");

            migrationBuilder.CreateIndex(
                name: "IX_attendants_WeddingId",
                table: "attendants",
                column: "WeddingId");

            migrationBuilder.AddForeignKey(
                name: "FK_attendants_wedders_WeddingId",
                table: "attendants",
                column: "WeddingId",
                principalTable: "wedders",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendants_wedders_WeddingId",
                table: "attendants");

            migrationBuilder.DropIndex(
                name: "IX_attendants_WeddingId",
                table: "attendants");

            migrationBuilder.RenameColumn(
                name: "WeddingId",
                table: "attendants",
                newName: "Wedding");

            migrationBuilder.AddColumn<int>(
                name: "EventWeddingId",
                table: "attendants",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_attendants_EventWeddingId",
                table: "attendants",
                column: "EventWeddingId");

            migrationBuilder.AddForeignKey(
                name: "FK_attendants_wedders_EventWeddingId",
                table: "attendants",
                column: "EventWeddingId",
                principalTable: "wedders",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
