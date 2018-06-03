using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WUT
{
    class WUTNpc : GlobalNPC
    {
        public override void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
        {
            String dim = Dimlibs.Dimlibs.getPlayerDim();
            spawnInfo.safeRangeX = false;
            spawnInfo.playerSafe = false;
            spawnInfo.sky = false;
            spawnInfo.spawnTileX = 0;
            spawnInfo.spawnTileY = 0;
            spawnInfo.water = false;
            spawnInfo.playerInTown = false;
            spawnInfo.player = Main.LocalPlayer;
            
            if (Dimlibs.Dimlibs.getPlayerDim() == "WUT")
            {
                pool.Clear();
                pool.Add(NPCID.DungeonGuardian, 10f);
                pool.Add(NPCID.SkeletronHead, 10f);
                pool.Add(NPCID.SkeletronPrime, 10f);
            }
        }

        public override void AI(NPC npc)
        {
            if (npc.type == 22) {
                npc.boss = true;
                npc.GivenName = "ULTRA GUIDE"; 
            }
        }

        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if (Dimlibs.Dimlibs.getPlayerDim() == "WUT")
            {
                spawnRate = 5;
                maxSpawns = 50;
            }
            //base.EditSpawnRate(player, ref spawnRate, ref maxSpawns);
        }

        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type == 22) {
                Terraria.DataStructures.PlayerDeathReason wut = new Terraria.DataStructures.PlayerDeathReason();
                wut.SourceNPCIndex = 22;

                chat = "WUT WUT WUT WUT WUT WUT";
                Main.LocalPlayer.statLife = 0;
                Main.LocalPlayer.KillMe(wut, 1000, 0, false); 
            }
        }
    }
}
