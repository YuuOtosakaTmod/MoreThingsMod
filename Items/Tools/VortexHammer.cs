using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Tools
{
	public class VortexHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vortex Hammer");
			Tooltip.SetDefault("Unobtainable.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.VortexHammer);
			item.width = 44;
			item.height = 42;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(3456, 7);
            recipe.AddIngredient(3467, 6);
			recipe.AddTile(412);
            recipe.SetResult(null, "VortexHammer", 1);
            recipe.AddRecipe();
		}
	}
}
