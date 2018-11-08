using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Tools
{
	public class SolarFlareHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Flare Hammer");
			Tooltip.SetDefault("Unobtainable.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.SolarFlareHammer);
			item.width = 46;
			item.height = 44;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.FragmentSolar, 7);
            recipe.AddIngredient(ItemID.LunarBar, 6);
			recipe.AddTile(412);
            recipe.SetResult(null, "SolarFlareHammer", 1);
            recipe.AddRecipe();
		}
	}
}
