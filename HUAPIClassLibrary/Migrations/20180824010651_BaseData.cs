using Microsoft.EntityFrameworkCore.Migrations;

namespace HUAPIClassLibrary.Migrations
{
    public partial class BaseData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("HUAPISettings", "Name", "IsLive");
            migrationBuilder.InsertData("HUAPISettings", new string[] { "Name", "Value" }, new string[] { "IsLive", "true" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
