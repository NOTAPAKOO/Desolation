using Terraria.ID;
using Terraria.ModLoader;

namespace desolation.Items
{
    public class Cwoodensword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Compressed Wooden Sword");
            Tooltip.SetDefault("This is a dumb idea.");
        }
        public override void SetDefaults()
        {
            item.damage = 16;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 27;
            item.useAnimation = 27;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenSword, 9);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

  
    }
  }

