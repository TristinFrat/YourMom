using System.Net.Mail;
using System.Reflection;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace YourMom.Items
{
	public class Coomite : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hardened Coom");
			Tooltip.SetDefault("Oh no I just coomed all over the place");
		}
		public override void SetDefaults()
        {
			item.maxStack = 99;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CoomiteOre", 3);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool CanBurnInLava()
		{
			return true;
		}
	}
}