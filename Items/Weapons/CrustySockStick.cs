using Terraria.ID;
using Terraria.ModLoader;

namespace YourMom.Items.Weapons
{
	public class CrustySockStick : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Crusty Sock on a Stick");
			Tooltip.SetDefault("Smells like Coom");
		}

		public override void SetDefaults() 
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 48;
			item.useTime = 33;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}