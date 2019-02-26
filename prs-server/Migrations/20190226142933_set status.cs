using Microsoft.EntityFrameworkCore.Migrations;

namespace prs.Migrations
{
    public partial class setstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReviewDate",
                table: "Requests",
                newName: "SubmittedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubmittedDate",
                table: "Requests",
                newName: "ReviewDate");
        }
    }
}
