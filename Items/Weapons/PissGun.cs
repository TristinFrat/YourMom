using Terraria.ID;
using Terraria.ModLoader;

namespace YourMom.Items.Weapons
{
	public class PissGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Piss Gun");
			Tooltip.SetDefault("Filled with cat piss!");
		}

		public override void SetDefaults()
		{
			item.damage = 0;
			item.ranged = true;
			item.width = 42;
			item.height = 26;
			item.useTime = 12;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 0;
			item.rare = ItemRarityID.Green;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("Piss");
			item.shootSpeed = 8f;
			item.useAmmo = 0;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SlimeGun);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}