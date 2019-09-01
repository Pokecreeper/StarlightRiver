using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace spritersguildwip.Items.Melee
{
	public class fortnite : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 66;
			item.melee = true;
			item.width = 22;
			item.height = 25;
			item.useTime = 1;
			item.useAnimation = 6;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 270000;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = 43;
			item.shootSpeed = 10f;
			item.useTurn = true;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("fortnite");
      Tooltip.SetDefault("fortnite");
    }


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 16);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
			if (target.type != 488)
			{
				for (int i = 0; i <= 1; i++)
				{
					float sX = 2f;
					float sY = 2f;
					sX += (float)Main.rand.Next(-60, 61) * 0.2f;
					sY += (float)Main.rand.Next(-60, 61) * 0.2f;
					Projectile.NewProjectile(target.Center.X, target.Center.Y, sX, sY, ProjectileID.Bee, damage, knockback, player.whoAmI, 0f, 0f);
					Projectile.NewProjectile(target.Center.X, target.Center.Y, -sX, -sY, ProjectileID.Wasp, damage, knockback, player.whoAmI, 0f, 0f);
				}
			}
        }
	}
}
