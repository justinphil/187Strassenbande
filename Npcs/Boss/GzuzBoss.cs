using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace Strassenbande.Npcs.Boss
{
    class GzuzBoss : ModNPC
    {
        int ai;
        bool fastSpeed = false;

        int attackTimer = 0;

        

        public override void SetDefaults()
        {
            npc.width = 187;
            npc.height = 327;

            npc.damage = 187;
            npc.knockBackResist = 1f;
            npc.defense = 187;
            npc.lifeMax = 1870000;
            npc.lifeRegen = 187;

            npc.value = Item.buyPrice(platinum: 187);

            npc.noTileCollide = true;
            npc.noGravity = true;
            npc.lavaImmune = true;



            npc.aiStyle = -1;
            npc.boss = true;
            npc.npcSlots = 10f;
            animationType = NPCID.Derpling;
            music = mod.GetSoundSlot(SoundType.Music, "Sound/Music/GzuzBossMusic");
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * bossLifeScale);
            npc.damage = (int)(npc.damage * 1.5f);
        }

        public override void AI()
        {
            npc.TargetClosest(true);
            Player player = Main.player[npc.target];
            Vector2 target = npc.HasNPCTarget ? player.Center : Main.npc[npc.target].Center;

            npc.rotation = 0f;
            npc.netAlways = true;
            npc.TargetClosest(true);

            if (npc.life >= npc.lifeMax)
                npc.life = npc.lifeMax;

            if (npc.target < 0 || npc.target == 255 || player.dead || !player.active) {
                npc.TargetClosest(false);
                npc.direction = 1;
                npc.velocity.Y = npc.velocity.Y - 0.1f;

                if (npc.timeLeft > 20) {

                    npc.timeLeft = 20;
                    return;
                }
            }

            

            ai++;

            npc.ai[0] = (float)ai * 1f;

            
        }       

    }
}
