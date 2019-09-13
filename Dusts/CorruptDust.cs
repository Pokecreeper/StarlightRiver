﻿
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace spritersguildwip.Dusts
    {
    public class Corrupt : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.noLight = false;
        }
        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return Color.White * dust.scale;
        }
        public override bool Update(Dust dust)
        {
            dust.position.Y -= 0.2f;
            dust.position += dust.velocity;
            dust.velocity *= 0.94f;
            dust.scale *= 0.94f;
            dust.color *= 0.94f;
            if (dust.scale <= 0.4)
            {
                dust.active = false;
            }

            float light = 0.2f * dust.scale;
            if (dust.scale <= 2.5 + .55)
            {
                Lighting.AddLight(dust.position, new Vector3(1.49f,1.32f,1.59f) * light);
            }
            return false;
        }
   
    }

}
