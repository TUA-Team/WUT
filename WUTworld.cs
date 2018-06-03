using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace WUT
{
    class WUTworld : ModWorld
    {
        public override void PostUpdate()
        {
            Main.dayTime = true;
        }

        public static void generateHouse()
        {

        }
    }
}
