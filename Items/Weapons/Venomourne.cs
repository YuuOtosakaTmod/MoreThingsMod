using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Weapons
{
    public class Venomourne: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Venomourne");
		}

        public override void SetDefaults()
        {
            item.damage = 200;
            item.melee = true;
            item.width = 56;
            item.height = 56; 
            item.useTime = 27;
            item.useAnimation = 27;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = 200000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Venom, 240);
            target.AddBuff(BuffID.Slow, 240);
        }

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Icemourne", 1);
            recipe.AddIngredient(null, "Firemourne", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(null, "Venomourne", 1);
            recipe.AddRecipe();
		}
    }
}