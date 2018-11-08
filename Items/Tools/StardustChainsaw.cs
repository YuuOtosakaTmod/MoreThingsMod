using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Tools
{
		public class StardustChainsaw: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stardust Chainsaw");
			Tooltip.SetDefault("Unobtainable.");
		}	
		
        public override void SetDefaults()
        {
			item.CloneDefaults(ItemID.StardustChainsaw);
            item.melee = true;
            item.width = 60;
            item.height = 24; 
            item.shoot = ProjectileID.StardustChainsaw;
        }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.FragmentStardust, 10);
            recipe.AddIngredient(ItemID.LunarBar, 4);
			recipe.AddTile(412);
            recipe.SetResult(null, "StardustChainsaw", 1);
            recipe.AddRecipe();
		}
    }
}