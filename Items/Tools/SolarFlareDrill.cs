using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Tools
{
	public class SolarFlareDrill : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Flare Drill");
			Tooltip.SetDefault("Unobtainable.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.SolarFlareDrill);
			item.width = 54;
			item.height = 26;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.FragmentSolar, 12);
            recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(412);
            recipe.SetResult(null, "SolarFlareDrill", 1);
            recipe.AddRecipe();
		}
	}
}
