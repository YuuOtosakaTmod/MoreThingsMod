using Terraria;
using Terraria.ModLoader;

namespace MoreThingsMod.NPCs
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
		{
			if (Main.hardMode && Main.rand.Next(5) == 0 && Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCorrupt)
            {
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SoulofDeath"), Main.rand.Next(1,2)); //Item spawn
			}
			else
			if (Main.hardMode && Main.rand.Next(5) == 0 && Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCrimson)
            {
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SoulofDeath"), Main.rand.Next(1,2)); //Item spawn
			}
		}
	}
}

