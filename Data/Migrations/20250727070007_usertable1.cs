using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_Management_System.Data.Migrations
{
    /// <inheritdoc />
    public partial class usertable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IDNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDNumber",
                table: "AspNetUsers");
        }
    }
}
