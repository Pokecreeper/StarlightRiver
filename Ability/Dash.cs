﻿using Microsoft.Xna.Framework;
using StarlightRiver.Dusts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarlightRiver.Abilities
{
    [DataContract]
    class Dash : Ability
    {
        
        [DataMember] protected int timer = 0;
        [DataMember] protected float X = 0;
        [DataMember] protected float Y = 0;

        public Dash() : base(1)
        {

        }

        public override void OnCast()
        {
            Active = true;
            Main.PlaySound(SoundID.Item45);
            Main.PlaySound(SoundID.Item104);

            X = ((player.controlLeft) ? -1 : 0) + ((player.controlRight) ? 1 : 0);
            Y = ((player.controlUp) ? -1 : 0) + ((player.controlDown) ? 1 : 0);
            timer = 7;
        }

        public override void InUse()
        {
            player.maxFallSpeed = 999;

            timer--;

            if (X != 0 || Y != 0)
            {
                player.velocity = Vector2.Normalize(new Vector2(X, Y)) * 28;
            }

            if(Vector2.Distance(player.position, player.oldPosition) < 5 && timer < 4)
            {
                timer = 0;
                player.velocity *= -0.2f;                
            }

            if (timer <= 0)
            {
                Active = false;
                OnExit();               
            }
        }
        public override void UseEffects()
        {
            for (int k = 0; k <= 10; k++)
            {
                Dust.NewDustPerfect(player.Center + player.velocity * Main.rand.NextFloat(0, 2), ModContent.DustType<Air>(), player.velocity.RotatedBy((Main.rand.Next(2) == 0) ? 2.8f : 3.48f) * Main.rand.NextFloat(0, 0.05f), 0, default, 0.95f);
            }
        }

        public override void OnExit()
        {
            player.velocity.X *= 0.15f;
            player.velocity.Y *= 0.15f;
        }
    }
}
