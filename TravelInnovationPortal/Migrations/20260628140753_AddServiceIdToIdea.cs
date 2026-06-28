using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelInnovationPortal.Migrations
{
    /// <inheritdoc />
    public partial class AddServiceIdToIdea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Ideas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Ideas");
        }
    }
}
