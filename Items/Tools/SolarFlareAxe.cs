using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Tools
{
	public class SolarFlareAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Flare Axe");
			Tooltip.SetDefault("Unobtainable.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.SolarFlareAxe);
			item.width = 56;
			item.height = 56;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.FragmentSolar, 7);
            recipe.AddIngredient(ItemID.LunarBar, 6);
			recipe.AddTile(412);
            recipe.SetResult(null, "SolarFlareAxe", 1);
            recipe.AddRecipe();
		}
	}
}
