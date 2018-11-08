using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Projectiles
{
	public class SoulStar : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul Star");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.Starfury);
			aiType = ProjectileID.Starfury;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.Starfury;
			return true;
		}
	}
}