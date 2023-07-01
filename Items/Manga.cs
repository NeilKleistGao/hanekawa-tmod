using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Hanekawa.Items {
	public class Manga : ModItem {
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("这种无视物理法则的动作，现在的你应该做得到吧。");
		}

		public override void SetDefaults() {
			Item.damage = 0;
			Item.DamageType = DamageClass.Summon;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.RaiseLamp;
			Item.knockBack = 0;
			Item.rare = 2;
			Item.UseSound = SoundID.ResearchComplete;
      Item.maxStack = 1;
      Item.mana = 2;
			Item.autoReuse = true;
      Item.SetNameOverride("校园异能漫画");
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Book, 1);
      recipe.AddIngredient(ItemID.BlackDye, 1);
      recipe.AddIngredient(ItemID.YellowDye, 1);
      recipe.AddIngredient(ItemID.CyanDye, 1);
      recipe.AddIngredient(ItemID.PinkDye, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

    public override bool? UseItem(Player player) {
      player.AddBuff(BuffID.Wrath, 7200);
      player.AddBuff(BuffID.Rage, 7200);
      player.AddBuff(BuffID.Swiftness, 7200);
      player.AddBuff(BuffID.Featherfall, 7200);
      return true;
    }
	}
}
