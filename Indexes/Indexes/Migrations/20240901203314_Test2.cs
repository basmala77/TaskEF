using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Indexes.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Blogs_URL",
                table: "Blogs");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_URL",
                table: "Blogs",
                column: "URL",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Blogs_URL",
                table: "Blogs");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_URL",
                table: "Blogs",
                column: "URL");
        }
    }
}
