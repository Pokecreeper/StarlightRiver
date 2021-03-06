﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace StarlightRiver.Items.IceandFire
{
    public class PHFireStaff : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 34;
            item.useStyle = 5;
            Item.staff[item.type] = true;
            item.useAnimation = 40;
            item.useTime = 40;
            item.shootSpeed = 8f;
            item.knockBack = 2f;
            item.damage = 24;
            item.shoot = mod.ProjectileType("PHImplosion");
            item.rare = 3;
            item.noMelee = true;
            item.magic = true;
            item.channel = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Main.PlaySound(2, (int)player.position.X, (int)player.position.Y, 14); //boom
            Main.PlaySound(2, (int)player.position.X, (int)player.position.Y, 73); //fork
            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(18));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;
            return true;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Implosion Staff");
            Tooltip.SetDefault("Sends out a ball of fire that explodes on mouse release");
        }
    }
    public class HMFireStaff : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 46;
            item.useStyle = 5;
            Item.staff[item.type] = true;
            item.useAnimation = 50;
            item.useTime = 50;
            item.shootSpeed = 12f;
            item.knockBack = 2f;
            item.damage = 76;
            item.shoot = mod.ProjectileType("HMImplosion");
            item.rare = 6;
            item.noMelee = true;
            item.magic = true;
            item.useTurn = false;
            item.channel = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Main.PlaySound(2, (int)player.position.X, (int)player.position.Y, 14); //boom
            Main.PlaySound(2, (int)player.position.X, (int)player.position.Y, 73); //fork
            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 65f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(21));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;
            return true;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Advanced Implosion Staff");
            Tooltip.SetDefault("Sends out a ball of superheated matter that draws enemies in and then explodes on mouse release");
        }
    }
}
