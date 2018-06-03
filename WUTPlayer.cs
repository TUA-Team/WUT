using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace WUT
{
    class WUTPlayer : ModPlayer
    {
        public override void Load(TagCompound tag)
        {
        }

        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            if (Dimlibs.Dimlibs.getPlayerDim() == "WUT")
            {
                damageSource = PlayerDeathReason.ByCustomReason(player.name + " : wut... WUT... W U T...");

            }
            if (damageSource.SourceNPCIndex == 22)
            {
                damageSource = PlayerDeathReason.ByCustomReason(player.name + " didn't saw the WUT coming!");
            }
            return true;
        }


        public override void SetupStartInventory(IList<Item> items)
        {

            Item item = new Item();
            item.SetDefaults(mod.ItemType("WUT"));
            item.stack = 1;
            items.Add(item);
            base.SetupStartInventory(items);
        }
    }
}
