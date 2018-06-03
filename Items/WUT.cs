using Terraria.ID;
using Terraria.ModLoader;

namespace WUT.Items
{
	public class WUT : Dimlibs.API.DimItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("WUT");
			Tooltip.SetDefault("WUT");
		}
		public override void SetDefaults()
		{

			item.width = 28;
			item.height = 14;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            dimensionName = "WUT";
            setDimensionGenerator(new WUTGen());
            dimensionMessage = "get dunked m8!";
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        
	}
}
