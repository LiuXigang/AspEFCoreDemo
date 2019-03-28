using Microsoft.EntityFrameworkCore.Migrations;

namespace AspEFCore.Data.Migrations
{
    public partial class hasDataTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "Id", "Name", "Population" },
                values: new object[] { 1, "安徽", 80000000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
