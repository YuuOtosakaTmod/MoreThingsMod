using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MoreThingsMod.Items.Weapons
{
		public class SoulScythe: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul Scythe");
			Tooltip.SetDefault("Removed item.");
		}
        public override void SetDefaults()
        {
            item.damage = 155;
            item.melee = true;
            item.width = 92;
            item.height = 78; 
            item.useTime = 36;
            item.useAnimation = 36;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = 10000;
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("SoulStar");
            item.shootSpeed = 16f;
        }
		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.SoulofNight, 30);
            recipe.AddIngredient(ItemID.SoulofLight, 30);
            recipe.AddIngredient(null, "SoulofDeath", 15);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(null, "SoulScythe", 1);
            recipe.AddRecipe();
		}
		        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4 + Main.rand.Next(2);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)Math.Sqrt((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
        }  
    }
}