using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Weapons
{
    public class Scythe: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scythe");
			Tooltip.SetDefault("Removed Item.");
		}
        public override void SetDefaults()
        {
            item.damage = 39;
            item.melee = true;
            item.width = 64;
            item.height = 56; 
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 200000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Slow, 120); 
            target.AddBuff(BuffID.Poisoned, 120); 
        }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ItemID.SoulofNight, 20);
            recipe.AddIngredient(ItemID.SoulofLight, 20);
            recipe.AddIngredient(null, "SoulofDeath", 15);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(null, "Scythe", 1);
            recipe.AddRecipe();
		}
    }
}