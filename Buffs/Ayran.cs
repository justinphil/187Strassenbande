using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Strassenbande.Buffs
{
    class Ayran : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Frischer Ayran");
            Description.SetDefault("Frische Ayran ohne reden und so!");
        }

        public override void ModifyBuffTip(ref string tip, ref int rare)
        {
            base.ModifyBuffTip(ref tip, ref rare);
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 187;
            player.moveSpeed += 20;
            player.maxRunSpeed += 200;
            player.accRunSpeed += 20;
            player.wingTime += 999;
            

            player.statLifeMax2 += 180;
        }



    }
}
