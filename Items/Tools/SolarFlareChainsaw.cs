using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MoreThingsMod.Items.Tools
{
		public class SolarFlareChainsaw: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Flare Chainsaw");
			Tooltip.SetDefault("Unobtainable.");
		}
		
        public override void SetDefaults()
        {
			item.CloneDefaults(ItemID.SolarFlareChainsaw);
            item.melee = true;
            item.width = 64;
            item.height = 28; 
            item.shoot = ProjectileID.SolarFlareChainsaw;
        }		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(3458, 10);
            recipe.AddIngredient(3467, 4);
			recipe.AddTile(412);
            recipe.SetResult(null, "SolarFlareChainsaw", 1);
            recipe.AddRecipe();
		}

    }
}