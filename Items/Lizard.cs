using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.Reflection;
using System.Media;

namespace YourMom.Items
{
	public class Lizard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Motivational Lizard");
			Tooltip.SetDefault("You’re a winner kiddo");
		}

		public override void SetDefaults()
		{

			item.width = 20;
			item.height = 26;
			item.value = 10;
			item.rare = 2;
			item.accessory = true;
			item.defense = 6;


		}


		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeCrit += 9;
			player.rangedCrit += 9;
			player.magicCrit += 9;
			//player.summonCrit += 9;
		}
	}
}