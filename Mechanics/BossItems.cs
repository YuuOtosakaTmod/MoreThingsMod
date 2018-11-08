using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Mechanics
{
    public class BossItems : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Abeemination)
			{
				item.value = 100000;
			}
			if (item.type == ItemID.PirateMap)
			{
				item.value = 100000;
			}
			if (item.type == ItemID.GoblinBattleStandard)
			{
				item.value = 100000;
			}
			if (item.type == ItemID.CelestialSigil)
			{
				item.value = 230000;
			}
			if (item.type == ItemID.BloodySpine)
			{
				item.value = 120000;
			}
			if (item.type == ItemID.WormFood)
			{
				item.value = 120000;
			}
			if (item.type == ItemID.MechanicalWorm)
			{
				item.value = 200000;
			}
			if (item.type == ItemID.MechanicalSkull)
			{
				item.value = 200000;
			}
			if (item.type == ItemID.MechanicalEye)
			{
				item.value = 200000;
			}
			if (item.type == ItemID.PumpkinMoonMedallion)
			{
				item.value = 110000;
			}
			if (item.type == ItemID.NaughtyPresent)
			{
				item.value = 110000;
			}
			if (item.type == ItemID.ClothierVoodooDoll)
			{
				item.value = 110000;
			}
			if (item.type == ItemID.GuideVoodooDoll)
			{
				item.value = 130000;
			}
			if (item.type == ItemID.LihzahrdPowerCell)
			{
				item.value = 130000;
			}
			if (item.type == ItemID.SlimeCrown)
			{
				item.value = 100000;
			}
			if (item.type == ItemID.SnowGlobe)
			{
				item.value = 100000;
			}
			if (item.type == ItemID.TruffleWorm)
			{
				item.value = 200000;
			}
			if (item.type == ItemID.SuspiciousLookingEye)
			{
				item.value = 120000;
			}
			if (item.type == ItemID.SolarTablet)
			{
				item.value = 100000;
			}
		}
	}
}