using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items
{
	public class SuspiciousAntenna : ModItem
    {
			public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Suspicious Antenna");
		}
        public override void SetDefaults()
        {
            item.width = 8;
            item.height = 33;
            item.maxStack = 99;
            item.value = 100;
            item.rare = 1;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }
        public override bool UseItem(Player player)
        {
            NPC.NewNPC((int)player.position.X, (int)player.position.Y - 50, NPCID.MartianProbe);
			return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cog, 10);
            recipe.AddIngredient(ItemID.TitaniumBar, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cog, 10);
            recipe.AddIngredient(ItemID.AdamantiteBar, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
