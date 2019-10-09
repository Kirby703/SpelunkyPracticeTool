﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpelunkyPracticeTool
{
    enum AllEntities
    {
        PLAYER = 0,
	SKELETON_RIBCAGE = 11,
	TEMPLE_TRAP_CEILING = 42,
	TEMPLE_TRAP_WALL = 43,
	BOUNCE_TRAP = 44,
	THWOMP = 45,
        MINE = 92,
        CHEST = 100,
	CRATE = 101,
	GOLD_BAR = 102,
	STACK_OF_GOLD_BARS = 103,
	LARGE_EMERALD = 104,
	LARGE_SAPPHIRE = 105,
	LARGE_RUBY = 106,
	LIVE_BOMB = 107,
	ATTACHED_ROPE = 108,
        WHIP = 109,
	BLOOD = 110,
	DIRT_BREAK = 111,
	STONE = 112,
	POT = 113,
	SKULL = 114,
	SPIDER_WEB = 115,
	HONEY = 116,
	SHOTGUN_SHOT = 117,
	LARGE_GOLD_NUGGET = 118,
	BOULDER = 120,
	PUSHABLE_STONE_BLOCK = 121,
	ARROW = 122,
	SHOP_DOLLAR_SIGN = 123,
	SMALL_GOLD_NUGGET = 124,
	SMALL_EMERALD = 125,
	SMALL_SAPPHIRE = 126,
	SMALL_RUBY = 127,
        ROPE_PART = 137,
	SPIDER_WEB_SHOT = 142,
	GOLD_CHEST = 153,
	GOLD_KEY = 154,
	USED_PARACHUTE = 156,
	TIKI_TRAP_SPIKES = 157,
	SCRATCH = 158,
	ALIEN_SHOT = 159,
	UFO_SHOT = 160,
	FALLING_PLATFORM = 161,
	LAMP = 162,
	FLARE = 163,
	SNOWBALL = 164,
	FLY = 165,
	BLACK_BOX = 166,
	SPRITESHEET_1 = 167,
	FLYING_TRAP_BLOCK = 168,
	FLYING_LAVA = 169,
	WIN_GAME = 170,
	WHITE_FLAG = 171,
	FISH_SKELETON = 172,
	NATURAL_DIAMOND = 173,
	WORM_ENTRANCE = 174,
	WORM_ACTIVATED = 175,
	IMP_CAULDRON = 176,
	BRIGHT_LIGHT = 177,
	SPIKE_BALL = 178,
	SPIKE_BALL_CHAIN = 179,
	JOURNAL = 180,
	PAPER = 181,
	WORM_BLOCK = 182,
	ICE_PLATFORM = 183,
	LEAF = 184,		//also mummy wrappings and from open mystery boxes lol
	STATIC_CHEST = 187,
	PRIZE_WHEEL = 188,
	PRIZE_WHEEL_FLIPPER = 189,
	PRIZE_DOOR = 190,
	ACID_BUBBLE = 192,
	ACID_DROP = 193,
	FALLING_ICE = 194,
	ICE_BREAK = 195,
	SMOKE_1 = 196,
	FORCE_FIELD = 197,
	FORCE_FIELD_BEAM = 198,
	ICE_ENERGY_SHOT = 203,
	SHIELD_INVIS_WALL = 206,
	BROKEN_MATTOCK = 210,
	COFFIN = 211,
	UNKNOWN_1 = 212,
	TURRET_SHOT = 213,
	SPACESHIP_PLATFORM = 214,
	SPACESHIP_ELEVATOR = 215,
	BROKEN_ARROW = 216,
	OLMEC_ORB = 217,
	FALLING_WATER = 218,
	BLACK_BOX_ACCESSORY = 219,
	BLACK_BOX_PICKUP = 219,
	CHAIN_BALL = 220,
	SMOKE_2 = 221,
	OLMEC_INTRO = 223,
	CAMEL = 224,
	ALIEN_TARGET = 225,
	ALIEN_TARGET_SHOT = 226,
	SPACESHIP_LIGHT = 227,
	SPIDER_WEB_BALL = 228,
	ANKH_RESPAWN = 229,
	ANKH_GLOW = 230,
	BEE_PARTS = 232,
	FIRE = 233,
	ANUBIS_II = 234,
	POWDER_BOX = 235,
	STRING = 236,
	SMALL_SPIDER_WEB = 237,
	SPRITESHEET_2 = 238,
	YANG = 239,
	COIN = 240,
	FIREWORK = 242,
	LAVAFALL_SPOUT = 243
	CASTLE_BANNER = 244,
	UNLIT_WALL_TORCH = 245,
	UNLIT_TORCH = 246,
	ALIEN_QUEEN_RING = 247,
	MYSTERY_BOX = 248,
	INVISABLE_BLOCK = 249,
	SKULL_CROWN = 250,
	SPRITESHEET_3 = 251,
	EGGPLANT = 252,
	BALLOON = 253,
	EXPLOSION = 301,
	RED_BALL = 302,
	TINY_FIRE = 303,
	SPRING_RINGS = 304,
	SPELUNKER_TELEPORT = 305,
	TORCH_FIRE = 306,
	SMALL_FIRE = 307,
	GLASS_BLOCK = 455,
	ROPES = 500,
	BOMB_BAG = 501,
	BOMB_BOX = 502,
	SPECTACLE = 503,
	CLIMBING_GLOVES = 504,
	PITCHERS_MITT = 505,
	SPRING_SHOES = 506,
	SPIKE_SHOES = 507,
	BOMB_PASTE = 508,
	COMPASS = 509,
	MATTOCK = 510,
	BOOMERANG = 511,
	MACHETE = 512,
	CRYSKNIFE = 513,
	WEB_GUN = 514,
	SHOTGUN = 515,
	FREEZE_RAY = 516,
	PLASMA_CANNON = 517,
	CAMERA = 518,
	TELEPORTER = 519,
	PARACHUTE = 520,
	CAPE = 521,
	JETPACK = 522,
	SHIELD = 523,
	ROYAL_JELLY = 524,
	IDOL = 525,
	KAPALA = 526,
	UDJAT_EYE = 527,
	ANKH = 528,
	HEDJET = 529,
	SCEPTER = 530,
	BOOK_OF_THE_DEAD = 531,
	VLADS_CAPE = 532,
	VLADS_AMULET = 533,
	SNAKE = 1001,
	SPIDER = 1002,
	BAT = 1003,
	CAVEMAN = 1004,
	DAMSEL = 1005,
	SHOPKEEPER = 1006,
	FROG = 1007,
	MANTRAP = 1008,
	YETI = 1009,
	UFO = 1010,
	HAWK_MAN = 1011,
	SKELETON = 1012,
	PIRANHA = 1013,
	MUMMY = 1014,
	MONKEY = 1015,
	ALIEN_LORD = 1016,
	GHOST = 1017,
	GIANT_SPIDER = 1018,
	JIANG_SHI = 1019,
	VAMPIRE = 1020,
	FIRE_FROG = 1021,
	TUNNEL_MAN = 1022,
	OLD_BITEY = 1023,
	SCARAB = 1024,
	YETI_KING = 1025,
	ALIEN = 1026,
	MAGMA_MAN = 1027,
	VLAD = 1028,
	SCORPION = 1029,
	IMP = 1030,
	DEVIL = 1031,
	BEE = 1032,
	ANUBIS = 1033,
	QUEEN_BEE = 1034,
	BACTERIUM = 1035,
	COBRA = 1036,
	SPINNER_SPIDER = 1037,
	GIANT_FROG = 1038,
	MAMMOTH = 1039,
	ALIEN_TANK = 1040,
	TIKI_MAN = 1041,
	SCORPION_FLY = 1042,
	SNAIL = 1043,
	CROC_MAN = 1044,
	GREEN_KNIGHT = 1045,
	WORM_EGG = 1046,
	WORM_BABY = 1047,
	ALIEN_QUEEN = 1048,
	THE_BLACK_KNIGHT = 1049,
	GOLDEN_MONKEY = 1050,
	SUCCUBUS = 1051,
	HORSE_HEAD = 1052,
	OX_FACE = 1053,
	OLMEC = 1055,
	KING_YAMA = 1056,
	KING_YAMAS_HAND = 1057,
	TURRET = 1058,
	BABY_FROG = 1059,
	WATCHING_BALL = 1060,
	SPIDERLING = 1061,
	FISH = 1062,
	RAT = 1063,
	PENGUIN = 1064,
	BACKGROUND_ALIEN = 1065,
        BIRDS = 1066,
	LOCUST = 1067,
	MAGGOT = 1068
    };

    public partial class entity_list : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);

        private const int SB_HORZ = 0x0;
        private const int SB_VERT = 0x1;

        Dictionary<int, EntityData> Entities = new Dictionary<int, EntityData>();

        public entity_list()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, panel, new object[] { true });

            ListFont = new Font("Arial", 9);
            YOff = Font.Height + 1;
        }

        private void fetchlistbutton_Click(object sender, EventArgs e)
        {
            RefreshTree();
        }

        public void RefreshTree()
        {
            if (Memory.Process == null || Memory.Process.HasExited) return;

            int address = Memory.getPointerAddress(Memory.BaseAddress + 0x1384B4, 0x30, 0), ptr, i = 0;
            EntityData en;

            var c = new Dictionary<int, EntityData>();
            
            while ((ptr = Memory.ReadInt32(address + i++ * 4)) != 0)
                if(!c.ContainsKey(ptr))
                    c.Add(ptr, Entities.TryGetValue(ptr, out en) ? en.UpdateValues() : new EntityData(ptr));

            Entities = c;

            panel.Invalidate();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Updater.Enabled = !Updater.Enabled;
            toolStripButton2.Text = (Updater.Enabled ? "Disable" : "Enable")+" Auto-Update";
        }

        private void Updater_Tick(object sender, EventArgs e)
        {
            RefreshTree();
        }

        int YOff = 20;
        Font ListFont;
        const int XOff = 15;
        const int NodeOff = 30;
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var b = new SolidBrush(Color.Black);

            int y = panel.AutoScrollPosition.Y;
            g.Clear(Color.White);
            foreach(var Entity in Entities.Values)
            {
                y += YOff;

                g.DrawString((Entity.ShowValues ? '-' : '+' ) + Entity.Name, Font, b, XOff, y);

                if (!Entity.ShowValues) continue;
                
                foreach(var value in Entity.Values)
                {
                    y += YOff;

                    g.DrawString(value,DefaultFont,b,NodeOff, y);
                }
            }

            panel.AutoScroll = true;
            AutoScrollLabel.Location = new Point(0,y+YOff);
        }

        private void panel_Click(object sender, EventArgs e)
        {
            
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            int y = panel.AutoScrollPosition.Y;
            foreach (var Entity in Entities.Values)
            {
                y += YOff;
                if(y < e.Y && y+YOff > e.Y)
                {
                    Entity.ShowValues = !Entity.ShowValues;
                    panel.Invalidate();

                    return;
                }
                    
                if (!Entity.ShowValues) continue;

                foreach (var value in Entity.Values)
                    y += YOff;
            }
        }
    }
}
