using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarlightRiver.Items
{
    public class VoidGooItem : QuickTileItem
    {
        public VoidGooItem() : base("Void Goo", "Can be passed with a shadow dash", ModContent.TileType<Tiles.VoidGoo>(), 8) { }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(Itemname);
            Tooltip.SetDefault(Itemtooltip);
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }
    }
    public class VoidDoorItem : QuickTileItem
    {
        public VoidDoorItem() : base("Void Barrier", "Dissappears when Purified", ModContent.TileType<Tiles.VoidDoorOn>(), 8) { }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(Itemname);
            Tooltip.SetDefault(Itemtooltip);
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }
    }
    public class Fluff : ModItem // remove?
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Float upwards");
            DisplayName.SetDefault("GraviWater");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.noUseGraphic = true;
            item.consumable = true;
            item.createTile = mod.TileType("Fluff");
        }
    }
}
