using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.World.Generation;

namespace WUT
{
    class WUTGen : Dimlibs.API.DimGenerator
    {
        private int[] dungeonBrickList = { TileID.BlueDungeonBrick, TileID.GreenDungeonBrick, TileID.PinkDungeonBrick };

        public override void ModifyGenerationPass(int seed, GenerationProgress customProgressObject)
        {
            AddGenerationPass("WUT", delegate (GenerationProgress progress)
            {
                int dungeonBrick = Main.rand.Next(dungeonBrickList);
                for (int k = 0; k < Main.maxTilesX; k++)
                {
                    for (int l = 0; l < Main.maxTilesY; l++) {
                        Main.tile[k, l].active(true);
                        Main.tile[k, l].type = (ushort)dungeonBrick;
                        //Main.tile[k, l].wall = WallID.BlueDungeonSlabUnsafe;
                        Main.tile[k, l].frameX = -1;
                        Main.tile[k, l].frameY = -1;
                    }
                }
            });

            AddGenerationPass("WUT spawn", delegate (GenerationProgress progress)
            {
                int dungeonBrick = Main.rand.Next(dungeonBrickList);
                for (int k = Main.spawnTileX - 10; k < Main.spawnTileX + 10; k++)
                {
                    for (int l = Main.spawnTileY - 10; l < Main.spawnTileY + 10; l++)
                    {
                        WorldGen.KillTile(k, l);
                        Main.tile[k, l].wall = WallID.DirtUnsafe;
                        Main.tile[k, l].frameX = -1;
                        Main.tile[k, l].frameY = -1;
                    }
                }


                for (int k = Main.spawnTileX - 80; k < Main.spawnTileX - 60; k++)
                {
                    for (int l = Main.spawnTileY-5; l < Main.spawnTileY+5; l++)
                    {
                        WorldGen.KillTile(k, l);
                    }
                }

                for (int k = Main.spawnTileX - 80; k < Main.spawnTileX - 60; k++)
                {
                    for (int l = Main.spawnTileY - 12; l < Main.spawnTileY - 7; l++)
                    {
                        WorldGen.KillTile(k, l);
                    }
                }

                for (int k = Main.spawnTileX - 80; k < Main.spawnTileX - 60; k++)
                {
                    for (int l = Main.spawnTileY - 19; l < Main.spawnTileY - 14; l++)
                    {
                        WorldGen.KillTile(k, l);
                    }
                }
            });


        }
    }
}
