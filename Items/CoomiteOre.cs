using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace YourMom.Items
{
	public class CoomiteOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Coomite Ore");
			Tooltip.SetDefault("Oh no I just coomed all over the place");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
		}

		/*public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<ExampleItem>());
			recipe.SetResult(this);
			recipe.AddRecipe();*/

		public override bool CanBurnInLava()
		{
			return true;
		}
	}
}