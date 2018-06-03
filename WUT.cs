using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace WUT
{
	class WUT : Mod
	{
        internal static string door1;
        internal static string door2;
        internal static string hallway1;
        internal static string hallway2;


        public WUT()
		{
            Properties = new ModProperties()
            {
                Autoload = true
            };
        }

        public override void Load()
        {
            TmodFile f = File;
            int i = f.FileCount;
            door1 = System.Text.Encoding.UTF8.GetString(GetFileBytes("structure/door.txt"));
            door2 = System.Text.Encoding.UTF8.GetString(GetFileBytes("structure/door2.txt"));
            hallway1 = System.Text.Encoding.UTF8.GetString(GetFileBytes("structure/hallway1.txt"));
            hallway2 = System.Text.Encoding.UTF8.GetString(GetFileBytes("structure/hallway2.txt"));
            string iss= "";
        }
    }
}
