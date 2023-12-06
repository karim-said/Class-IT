using Microsoft.EntityFrameworkCore.Migrations;

namespace webapi2.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Shapes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShapeCategoryId",
                table: "Shapes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ShapeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShapeCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shapes_ShapeCategoryId",
                table: "Shapes",
                column: "ShapeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shapes_ShapeCategory_ShapeCategoryId",
                table: "Shapes",
                column: "ShapeCategoryId",
                principalTable: "ShapeCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shapes_ShapeCategory_ShapeCategoryId",
                table: "Shapes");

            migrationBuilder.DropTable(
                name: "ShapeCategory");

            migrationBuilder.DropIndex(
                name: "IX_Shapes_ShapeCategoryId",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "ShapeCategoryId",
                table: "Shapes");
        }
    }
}
