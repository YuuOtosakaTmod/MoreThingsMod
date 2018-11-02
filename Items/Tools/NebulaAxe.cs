using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Tools
{
	public class NebulaAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nebula Axe");
			Tooltip.SetDefault("Unobtainable.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.NebulaAxe);
			item.width = 54;
			item.height = 56;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(3457, 7);
            recipe.AddIngredient(3467, 6);
			recipe.AddTile(412);
            recipe.SetResult(null, "NebulaAxe", 1);
            recipe.AddRecipe();
		}
	}
}
