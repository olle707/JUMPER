﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Jumper
{
    static class C2Level1
    {
        // Position of player
        public static Vector2 PlayerPosition = new Vector2(25, 10);
        public static float LevelTime = 30;

        public static TileManager tileManager;
        public static TypeText TutorialText;

        // Texture of breakable used for all levels in chapter
        private static Texture2D breakable;

        // Load all tiles for level
        public static void LoadContent(ContentManager Content, GraphicsDevice GraphicsDevice)
        {
            tileManager = new TileManager();

            // Load textures for level
            Texture2D block = Content.Load<Texture2D>(@"Sprites/Block2");
            breakable = Content.Load<Texture2D>(@"Sprites/Breakable2");

            tileManager.AddTile(block, new Vector2(9, 64), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(34, 64), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(63, 140), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(114, 219), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(190, 291), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(273, 346), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(355, 373), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(434, 393), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(515, 403), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(595, 412), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(671, 413), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(746, 413), new Rectangle(0, 0, 25, 25));
            tileManager.AddTile(block, new Vector2(771, 413), new Rectangle(0, 0, 25, 25));

        }

        // Spawn all breakables for level
        public static void SpawnBreakables(BreakableManager breakableManager)
        {
            // Change texture to one used for chapter
            breakableManager.Texture = breakable;

            //breakableManager.SpawnBreakable(new Vector2(x, y));
        }

        // Spawn all spikes for level
        public static void SpawnSpikes(SpikeManager spikeManager)
        {
            //spikeManager.SpawnSpike(new Vector2(x, y));
        }

        // Spawn all enemies for level
        public static void SpawnEnemies(EnemyManager enemyManager)
        {
            enemyManager.SpawnEnemy(new Vector2(540, 388), new Vector2(770, 388), 4);
        }

        // Position player
        public static void PositionPlayer(PlayerManager player)
        {
            player.Position = PlayerPosition;
        }

        // Position door and spawn keys
        public static void SpawnDoorAndKeys(KeyDoor keyDoor)
        {
            // Position door
            keyDoor.DoorPosition = new Vector2(771, 377);

            // Spawn keys
            keyDoor.SpawnKey(new Vector2(70, 115));
            keyDoor.SpawnKey(new Vector2(280, 321));
            keyDoor.SpawnKey(new Vector2(603, 387));
        }

        // Spawn hearts for level0
        public static void SpawnHearts(HeartManager heartManager)
        {
            //heartManager.SpawnHeart(new Vector2(x, y));
        }
    }
}
