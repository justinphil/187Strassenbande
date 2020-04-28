using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Strassenbande.Items
{
    class koeftespiess : ModItem
    {

        // string realPlayerName;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Köftespiess");
            Tooltip.SetDefault("Köftespiess \n Wallah gutes Item diese!");

        }

        public override void SetDefaults()
        {
            item.width = 60;
            item.height = 130;

            item.rare = ItemRarityID.Red;
            item.value = Item.sellPrice(gold: 69);
            item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddIngredient(mod.GetItem("Ayran"), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }




        public override void UpdateAccessory(Player player, bool hideVisual)
        {

            player.lifeRegen += 187;

            player.moveSpeed += 18.7f;
            player.rangedDamage += 18.7f;
            player.manaCost -= 18.7f;
            player.statLifeMax2 += 187;
            player.statManaMax2 += 187;
            player.noFallDmg = true;
            player.maxFallSpeed += 187;
            player.statDefense += 187;
            
        }

    }
}
