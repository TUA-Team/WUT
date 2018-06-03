using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace WUT.DimensionGen.Psycho
{
    class PsychoWUT : Dimlibs.API.DimItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Psycho Knife");
            Tooltip.SetDefault("Allows you to go into stealth mode");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.damage = 70;
            item.knockBack = 3.5f;
            item.crit = 4;
            item.useTime = 20;
            item.rare = 8;
            item.width = 30;
            item.height = 30;
            item.scale = 1.1f;
            item.melee = true;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 20;
            setDimensionGenerator(new PsychoWUTGen());
            dimensionMessage = "I'm gonna get you";
            dimensionName = "Psycho Dim";
        }

        public override bool UseItem(Player player)
        {
            Main.NewText("WUT csproj : " + mod.FileExists("WUT.csproj"));
            Main.NewText("WUT sln : " + mod.FileExists("WUT.sln"));
            
            TmodFile f = mod.File;
           
            Main.NewText("PsychoWUTKnife : " + f.HasFile("WUT.csproj.user"));
            
            //string door = System.Text.Encoding.UTF8.GetString(mod.GetFileBytes("structure/door.txt"));
            //print(door);
            Mod psycho = ModLoader.GetMod("Psycho");
            if (psycho != null) {
                return base.UseItem(player);
            }
            return false;
        }

        public void print(string letsee) {
            ErrorLogger.Log(letsee);
        }
    }
}