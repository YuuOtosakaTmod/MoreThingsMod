using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MoreThingsMod.Items.Weapons
{
		public class Icemourne: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Icemourne");
			Tooltip.SetDefault("Removed item.");
		}
        public override void SetDefaults()
        {
            item.damage = 144;
            item.melee = true;
            item.width = 74;
            item.height = 74; 
            item.useTime = 31;
            item.useAnimation = 31;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = 70000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 300);
        }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.SoulofNight, 25);
            recipe.AddIngredient(ItemID.SoulofLight, 25);
            recipe.AddIngredient(null, "SoulofDeath", 15);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(null, "Icemourne", 1);
            recipe.AddRecipe();
		}
    }
}