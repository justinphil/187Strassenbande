using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace Strassenbande.Buffs
{
    class AyranBuff : ModBuff
    {

        List<string> customNames = new List<string> { "Maxwell", "LX", "Gzuz", "BonezMC", "Sa4" };

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Frischer Ayran");
            Description.SetDefault("Frische Ayran ohne reden und so!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (customNames.Contains(player.name))
            {
                player.lifeRegen += 30;
                player.statDefense += 50;
                player.statLifeMax2 += 180;
                player.statManaMax2 += 40;
                player.manaCost -= 20;
                player.wingTime += 200;
            }
            else {

                player.lifeRegen += 18;
                player.moveSpeed += 20;
                player.maxRunSpeed = 20;
                player.wingTime += 200;

                player.statDefense += 50;
                player.statLifeMax2 += 50;
                player.statManaMax2 += 40;
                player.manaCost -= 2;

            }
        }



    }
}
