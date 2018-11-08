using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Mechanics
{
    public class Shop: GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
	case NPCID.Dryad:
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.IvyWhip);
                        nextSlot++;
                    }
		if (Main.player[Main.myPlayer].ZoneJungle)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Abeemination);
                        nextSlot++;
                    }
	break;

	case NPCID.Cyborg:
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("NanoGun"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("Explosivo"));
                        nextSlot++;
                    }
	break;
	

	case NPCID.Merchant:
                    {
						shop.item[nextSlot].SetDefaults(ItemID.Blindfold);
						nextSlot++;
		if (Main.player[Main.myPlayer].ZoneRain)
                    {
						shop.item[nextSlot].SetDefaults(890);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(891);
						nextSlot++;
                    }
		if (Main.player[Main.myPlayer].ZoneBeach)
                    {
						shop.item[nextSlot].SetDefaults(889);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(893);
						nextSlot++;
                    }
		if (Main.player[Main.myPlayer].ZoneSnow)
                    {
						shop.item[nextSlot].SetDefaults(885);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(887);
						nextSlot++;
                    }
		if (Main.player[Main.myPlayer].ZoneJungle)
                    {
						shop.item[nextSlot].SetDefaults(892);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(886);
						nextSlot++;
                    }
                    }
	break;


	case NPCID.Pirate:
		if (Main.player[Main.myPlayer].ZoneBeach)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PirateMap);   
                        nextSlot++;
                    }
	break;


	case NPCID.PartyGirl:
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("InfinityConfettiGun"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("PartySword"));
                        nextSlot++;
                    }
	break;


	case NPCID.GoblinTinkerer:
					{
						shop.item[nextSlot].SetDefaults(393);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(18);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(17);
						nextSlot++;
		if (Main.player[Main.myPlayer].ZoneRain)
                    {
						shop.item[nextSlot].SetDefaults(ItemID.GoblinBattleStandard);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(3119);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(3102);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(3099);
						nextSlot++;
                    }
		if (Main.player[Main.myPlayer].ZoneBeach)
                    {
						shop.item[nextSlot].SetDefaults(3120);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(3096);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(3037);
						nextSlot++;
                    }
		if (Main.player[Main.myPlayer].ZoneSnow)
                    {
					shop.item[nextSlot].SetDefaults(3084);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(3118);
						nextSlot++;
						shop.item[nextSlot].SetDefaults(3095);
						nextSlot++;
                    }
					}
	break;


	case NPCID.ArmsDealer:
		if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("Zapinator"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("Icemourne"));
                        nextSlot++;
                    }
	break;
            }
        }
    }
}

