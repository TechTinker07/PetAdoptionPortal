using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetAdoptionPortal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedPets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pets");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Pets",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Gender", "ImageUrl", "Name", "Personality", "Species", "Status" },
                values: new object[,]
                {
                    { 1, 2, "Female", "/images/chuchu.jpg", "Chuchu", "Loves cuddles and belly rubs.", "Dog", "Available" },
                    { 2, 1, "Male", "/images/milo.jpg", "Milo", "Always curious about everything.", "Cat", "Available" },
                    { 3, 3, "Female", "/images/bella.jpg", "Bella", "Playful and full of energy.", "Dog", "Available" },
                    { 4, 2, "Female", "/images/luna.jpg", "Luna", "Loyal and protective of loved ones.", "Cat", "Available" },
                    { 5, 4, "Female", "/images/chuchu.jpg", "Max", "Enjoys napping under the sun", "Dog", "Available" },
                    { 6, 1, "Male", "/images/milo.jpg", "Oliver", "Shy at first but very sweet.", "Cat", "Available" },
                    { 7, 3, "Female", "/images/bella.jpg", "Daisy", "Loves exploring new places", "Dog", "Available" },
                    { 8, 2, "Male", "/images/luna.jpg", "Simba", "Smart and easy to train.", "Cat", "Available" },
                    { 9, 5, "Female", "/images/chuchu.jpg", "Coco", "Gentle and calm around kids.", "Dog", "Available" },
                    { 10, 1, "Male", "/images/milo.jpg", "Leo", "Can’t resist a tasty treat.", "Cat", "Available" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Pets",
                type: "int",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Pets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
