using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Strassenbande.Items
{
	public class CL500 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("CL 500"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("WOW GZUZ TOPSCOUT HABIBI!!!");
            
		}

		public override void SetDefaults() 
		{
            item.height = 30;
            item.width = 100;

            
            item.value = Item.sellPrice(platinum: 187);
            item.rare = ItemRarityID.Red;
            item.damage = 18700;
            item.knockBack = 187;
            item.shoot = mod.ProjectileType("Gzuz");
            item.shootSpeed = 16f;
            item.useAmmo = mod.ProjectileType("Gzuz");

            item.useTime = 6;
            item.useAnimation = 6;
            item.useStyle = 5;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Custom/Gzuz187"); // [insert] Gzuz 187 Sound

            item.autoReuse = true;
            item.ranged = true;
            item.noMelee = true;

        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 187);
            recipe.AddIngredient(ItemID.DirtBlock, 999);
            recipe.AddIngredient(ItemID.StoneBlock, 999);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        // 69% of not consuming ammo
        public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .69f;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Main.PlaySound(SoundLoader.customSoundType, mod.GetSoundSlot(SoundType.Custom, "Sound/Custom/Gzuz187"));
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;

            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 55f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }

            return true;
        }


    }
}
 