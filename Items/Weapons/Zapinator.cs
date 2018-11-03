using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MoreThingsMod.Items.Weapons
{
		public class Zapinator: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zapinator");
			Tooltip.SetDefault("Removed item.");
		}
        public override void SetDefaults()
        {
            item.damage = 75;
            item.magic = true;
            item.width = 48;
            item.height = 28;
			item.mana = 12;  
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 100000;
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = ProjectileID.GreenLaser;
            item.shootSpeed = 16f;
        }
				public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.SoulofNight, 20);
            recipe.AddIngredient(ItemID.SoulofLight, 20);
            recipe.AddIngredient(null, "SoulofDeath", 15);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(null, "Zapinator", 1);
            recipe.AddRecipe();
		}
    }
}