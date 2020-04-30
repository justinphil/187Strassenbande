using Terraria;
using Terraria.ModLoader;


namespace Strassenbande.Buffs
{
    public class CL500Buff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("CL500");
            Description.SetDefault("Ich zähle unsern Umsatz, in mei'm CL 500");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("CL500"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}