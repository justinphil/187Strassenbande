using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Strassenbande.Items
{
    class StrassenbandeLogo : ModItem
    {
        
        // string realPlayerName;

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

            

            player.lifeRegen += 187;
            
            player.moveSpeed += 18.7f;
            player.rangedDamage += 18.7f;
            player.manaCost -= 18.7f;
            player.statLifeMax2 += 187;
            player.statManaMax2 += 187;
            player.noFallDmg = true;
            player.maxFallSpeed += 187;
            player.statDefense += 187;
            // player.name = rndName() + "(" + realPlayerName + ")";
        }


        //private string rndName() {
            
        //    Random rnd = new Random();            
        //    string[] customNames = {"Gzuz", "Bonez MC", "Sa4", "LX", "Maxwell" };
        //    int index = rnd.Next(customNames.Length);

        //    return customNames[index];
        //}
    }
}
