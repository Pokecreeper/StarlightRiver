﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace StarlightRiver.Dusts
{
    public class Stamina : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.velocity *= 0.3f;
            dust.noGravity = true;
            dust.noLight = false;
            dust.scale *= 0.5f;
            dust.color.R = 255;
            dust.color.G = 172;
            dust.color.B = 107;
        }
        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return dust.color;
        }
        public override bool Update(Dust dust)
        {
            dust.rotation += 0.15f;
            dust.velocity *= 0.95f;
            dust.color *= 0.98f;

            dust.scale *= 0.98f;
            if (dust.scale < 0.1f)
            {
                dust.active = false;
            }
            return false;
        }
    }
}
