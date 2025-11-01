using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionPortal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePetImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/max.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/images/oliver.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/daisy.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/simba.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/images/coco.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/leo.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/chuchu.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/images/milo.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/bella.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/luna.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/images/chuchu.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/milo.jpg");
        }
    }
}
