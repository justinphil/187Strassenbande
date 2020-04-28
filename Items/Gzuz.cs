using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Strassenbande.Items
{
    class Gzuz : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gzuz");
        }

        public override void SetDefaults()
        {
            item.width = 37;
            item.height = 25;

            item.damage = 187;
            item.maxStack = 9999; //how much fit in one inventory slot
            item.consumable = true; //makes it so the bullet is used on shooting. Delete this if you want an endless ammo pouch
            item.knockBack = 1.87f; //how much additional knockback your bullet does.
            item.value = Item.sellPrice(copper: 187); //if value is just a number, it's the sell price in copper coins. This is worth 10 copper. Every 100 means it sells for a silver, every 10000 means gold, and every 1000000 means platinum
            item.rare = 0;
            item.shoot = mod.ProjectileType("Gzuz"); //IMPORTANT! Make sure you have a projectile for your ammo and this shoots it
            item.shootSpeed = 18.7f; //how much additional velocity it applies to the projectile
            item.ammo = mod.ProjectileType("Gzuz"); //IMPORTANT! This makes the item ammo of the according type. Common ammo types include AmmoID.Arrow, AmmoID.Bullet, and AmmoID.Rocket
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
