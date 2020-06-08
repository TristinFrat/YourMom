using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.Reflection;
using System.Media;

namespace YourMom.Items
{
	public class CumBalloon : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cum-filled Balloon"); 
			Tooltip.SetDefault("Squishy");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.CloudinaBalloon);
			item.width = 20;
			item.height = 26;
			item.value = 10;
			item.rare = 2;
			item.accessory = true;

		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			item.CloneDefaults(ItemID.CloudinaBalloon);
		}

		public override void UpdateInventory(Player player)
        {
			item.CloneDefaults(ItemID.CloudinaBalloon);
		}



		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CumJar", 1);
			recipe.AddIngredient(ItemID.ShinyRedBalloon, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}