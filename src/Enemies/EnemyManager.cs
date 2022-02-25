//---------------------------------------------------------------
// Name:    Marshall Paider
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Manages the behavior and logic of the enemies
//---------------------------------------------------------------------

using GenericRPG2.CharacterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Enemies
{
    public class EnemyManager
    {
        private EnemyData enemy;

        public EnemyManager()
        {
            this.enemy = new EnemyData();

            // update picturebox
            updateEnemySprite(this.getEnemy().getEnemyType());
        }

        public EnemyManager(EnemyTypeEnum type)
        {
            this.enemy = new EnemyData(type);

            // update picture box
            updateEnemySprite(type);
        }

        public EnemyData getEnemy()
        {
            return enemy;
        }


        public void updateEnemySprite(EnemyTypeEnum type)
        {
            if (type == EnemyTypeEnum.ANGRY_SLIME)
            {
                enemy.setEnemySprite(Properties.Resources.SlimeAngry);
            }
            else if (type == EnemyTypeEnum.BEE)
            {
                enemy.setEnemySprite(Properties.Resources.Bee);
            }
            else if (type == EnemyTypeEnum.BEE_SWARM)
            {
                enemy.setEnemySprite(Properties.Resources.BeeSwarm);
            }
            else if (type == EnemyTypeEnum.BLUE_SLIME)
            {
                enemy.setEnemySprite(Properties.Resources.SlimeBlue);
            }
            else if (type == EnemyTypeEnum.GOBLIN)
            {
                enemy.setEnemySprite(Properties.Resources.Goblin);
            }
            else if (type == EnemyTypeEnum.GREEN_SLIME)
            {
                enemy.setEnemySprite(Properties.Resources.SlimeGreen);
            }
            else if (type == EnemyTypeEnum.MECHA_NAPOLEON)
            {
                enemy.setEnemySprite(Properties.Resources.MechaNapoleon);
            }
            else if (type == EnemyTypeEnum.RED_SLIME)
            {
                enemy.setEnemySprite(Properties.Resources.SlimeRed);
            }
            else if (type == EnemyTypeEnum.SKELETON)
            {
                enemy.setEnemySprite(Properties.Resources.Skeleton);
            }
        }

        public double awardGold()
        {
            return this.getEnemy().getEnemyStats().getGoldGiven();
        }
    }
}
