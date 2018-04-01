using Terraria.ID;
using Terraria.ModLoader;

namespace desolation.Items
{
    public class Sapphiresword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sapphire Sword");
        }
        public override void SetDefaults()
        {
            item.damage = 14;
            item.melee = true;
            item.width = 50;
            item.height = 50;
            item.useTime = 30;
            item.scale = 1.1f;
            item.shoot = 335;
            item.shootSpeed = 14f;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 10001;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Sapphire, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}