using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace YourMom.Items
{
	public class CumJar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cum in a Jar"); 
			Tooltip.SetDefault("Wait, whats in there?");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.CloudinaBottle);
			item.width = 20;
			item.height = 26;
			item.value = 10;
			item.rare = 2;
			item.accessory = true;

		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
		player.doubleJumpCloud = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CloudinaBottle, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}