using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PreHardmodeBossBuffs
{
    class BossBuffs : GlobalNPC
    {
        static bool slimeKing, downedBoss1, downedBoss2, downedBoss3;

        static short[] bossTypes = { NPCID.KingSlime, NPCID.EyeofCthulhu, NPCID.EaterofWorldsBody, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsTail, NPCID.BrainofCthulhu, NPCID.QueenBee, NPCID.SkeletronHead, NPCID.WallofFlesh, NPCID.TheDestroyer, NPCID.Retinazer, NPCID.Spazmatism, NPCID.SkeletronPrime, NPCID.Plantera, NPCID.Golem, NPCID.GolemHead, NPCID.DukeFishron, NPCID.CultistBoss, NPCID.MoonLordCore };
        static bool[] bossDefeated = { NPC.downedSlimeKing, NPC.downedBoss1, NPC.downedBoss2, NPC.downedBoss2, NPC.downedBoss2, NPC.downedBoss2, NPC.downedQueenBee, NPC.downedBoss3, Main.hardMode, NPC.downedMechBoss1, NPC.downedMechBoss2, NPC.downedMechBoss2, NPC.downedMechBoss3, NPC.downedPlantBoss, NPC.downedGolemBoss, NPC.downedGolemBoss, NPC.downedFishron, NPC.downedAncientCultist, NPC.downedMoonlord };

        public override void NPCLoot(NPC npc)
        {
            if (!Main.expertMode) {
                for (int i = 0; i < bossTypes.Length; i++)
                {
                    if (npc.type == bossTypes[i])
                    { // Is the NPC one of the allowed boss types?
                        if (npc.boss)
                        { // Is the NPC a boss?
                            if (bossDefeated[i])
                            {
                                Main.expertMode = true;
                                npc.DropBossBags();
                                Main.expertMode = false;
                            }
                            bossDefeated[i] = true;
                        }
                    }
                }
            }
        }

        public override void SetDefaults(NPC npc)
        {
            if (!Main.expertMode)
            {
                for (int i = 0; i < bossTypes.Length; i++)
                {
                    if (npc.type == bossTypes[i])
                    { // Is the NPC one of the allowed boss types?
                        if (npc.boss)
                        { // Is the NPC a boss?
                            if (bossDefeated[i])
                            {
                                Main.expertMode = true;
                                npc.SetDefaults(npc.type);
                                Main.expertMode = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
