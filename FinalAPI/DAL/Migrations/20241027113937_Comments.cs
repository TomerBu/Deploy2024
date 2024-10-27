using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Comments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e4df4354-7a33-4052-a36e-73eeee0db7d9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36edc75d-46d3-48db-a4bb-33746b452ea8", "AQAAAAIAAYagAAAAEHABuU4npcxS+6pY6/cc6kFGSp0cnxu17/bsXmLjY8VWB1sO5wFNRmMK1D6FbJyU8w==", "8e4f5a44-bbfc-4b62-b1ac-a3bae45937e3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fc4920df-235c-4cb1-88ce-d715c19f7e5d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02c0bfb4-92aa-48e1-8f8d-033dda8493a6", "AQAAAAIAAYagAAAAEFgwoitGr1A+kfQWiHS1v5n2FZlUy18/yakPxwleqI8HANdZ8APUdA5H+TfgpGow4A==", "2a97f33e-c7a2-45d5-91a3-c2c5f371aabe" });
        }
    }
}
