using Microsoft.EntityFrameworkCore.Migrations;

namespace Drinks_app.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_CocktailRecipes_CocktailRecipeId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_CocktailRecipeId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "CocktailRecipeId",
                table: "Ingredients");

            migrationBuilder.CreateTable(
                name: "CocktailRecipeIngredient",
                columns: table => new
                {
                    CocktailRecipesId = table.Column<long>(type: "bigint", nullable: false),
                    IngredientsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CocktailRecipeIngredient", x => new { x.CocktailRecipesId, x.IngredientsId });
                    table.ForeignKey(
                        name: "FK_CocktailRecipeIngredient_CocktailRecipes_CocktailRecipesId",
                        column: x => x.CocktailRecipesId,
                        principalTable: "CocktailRecipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CocktailRecipeIngredient_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CocktailRecipeIngredient_IngredientsId",
                table: "CocktailRecipeIngredient",
                column: "IngredientsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CocktailRecipeIngredient");

            migrationBuilder.AddColumn<long>(
                name: "CocktailRecipeId",
                table: "Ingredients",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_CocktailRecipeId",
                table: "Ingredients",
                column: "CocktailRecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_CocktailRecipes_CocktailRecipeId",
                table: "Ingredients",
                column: "CocktailRecipeId",
                principalTable: "CocktailRecipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
