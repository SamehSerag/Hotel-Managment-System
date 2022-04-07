using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace D15_EF_D02_Task.Migrations
{
    public partial class AddLogInKitchen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "LogInKitchen",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogInKitchen", x => x.UserName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogInKitchen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogInFrontEnd",
                table: "LogInFrontEnd");

            migrationBuilder.RenameTable(
                name: "LogInFrontEnd",
                newName: "LogIn");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogIn",
                table: "LogIn",
                column: "UserName");
        }
    }
}
