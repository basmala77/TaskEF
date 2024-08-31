using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class discription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "authors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                computedColumnSql: "[Lname] + ', ' + [FName]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "authors");
        }
    }
}
