﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarlightRiver.Projectiles.WeaponProjectiles
{
    public class Diver : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.friendly = true;
            projectile.width = 8;
            projectile.height = 8;
            projectile.penetrate = -1;
            projectile.timeLeft = 750;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.damage = 5;
            projectile.extraUpdates = 5;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Corrosive Spores");
        }
        public override void AI()
        {
            
            if (Main.tile[(int)projectile.position.X / 16, (int)projectile.position.Y / 16].active() == false)
            {
                Dust.NewDustPerfect(projectile.position, mod.DustType("Gold"));
                projectile.velocity.Y += 0.02f;
            }
            else
            {
                Dust.NewDustPerfect(projectile.position, mod.DustType("Gold"));
                projectile.velocity.Y -= 0.02f;
            }
        }
    }
}