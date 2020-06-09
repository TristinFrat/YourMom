using System;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using YourMom.Items.Weapons;

namespace YourMom.NPC.Boss
{
    [AutoloadBossHead]
    public class CumLord : ModNPC
    {
        public const string CumLordHead = "YourMom/NPC/Boss/CumLord_Head_Boss";

        public override bool Autoload(ref string name)
        {
            // Adds boss head textures for the Abomination boss
            for (int k = 1; k <= 4; k++)
            {
                mod.AddBossHeadTexture(CumLordHead);
            }
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cum Lord");
        }
        public override void SetDefaults()
        {
            npc.aiStyle = 1; //Slime AI, i would like to know king slimes AI but this works just the same.
            npc.lifeMax = 8000;
            npc.damage = 15;
            npc.defense = 200;
            npc.knockBackResist = 0;
            npc.width = 162;
            npc.height = 118;
            animationType = NPCID.KingSlime; //Animation type.
            Main.npcFrameCount[npc.type] = 6; //The king slime has a frame count of 6.
            aiType = NPCID.KingSlime; //AI type
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.netAlways = true;
        }

        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.GreaterHealingPotion;
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PissGun"));
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax += (int)(npc.lifeMax * 0.579f * bossLifeScale);
            npc.damage += (int)(npc.damage * 0.6f);
        }
        public override void AI()
        {
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;

        }
    }
}