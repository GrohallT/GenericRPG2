//---------------------------------------------------------------------
// Name:    Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Stores the stats of the player
//---------------------------------------------------------------------

using GenericRPG2.CharacterClass;
using System;

namespace GenericRPG2.Stats
{
    //-------------------------------------------------------------------    
    // Store the stats of the player    
    //-------------------------------------------------------------------
    public class PlayerStats : IStats
    {
        private const int KNIGHT_STARTING_HP = 20;
        private const int KNIGHT_STARTING_SP = 20;
        private const int KNIGHT_STARTING_ATTACK = 20;
        private const int KNIGHT_STARTING_DEFENSE = 100;
        private const int KNIGHT_STARTING_SPEED = 20;

        private const int ARCHER_STARTING_HP = 20;
        private const int ARCHER_STARTING_SP = 20;
        private const int ARCHER_STARTING_ATTACK = 100;
        private const int ARCHER_STARTING_DEFENSE = 20;
        private const int ARCHER_STARTING_SPEED = 20;

        private const int MAGE_STARTING_HP = 20;
        private const int MAGE_STARTING_SP = 100;
        private const int MAGE_STARTING_ATTACK = 20;
        private const int MAGE_STARTING_DEFENSE = 20;
        private const int MAGE_STARTING_SPEED = 20;

        private const int THIEF_STARTING_HP = 20;
        private const int THIEF_STARTING_SP = 20;
        private const int THIEF_STARTING_ATTACK = 20;
        private const int THIEF_STARTING_DEFENSE = 20;
        private const int THIEF_STARTING_SPEED = 100;

        private const int STARTING_LEVEL = 1;
        private const int STARTING_GOLD = 1000;

        private int hp;
        private int maxHp;
        private int maxSp;
        private int sp;
        private int level;
        private int attack;
        private int defense;
        private int speed;
        private int gold;
        private int experience;
        private int currentLevelExperience;
        private int expToNextLevel;

        private CharacterClassEnum characterClassEnum;

        public PlayerStats(CharacterClassEnum characterClassEnum)
        {
            if (characterClassEnum == CharacterClassEnum.KNIGHT) 
            {
                createKnightStats();
            }
            else if(characterClassEnum == CharacterClassEnum.ARCHER)
            {
                createArcherStats();
            }
            else if (characterClassEnum == CharacterClassEnum.MAGE)
            {
                createMageStats();
            }
            else if (characterClassEnum == CharacterClassEnum.THIEF)
            {
                createThiefStats();
            }

            this.experience = 0;
            this.currentLevelExperience = 0;
            this.characterClassEnum = characterClassEnum;
            this.setExpToNextLevel();
        }

        //-------------------------------------------------------------------    
        // Sets the users stats to the starting stats of the knight   
        //-------------------------------------------------------------------
        private void createKnightStats()
        {
            hp = KNIGHT_STARTING_HP;
            maxHp = KNIGHT_STARTING_HP;
            sp = KNIGHT_STARTING_SP;
            maxSp = KNIGHT_STARTING_SP;
            level = STARTING_LEVEL;
            attack = KNIGHT_STARTING_ATTACK;
            defense = KNIGHT_STARTING_DEFENSE;
            speed = KNIGHT_STARTING_SPEED;
            gold = STARTING_GOLD;
        }

        //-------------------------------------------------------------------    
        // Sets the users stats to the starting stats of the archer   
        //-------------------------------------------------------------------
        private void createArcherStats()
        {
            hp = ARCHER_STARTING_HP;
            maxHp = ARCHER_STARTING_HP;
            sp = ARCHER_STARTING_SP;
            maxSp = ARCHER_STARTING_SP;
            level = STARTING_LEVEL;
            attack = ARCHER_STARTING_ATTACK;
            defense = ARCHER_STARTING_DEFENSE;
            speed = ARCHER_STARTING_SPEED;
            gold = STARTING_GOLD;
        }

        //-------------------------------------------------------------------    
        // Sets the users stats to the starting stats of the mage   
        //-------------------------------------------------------------------
        private void createMageStats()
        {
            hp = MAGE_STARTING_HP;
            maxHp = MAGE_STARTING_HP;
            sp = MAGE_STARTING_SP;
            maxSp = MAGE_STARTING_SP;
            level = STARTING_LEVEL;
            attack = MAGE_STARTING_ATTACK;
            defense = MAGE_STARTING_DEFENSE;
            speed = MAGE_STARTING_SPEED;
            gold = STARTING_GOLD;
        }

        //-------------------------------------------------------------------    
        // Sets the users stats to the starting stats of the thief   
        //-------------------------------------------------------------------
        private void createThiefStats()
        {
            hp = THIEF_STARTING_HP;
            maxHp = THIEF_STARTING_HP;
            sp = THIEF_STARTING_SP;
            maxSp = THIEF_STARTING_SP;
            level = STARTING_LEVEL;
            attack = THIEF_STARTING_ATTACK;
            defense = THIEF_STARTING_DEFENSE;
            speed = THIEF_STARTING_SPEED;
            gold = STARTING_GOLD;
        }

        //-------------------------------------------------------------------    
        // Displays the player's stats in a top down list, used in overworld
        // display of the stats
        //-------------------------------------------------------------------
        public string displayStats()
        {
            return "HP: " + hp + "\nSP: " + sp + "\nLevel: " + level + "\nAttack: " + attack + "\nDefense: " + defense + "\nSpeed: " + speed + "\nGold: " + gold;
        }

        public int getExperience()
        {
            return experience;
        }

        public int getCurrentLevelExperience()
        {
            return currentLevelExperience;

        }

