using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Tools
{
	public class StardustHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stardust Hammer");
			Tooltip.SetDefault("Unobtainable.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.StardustHammer);
			item.width = 48;
			item.height = 44;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.FragmentStardust, 7);
            recipe.AddIngredient(ItemID.LunarBar, 6);
			recipe.AddTile(412);
            recipe.SetResult(null, "StardustHammer", 1);
            recipe.AddRecipe();
		}
	}
}
