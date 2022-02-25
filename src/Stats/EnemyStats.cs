//---------------------------------------------------------------
// Name:    Marshall Paider
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Stores all of the stats of the enemies
//---------------------------------------------------------------------

using GenericRPG2.CharacterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRPG2.Stats
{
    public class EnemyStats : IStats
    {
        private const int STARTING_HP = 10;
        private const int STARTING_SP = 10;
        private const int STARTING_ATTACK = 0;
        private const int STARTING_DEFENSE = 10;
        private const int STARTING_SPEED = 10;
        private const int GOLD_GIVEN = 100;

        private int current_hp;
        private int starting_hp;
        private int attack;
        private int defense;
        private int speed;
        private int current_sp;
        private int starting_sp;

        private int goldGiven;

        public EnemyStats(EnemyTypeEnum type)
        {
            this.starting_hp = STARTING_HP;
            this.starting_sp = STARTING_SP;
            this.attack = STARTING_ATTACK;
            this.defense = STARTING_DEFENSE;
            this.speed = STARTING_SPEED;
            this.goldGiven = GOLD_GIVEN;

            int boostForEnemy;

            if (type == EnemyTypeEnum.ANGRY_SLIME)
            {
                boostForEnemy = 15;

                this.goldGiven += boostForEnemy;
                this.starting_hp += boostForEnemy;
                this.attack += boostForEnemy;
                this.defense += boostForEnemy;
                this.speed += boostForEnemy;
            }
            else if (type == EnemyTypeEnum.BEE_SWARM)
            {
                boostForEnemy = 15;

                this.goldGiven += boostForEnemy;
                this.starting_hp += boostForEnemy;
                this.attack += boostForEnemy;
                this.defense += boostForEnemy;
                this.speed += boostForEnemy;
            }
            else if (type == EnemyTypeEnum.MECHA_NAPOLEON)
            {
                boostForEnemy = 25;

                this.goldGiven += boostForEnemy;
                this.starting_hp += boostForEnemy;
                this.attack += boostForEnemy;
                this.defense += boostForEnemy;
                this.speed += boostForEnemy;
            }
            else if (type == EnemyTypeEnum.BEE)
            {
                boostForEnemy = 0;

                this.goldGiven += boostForEnemy;
                this.starting_hp += boostForEnemy;
                this.attack += boostForEnemy;
                this.defense += boostForEnemy;
                this.speed += boostForEnemy;
            }
            else if (type == EnemyTypeEnum.BLUE_SLIME)
            {
                boostForEnemy = 5;

                this.goldGiven += boostForEnemy;
                this.starting_hp += boostForEnemy;
                this.attack += boostForEnemy;
                this.defense += boostForEnemy;
                this.speed += boostForEnemy;
            }
            else if (type == EnemyTypeEnum.GOBLIN)
            {
                boostForEnemy = 10;

                this.goldGiven += boostForEnemy;
                this.starting_hp += boostForEnemy;
                this.attack += boostForEnemy;
                this.defense += boostForEnemy;
                this.speed += boostForEnemy;
            }
            else if (type == EnemyTypeEnum.GREEN_SLIME)
            {
                boostForEnemy = 5;

                this.goldGiven += boostForEnemy;
                this.starting_hp += boostForEnemy;
                this.attack += boostForEnemy;
                this.defense += boostForEnemy;
                this.speed += boostForEnemy;
            }
            else if (type == EnemyTypeEnum.RED_SLIME)
            {
                boostForEnemy = 5;

                this.goldGiven += boostForEnemy;
                this.starting_hp += boostForEnemy;
                this.attack += boostForEnemy;
                this.defense += boostForEnemy;
                this.speed += boostForEnemy;
            }
            else if (type == EnemyTypeEnum.SKELETON)
            {
                boostForEnemy = 10;

                this.goldGiven += boostForEnemy;
                this.starting_hp += boostForEnemy;
                this.attack += boostForEnemy;
                this.defense += boostForEnemy;
                this.speed += boostForEnemy;
            }

            this.current_hp = this.starting_hp;
            this.current_sp = this.starting_sp;
        }
        public void addAttack(int amountAdded)
        {
            this.attack += amountAdded;
        }

        public void addDefense(int amountAdded)
        {
            this.defense += amountAdded;
        }

        public void addHp(int amountAdded)
        {
            this.current_hp += amountAdded;
        }

        public void addSp(int amountAdded)
        {
            this.current_sp += amountAdded;
        }

        public void addSpeed(int amountAdded)
        {
            this.speed += amountAdded;
        }

        public string displayStats()
        {
            return "HP: " + this.current_hp + "\nSP: " + this.current_sp + "\nAttack: " + attack + "\nDefense: " 
                + defense + "\nSpeed: " + speed + "\nGold Given: " + goldGiven;
        }

        public int getAttack()
        {
            return this.attack;
        }

        public int getCurrentHp()
        {
            return this.current_hp;
        }

        public int getDefense()
        {
            return this.defense;
        }

        public int getGoldGiven()
        {
            return this.goldGiven;
        }

        public int getCurrentSp()
        {
            return this.current_sp;
        }

        public int getSpeed()
        {
            return this.speed;
        }

        public int getMaxHp()
        {
            return this.starting_hp;
        }

        public int getMaxSp()
        {
            return this.starting_sp;
        }

        public void subtractAttack(int amountSubtracted)
        {
            this.attack -= amountSubtracted;
        }

        public void subtractDefense(int amountSubtracted)
        {
            this.defense -= amountSubtracted;
        }

        public void subtractHp(int amountSubtracted)
        {
            this.current_hp -= amountSubtracted;
            if (this.current_hp < 0)
                this.current_hp = 0;
        }

        public void subtractSp(int amountSubtracted)
        {
            this.current_sp -= amountSubtracted;
        }

        public void subtractSpeed(int amountSubtracted)
        {
            this.speed -= amountSubtracted;
        }

        public void setHpToMax()
        {
            this.current_hp = this.starting_hp;
        }

    }
}
