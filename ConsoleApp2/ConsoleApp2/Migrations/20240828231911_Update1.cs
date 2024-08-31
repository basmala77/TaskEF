using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "authors",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                computedColumnSql: "[Lname] + ', ' + [FName]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "authors");
        }
    }
}
