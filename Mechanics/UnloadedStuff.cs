using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MoreThingsMod.Mechanics
{
		public class UnloadedStuff: ModItem
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.StarinaBottle, 1);
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddIngredient(ItemID.CursedFlame, 20);
			recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(ItemID.GoldenShower, 1);
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddIngredient(ItemID.Ichor, 20);
			recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(ItemID.CursedFlames, 1);
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShadowOrb, 1);
            recipe.SetResult(ItemID.CrimsonHeart, 1);
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimsonHeart, 1);
            recipe.SetResult(ItemID.ShadowOrb, 1);
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MudBlock, 1);
            recipe.SetResult(ItemID.DirtBlock, 1);
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
            recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.Rope, 3);
			recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.SetResult(ItemID.Aglet, 1);
			recipe.AddTile(TileID.Anvils);
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddIngredient(ItemID.Feather, 10);
            recipe.SetResult(ItemID.LuckyHorseshoe, 1);
			recipe.AddTile(TileID.Anvils);
            recipe.AddRecipe();
		}
	}
}