using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace D15_EF_D02_Task.Migrations
{
    public partial class UpdateTotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotolBill",
                table: "Reservation",
                newName: "TotalBill");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalBill",
                table: "Reservation",
                newName: "TotolBill");
        }
    }
}
