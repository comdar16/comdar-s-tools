using Terraria.ID;
using Terraria.ModLoader;

namespace COMDAR.Items.weapons
{
	public class comMagicSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This sword has magic power!");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.magic = true;
			item.mana = 38;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item100;
			item.autoReuse = true;
			item.shoot = 15;
			item.shootSpeed = 10f;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Topaz, 10);
			recipe.AddIngredient(ItemID.Ruby, 10);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}