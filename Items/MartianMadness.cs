using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items
{
	public class MartianMadness : ModItem
    {
			public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Martian Madness");
		}
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = 100;
            item.rare = 1;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }
        public override bool UseItem(Player player)
        {
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.MartianProbe);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ProximityMineLauncher, 1);
            recipe.AddIngredient(771, 20);
            recipe.AddIngredient(ItemID.Nanites, 20);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}