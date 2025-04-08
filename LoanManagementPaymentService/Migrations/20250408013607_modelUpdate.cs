using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanManagementPaymentService.Migrations
{
    /// <inheritdoc />
    public partial class modelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NextInstallmentPayment",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RemainingPayment",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NextInstallmentPayment",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "RemainingPayment",
                table: "Payments");
        }
    }
}
