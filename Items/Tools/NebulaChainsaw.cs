using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Tools
{
    public class NebulaChainsaw: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nebula Chainsaw");
			Tooltip.SetDefault("Unobtainable.");
		}
		
        public override void SetDefaults()
        {
			item.CloneDefaults(ItemID.NebulaChainsaw);
            item.melee = true;
            item.width = 56;
            item.height = 18; 
            item.shoot = ProjectileID.NebulaChainsaw;
        }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.FragmentNebula, 10);
            recipe.AddIngredient(ItemID.LunarBar, 4);
			recipe.AddTile(412);
            recipe.SetResult(null, "NebulaChainsaw", 1);
            recipe.AddRecipe();
		}
    }
}