using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreatedForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Accounts",
                newName: "AccountId");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "ProccesHistrys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProccesHistrys_AccountId",
                table: "ProccesHistrys",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProccesHistrys_Accounts_AccountId",
                table: "ProccesHistrys",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProccesHistrys_Accounts_AccountId",
                table: "ProccesHistrys");

            migrationBuilder.DropIndex(
                name: "IX_ProccesHistrys_AccountId",
                table: "ProccesHistrys");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "ProccesHistrys");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Accounts",
                newName: "Id");
        }
    }
}
