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
    class Smash : Ability
    {
        
        public Smash() : base(2) // stamina cost
        {

        }

        public override void OnCast()
        {
            Active = true;
            timer = 15;
        }

        int timer;
        public override void InUse()
        {
            Player player = Handler.player;
            player.maxFallSpeed = 999;
            player.velocity.X = 0;
            player.velocity.Y = 35;

            for (int k = 0; k <= 5; k++)
            {
                Dust.NewDust(player.Center - new Vector2(player.height / 2, -32), player.height, player.height, ModContent.DustType<Stone>(), 0,0,0,default, 1.4f);
                Dust.NewDust(player.Center - new Vector2(player.height / 2, -32), player.height, player.height, DustID.Dirt, Main.rand.Next(-20, 20) * 0.5f, 0, 0, default, 0.8f);
                if (k % 2 == 0)
                {
                    Dust.NewDust(player.Center - new Vector2(player.height / 2, -32), player.height, player.height, ModContent.DustType<Grass>(), Main.rand.Next(-10, 10) * 0.5f, 0, 0, default, 1.8f);
                }
            }

            if (timer++ >= 15)
            {
                Main.PlaySound(SoundID.Item66, player.Center);
                timer = 0;
            }

            if (player.position.Y - player.oldPosition.Y == 0)
            {
                Active = false;
                OnExit();
            }
        }

        public override void OnExit()
        {
            Player player = Handler.player;

            for (float k = 0; k <= 6.28; k += 0.06f)
            {
                Dust.NewDust(player.Center, 1,1, ModContent.DustType<Stone>(), (float)Math.Cos(k) * 12, (float)Math.Sin(k) * 12, 0, default, 1.8f);
                Dust.NewDust(player.Center - new Vector2(player.height / 2, -32), player.height, player.height, ModContent.DustType<Grass>(), (float)Math.Cos(k) * 8, (float)Math.Sin(k) * 8, 0, default, 2f);
            }
            Main.PlaySound(SoundID.Item70, player.Center);
            Main.PlaySound(SoundID.NPCHit42, player.Center);
            Main.PlaySound(SoundID.Item14, player.Center);


            player.velocity.X = 0;
            player.velocity.Y = 0;
        }
    }
}
