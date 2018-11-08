using Terraria.ID;
using Terraria.ModLoader;

namespace MoreThingsMod.Items.Weapons
{
    public class InfinityConfettiGun: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infinity Confetti Gun");
			Tooltip.SetDefault("Have fun!");
		}
		
        public override void SetDefaults()
        {
			item.CloneDefaults(ItemID.ConfettiGun);
            item.width = 24;
            item.height = 22; 
            item.value = 500000;
			item.maxStack = 1;
			item.consumable = false;
            item.shoot = ProjectileID.ConfettiGun;
            item.rare = 2;
        }
    }
}