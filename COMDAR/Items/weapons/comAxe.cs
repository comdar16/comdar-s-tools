using Terraria.ID;
using Terraria.ModLoader;

namespace COMDAR.Items.weapons
{
	public class comAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shiny Axe!");
		}

		public override void SetDefaults()
		{
			item.damage = 2;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 15;
			item.axe = 55;
			item.hammer = 0;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Topaz, 10);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}