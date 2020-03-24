﻿using StarlightRiver.Abilities;
using Terraria;
using Terraria.ModLoader;

namespace StarlightRiver.Items.Accessories
{
    public class PowerCell : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Power Cell");
            DisplayName.SetDefault("Unimplimented Function");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.accessory = true;
        }
    }
}