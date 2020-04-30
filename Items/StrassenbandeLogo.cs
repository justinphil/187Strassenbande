using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Strassenbande.Items
{
    class StrassenbandeLogo : ModItem
    {

        List<string> customNames = new List<string>{ "Maxwell", "LX", "Gzuz", "BonezMC", "Sa4"};

        

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("187 Strassenbande Logo");
            Tooltip.SetDefault("187 Strassenbande alles andere Fotzen! \n Wallah gutes Item diese!");
            
        }

        public override void SetDefaults()
        {
            item.width = 107;
            item.height = 118;

            item.rare = ItemRarityID.Red;
            item.value = Item.sellPrice(platinum: 187);
            item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 187);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        
        

        public override void UpdateAccessory(Player player, bool hideVisual)
        {

            if (customNames.Contains(player.name)) { 
                player.rangedDamage += 18.7f;
                player.allDamage += 18.7f;
            }

            player.AddBuff(BuffID.WaterCandle, 999999999, false);

            player.hairColor = Colors.RarityBlue;
            player.jumpSpeedBoost += 1.87f;
            player.lifeRegen += 30;
            player.allDamage += 1.87f;
            player.moveSpeed += 18.7f;
            player.rangedDamage += 1.87f;
            player.manaCost -= 2f;
            player.statLifeMax2 += 187;
            player.statManaMax2 += 187;
            player.noFallDmg = true;
            player.maxFallSpeed += 187;
            
            player.statDefense += 20;
            
        }
    }
}
