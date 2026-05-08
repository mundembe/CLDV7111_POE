using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventEase.Migrations
{
    /// <inheritdoc />
    public partial class CreateEventsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Events_EventId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Events",
                newName: "EventModelId");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Bookings",
                newName: "EventModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_EventId",
                table: "Bookings",
                newName: "IX_Bookings_EventModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Events_EventModelId",
                table: "Bookings",
                column: "EventModelId",
                principalTable: "Events",
                principalColumn: "EventModelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Events_EventModelId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "EventModelId",
                table: "Events",
                newName: "EventId");

            migrationBuilder.RenameColumn(
                name: "EventModelId",
                table: "Bookings",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_EventModelId",
                table: "Bookings",
                newName: "IX_Bookings_EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Events_EventId",
                table: "Bookings",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
