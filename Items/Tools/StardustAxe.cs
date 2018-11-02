using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Tools
{
	public class StardustAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stardust Axe");
			Tooltip.SetDefault("Unobtainable.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.StardustAxe);
			item.width = 54;
			item.height = 56;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(3459, 7);
            recipe.AddIngredient(3467, 6);
			recipe.AddTile(412);
            recipe.SetResult(null, "StardustAxe", 1);
            recipe.AddRecipe();
		}
	}
}