        public void setCurrentLevelExperience(int currentLevelExperience)
        {
            this.currentLevelExperience = currentLevelExperience;

        }

        public void addExperience(int increase)
        {
            this.experience += increase;
            this.currentLevelExperience += increase;
        }

        public int getMaxHp()
        {
            return this.maxHp;
        }

        public int getMaxSp()
        {
            return this.maxSp;
        }

        public int getCurrentHp() 
        {
            return hp; 
        }

        public int getCurrentSp() 
        {
            return sp;
        }
        public int getLevel() 
        {
            return level; 
        }

        public int getAttack() 
        {
            return attack; 
        }

        public int getDefense() 
        { 
            return defense; 
        }

        public int getSpeed() 
        { 
            return speed; 
        }

        public int getGold() 
        { 
            return gold; 
        }

        public int getExpToNextLevel()
        {
            return expToNextLevel - currentLevelExperience;
        }

        public int getNextLevelExp()
        {
            return expToNextLevel;
        }

        //--------------------------------------------------------------
        // This method sets the amount of experience needed to level up
        // based on the formula y = 75 * x^1.5 / ln(x + 1) + 100, where
        // y is the amount of experience needed to level up and x is the
        // current level.
        //--------------------------------------------------------------
        public void setExpToNextLevel()
        {
            this.expToNextLevel = (int)(75 * Math.Pow(level, 1.5) / Math.Log(level + 1) + 100);

        }

        //-------------------------------------------------------------------    
        // AMOUNTADDED gets added to the users health stat   
        //-------------------------------------------------------------------
        public void addHp(int amountAdded) 
        {
            if (hp + amountAdded <= maxHp)
                hp += amountAdded;
            else
                hp = maxHp;
        }

        //-------------------------------------------------------------------    
        // AMOUNTSUBTRACTED gets subtracted to the users health stat   
        //-------------------------------------------------------------------
        public void subtractHp(int amountSubtracted) 
        {
            if (hp - amountSubtracted >= 0)
                hp -= amountSubtracted;
            else
                hp = 0;
        }

        public void setHpToMax()
        {
            hp = maxHp;
        }

        //-------------------------------------------------------------------    
        // AMOUNTADDED gets added to the users spell points stat   
        //-------------------------------------------------------------------
        public void addSp(int amountAdded) 
        {
            if (sp + amountAdded <= maxSp)
                sp += amountAdded;
            else
                sp = maxSp;
        }
        //-------------------------------------------------------------------    
        // AMOUNTSUBTRACTED gets subtracted to the users spell points stat   
        //-------------------------------------------------------------------
        public void subtractSp(int amountSubtracted) 
        {
            if (sp - amountSubtracted >= 0)
                sp -= amountSubtracted;
            else
                sp = 0;
        }

        //-------------------------------------------------------------------    
        // AMOUNTADDED gets added to the users level stat   
        //-------------------------------------------------------------------
        public void addLevel(int amountAdded) 
        {
            level += amountAdded;
            currentLevelExperience -= expToNextLevel;
            if (currentLevelExperience < 0)
                currentLevelExperience = 0;
            setExpToNextLevel();
            this.maxHp += 2;
            this.hp += 2;
            this.attack += 1;
            this.defense += 1;
            this.sp += 1;
            this.maxSp += 1;
            this.speed += 1;
            switch (characterClassEnum)
            {
                case CharacterClassEnum.ARCHER:
                    this.attack += 2;
                    break;
                case CharacterClassEnum.KNIGHT:
                    this.defense += 2;
                    break;
                case CharacterClassEnum.MAGE:
                    this.sp += 2;
                    this.maxSp += 2;
                    break;
                case CharacterClassEnum.THIEF:
                    this.speed += 2;
                    break;
            }
        }

        //-------------------------------------------------------------------    
        // AMOUNTADDED gets added to the users attack stat   
        //-------------------------------------------------------------------
        public void addAttack(int amountAdded) 
        {
            attack += amountAdded;
        }
        //-------------------------------------------------------------------    
        // AMOUNTSUBTRACTED gets subtracted to the users attack stat   
        //-------------------------------------------------------------------
        public void subtractAttack(int amountSubtracted) 
        {
            attack -= amountSubtracted;
        }

        //-------------------------------------------------------------------    
        // AMOUNTADDED gets added to the users defense stat   
        //-------------------------------------------------------------------
        public void addDefense(int amountAdded) 
        {
            defense += amountAdded;
        }
        //-------------------------------------------------------------------    
        // AMOUNTSUBTRACTED gets subtracted to the users defense stat   
        //-------------------------------------------------------------------
        public void subtractDefense(int amountSubtracted) 
        {
            defense -= amountSubtracted;
        }

        //-------------------------------------------------------------------    
        // AMOUNTADDED gets added to the users speed stat   
        //-------------------------------------------------------------------
        public void addSpeed(int amountAdded) 
        {
            speed += amountAdded;
        }
        //-------------------------------------------------------------------    
        // AMOUNTSUBTRACTED gets subtracted to the users speed stat   
        //-------------------------------------------------------------------
        public void subtractSpeed(int amountSubtracted) 
        {
            speed -= amountSubtracted;
        }

        //-------------------------------------------------------------------    
        // AMOUNTADDED gets added to the users gold stat   
        //-------------------------------------------------------------------
        public void addGold(int amountAdded) 
        {
            gold += amountAdded;
        }
        //-------------------------------------------------------------------    
        // AMOUNTSUBTRACTED gets subtracted to the users gold stat   
        //-------------------------------------------------------------------
        public void subtractGold(int amountSubtracted) 
        {
            gold -= amountSubtracted;
        }
    }
}