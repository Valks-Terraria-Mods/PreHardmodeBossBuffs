using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PreHardmodeBossBuffs
{
    class BossBuffs : GlobalNPC
    {
        public override void NPCLoot(NPC npc){
            if (NPC.downedSlimeKing) {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }
            if (NPC.downedBoss1)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }
            if (NPC.downedBoss2)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }

            if (NPC.downedBoss3)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }

            if (NPC.downedQueenBee)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }

            if (Main.hardMode)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }

            if (NPC.downedMechBoss1) {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }

            if (NPC.downedMechBoss2)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }

            if (NPC.downedMechBoss3)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }

            if (NPC.downedPlantBoss)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }

            if (NPC.downedGolemBoss)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }

            if (NPC.downedFishron)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }

            if (NPC.downedAncientCultist)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }

            if (NPC.downedMoonlord)
            {
                Main.expertMode = true;
                npc.DropBossBags();
                Main.expertMode = false;
            }
        }

        public override void SetDefaults(NPC npc)
        {
            if (!Main.expertMode) {
                if (NPC.downedSlimeKing) {
                    Main.expertMode = true;
                    if (npc.type == NPCID.KingSlime) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedBoss1) {
                    Main.expertMode = true;
                    if (npc.type == NPCID.EyeofCthulhu) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedBoss2)
                {
                    Main.expertMode = true;
                    if (npc.type == NPCID.BrainofCthulhu || npc.type == NPCID.EaterofWorldsBody || npc.type == NPCID.EaterofWorldsHead || npc.type == NPCID.EaterofWorldsTail) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedBoss3)
                {
                    Main.expertMode = true;
                    if (npc.type == NPCID.SkeletronHand || npc.type == NPCID.SkeletronHead) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedQueenBee)
                {
                    Main.expertMode = true;
                    if (npc.type == NPCID.QueenBee) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (Main.hardMode)
                {
                    Main.expertMode = true;
                    if (npc.type == NPCID.WallofFlesh || npc.type == NPCID.TheHungry || npc.type == NPCID.TheHungryII) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedMechBoss1) { //destroyer
                    Main.expertMode = true;
                    if (npc.type == NPCID.TheDestroyer || npc.type == NPCID.TheDestroyerBody || npc.type == NPCID.TheDestroyerTail) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedMechBoss2) { //twins
                    Main.expertMode = true;
                    if (npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedMechBoss3) { // skeletron prime
                    Main.expertMode = true;
                    if (npc.type == NPCID.SkeletronPrime) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedPlantBoss) {
                    Main.expertMode = true;
                    if (npc.type == NPCID.Plantera || npc.type == NPCID.PlanterasHook || npc.type == NPCID.PlanterasTentacle) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedGolemBoss) {
                    Main.expertMode = true;
                    if (npc.type == NPCID.GolemFistLeft || npc.type == NPCID.GolemFistRight || npc.type == NPCID.GolemHead || npc.type == NPCID.GolemHeadFree) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedFishron) {
                    Main.expertMode = true;
                    if (npc.type == NPCID.DukeFishron) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedAncientCultist) {
                    Main.expertMode = true;
                    if (npc.type == NPCID.CultistBoss) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedMoonlord) {
                    Main.expertMode = true;
                    if (npc.type == NPCID.MoonLordCore || npc.type == NPCID.MoonLordFreeEye || npc.type == NPCID.MoonLordHand || npc.type == NPCID.MoonLordHead || npc.type == NPCID.MoonLordLeechBlob) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedTowerSolar) {
                    Main.expertMode = true;
                    if (npc.type == NPCID.LunarTowerSolar) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedTowerStardust)
                {
                    Main.expertMode = true;
                    if (npc.type == NPCID.LunarTowerStardust) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedTowerNebula)
                {
                    Main.expertMode = true;
                    if (npc.type == NPCID.LunarTowerNebula) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
                if (NPC.downedTowerVortex)
                {
                    Main.expertMode = true;
                    if (npc.type == NPCID.LunarTowerVortex) npc.SetDefaults(npc.type);
                    Main.expertMode = false;
                }
            }
        }
    }
}
