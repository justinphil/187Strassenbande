using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Strassenbande.Items
{
    class Ayran : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ayran");
            Tooltip.SetDefault("Frisch gezapfte Ayran.");
        }

        public override void SetDefaults()
        {
            item.width = 84;
            item.height = 143;

            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 20;
            item.useTime = 20;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Red;
            item.value = Item.buyPrice(platinum: 1);
            item.buffType = mod.BuffType("AyranBuff");
            item.buffTime = 3600 * 6;
            
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WhitePaint, 20);
            recipe.AddIngredient(ItemID.PixieDust, 20);
            recipe.AddIngredient(ItemID.GoldDust, 20);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
