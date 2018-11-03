using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MoreThingsMod.Items.Weapons
{
		public class PartySword: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Party Sword");
		}
        public override void SetDefaults()
        {
            item.damage = 80;
            item.melee = true;
            item.width = 48;
            item.height = 48; 
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = 1000000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.shoot = 178;
            item.shootSpeed = 25f;
        }
			public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.CrystalBullet, damage, knockBack, player.whoAmI);
			return true;
		}
	}
}