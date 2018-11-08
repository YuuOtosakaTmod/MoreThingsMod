using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Tools
{
		public class VortexChainsaw: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vortex Chainsaw");
			Tooltip.SetDefault("Unobtainable.");
		}
		
        public override void SetDefaults()
        {
			item.CloneDefaults(ItemID.VortexChainsaw);
            item.melee = true;
            item.width = 56;
            item.height = 22; 
            item.shoot = ProjectileID.VortexChainsaw;
        }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.FragmentVortex, 10);
            recipe.AddIngredient(ItemID.LunarBar, 4);
			recipe.AddTile(412);
            recipe.SetResult(null, "VortexChainsaw", 1);
            recipe.AddRecipe();
		}
    }
}