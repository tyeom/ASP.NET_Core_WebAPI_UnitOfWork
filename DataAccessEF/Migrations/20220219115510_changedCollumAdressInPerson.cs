using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessEF.Migrations
{
    public partial class changedCollumAdressInPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Address_AdressAddressId",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "AdressAddressId",
                table: "Person",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_AdressAddressId",
                table: "Person",
                newName: "IX_Person_AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Address_AddressId",
                table: "Person",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Address_AddressId",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Person",
                newName: "AdressAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_AddressId",
                table: "Person",
                newName: "IX_Person_AdressAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Address_AdressAddressId",
                table: "Person",
                column: "AdressAddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
