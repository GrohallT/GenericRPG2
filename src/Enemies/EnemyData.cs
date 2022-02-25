//---------------------------------------------------------------
// Name:    Marshall Paider
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Store all of the information pertaining to the enemies
//---------------------------------------------------------------------

using GenericRPG2.CharacterClass;
using GenericRPG2.Stats;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenericRPG2.Enemies {
    public class EnemyData
    {
        public static Dictionary<EnemyTypeEnum, int> experienceValues = new Dictionary<EnemyTypeEnum, int>()
            {
                { EnemyTypeEnum.GREEN_SLIME, 10 },
                { EnemyTypeEnum.BLUE_SLIME, 20 },
                { EnemyTypeEnum.RED_SLIME, 30 },
                { EnemyTypeEnum.BEE, 40 },
                { EnemyTypeEnum.GOBLIN, 100 },
                { EnemyTypeEnum.SKELETON, 120 },
                { EnemyTypeEnum.BEE_SWARM, 300 },
                { EnemyTypeEnum.ANGRY_SLIME, 350 },
                { EnemyTypeEnum.MECHA_NAPOLEON, 50000 }
            };
        private EnemyStats enemyStats;
        private PictureBox enemySprite;

        private const int SPRITE_WIDTH = 64;
        private const int SPRITE_HEIGHT = 64;
        private const int NUM_OF_ENEMY_TYPES = 9;
        private const int NUM_OF_LESSER_ENEMIES = 6;

        private EnemyTypeEnum enemyType;

        //private LinkedList<Skills> skills;

        public EnemyData()
        {
            Random random = new Random();
            // generates a random type for the enemy
            this.enemyType = (EnemyTypeEnum)random.Next(0, NUM_OF_LESSER_ENEMIES); 

            this.enemyStats = new EnemyStats(enemyType);
            this.enemySprite = new PictureBox();
        }

        public EnemyData(EnemyTypeEnum enemyType)
        {
            this.enemyType = enemyType;

            this.enemyStats = new EnemyStats(enemyType);
            this.enemySprite = new PictureBox();
        }

        public EnemyStats getEnemyStats()
        {
            return this.enemyStats;
        }

        public EnemyTypeEnum getEnemyType()
        {
            return this.enemyType;
        }

        public void setEnemySprite(Image newSprite)
        {
            this.enemySprite.Image = newSprite;
        }

        public PictureBox getEnemySprite()
        {
            return this.enemySprite;
        }
    }
}