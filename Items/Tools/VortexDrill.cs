using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Tools
{
	public class VortexDrill : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vortex Drill");
			Tooltip.SetDefault("Unobtainable.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.VortexDrill);
			item.width = 54;
			item.height = 26;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(3456, 12);
            recipe.AddIngredient(3467, 10);
			recipe.AddTile(412);
            recipe.SetResult(null, "VortexDrill", 1);
            recipe.AddRecipe();
		}
	}
}
