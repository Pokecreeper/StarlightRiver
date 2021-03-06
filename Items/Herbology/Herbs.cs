﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarlightRiver.Items.Herbology
{
    public class Ivy : QuickMaterial { public Ivy() : base("Forest Ivy", "A common, yet versatile herb", 999, 100, 1) { } }
    public class IvySeeds : QuickMaterial { public IvySeeds() : base("Forest Ivy Seeds", "Can grow in hanging planters", 99, 0, 1) { } }

    public class Deathstalk : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Grows on Rich Soil");
            DisplayName.SetDefault("Deathstalk");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.rare = 2;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("Deathstalk");
        }
    }
}
