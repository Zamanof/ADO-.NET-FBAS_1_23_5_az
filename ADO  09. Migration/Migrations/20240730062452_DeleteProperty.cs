using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADO__09._Migration.Migrations
{
    /// <inheritdoc />
    public partial class DeleteProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Students",
                type: "bit",
                nullable: true);
        }
    }
}
