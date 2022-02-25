//---------------------------------------------------------------------
// Name:    Taryn Grohall & Robert Becker
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Stores information related to a battle
//---------------------------------------------------------------------
using GenericRPG2.Enemies;
using GenericRPG2.Items;
using GenericRPG2.Players;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericRPG2.UI
{
    //------------------------------------------------------------------
    // Store the data related to a battle.
    //------------------------------------------------------------------
    public class BattleData
   {
        protected const int SELECTION_NUMBER = 2;
        protected List<EnemyManager> enemyList;
        protected PlayerManager playerManager;
        protected Label[,] mainOptions;
        protected PictureBox[] enemyPictures;
        protected int[,] selection;
        protected int positionX;
        protected int positionY;
        protected BattleForm battleForm;
        protected int selectedMainOptionX;
        protected int selectedMainOptionY;
        protected Dictionary<Item, int> usableItems;

        protected int playerAttackDamage;
        protected int enemy1AttackDamage;
        protected int enemy2AttackDamage;
        protected int enemy3AttackDamage;
        protected int itemLocation;
        protected int selectedEnemyIndex;

        protected bool attackSelected;

        public BattleData(PlayerManager playerManager, List<EnemyManager> enemyList, BattleForm battleForm)
        {
            this.mainOptions = new Label[SELECTION_NUMBER, SELECTION_NUMBER];
            this.selection = new int[SELECTION_NUMBER, SELECTION_NUMBER];
            this.enemyPictures = new PictureBox[enemyList.Count];
            this.playerManager = playerManager;
            this.enemyList = enemyList;
            this.positionX = 0;
            this.positionY = 0;
            this.selectedMainOptionX = -1;
            this.selectedMainOptionY = -1;

            this.playerAttackDamage = 0;
            this.enemy1AttackDamage = 0;
            this.enemy2AttackDamage = 0;
            this.enemy3AttackDamage = 0;
            this.itemLocation = 0;

            this.attackSelected = false;
            this.selectedEnemyIndex = 0;

            this.battleForm = battleForm;

            for (int i = 0; i < SELECTION_NUMBER; i++)
            {
                for (int j = 0; j < SELECTION_NUMBER; j++)
                { 
                    mainOptions[i, j] = new Label();
                    selection[i, j] = i;
                }

            }

            usableItems = playerManager.getPlayer().getInventoryManager().getUsableItems();

            initializeMainOptions();
            initializeEnemyPictures();
        }

        //---------------------------------------------------------------
        // Initializes the labels that display the options the player
        // can choose.
        //---------------------------------------------------------------
        public void initializeMainOptions()
        {
            mainOptions[0, 0] = this.battleForm.getAttackLabel();

            mainOptions[1, 0] = this.battleForm.getItemLabel();

            mainOptions[0, 1] = this.battleForm.getSkillLabel();

            mainOptions[1, 1] = this.battleForm.getFleeLabel();
        }

        //---------------------------------------------------------------
        // Initializes the picture boxes that display the enemies in
        // the battle.
        //---------------------------------------------------------------
        public void initializeEnemyPictures()
        {
            if(enemyList.Count == 1)
            {
                enemyPictures[0] = this.battleForm.getEnemy1PictureBox();
            }
            else if(enemyList.Count == 2)
            {
                enemyPictures[0] = this.battleForm.getEnemy1PictureBox();
                enemyPictures[1] = this.battleForm.getEnemy2PictureBox();
            }
            else if(enemyList.Count == 3)
            {
                enemyPictures[0] = this.battleForm.getEnemy1PictureBox();
                enemyPictures[1] = this.battleForm.getEnemy2PictureBox();
                enemyPictures[2] = this.battleForm.getEnemy3PictureBox();
            }
            
        }

        public PlayerManager getPlayerManager()
        {
            return playerManager;
        }

        public List<EnemyManager> getEnemyList()
        {
            return enemyList;
        }

        public Label[,] getMainOptions()
        {
            return this.mainOptions;
        }

        public PictureBox[] getEnemyPictures()
        {
            return this.enemyPictures;
        }

        public int[,] getSelection()
        {
            return this.selection;
        }

        public int getPositionX()
        {
            return this.positionX;
        }

        public void setPositionX(int positionX)
        {
            this.positionX = positionX;
        }

        public int getPositionY()
        {
            return this.positionY;
        }
        public void setPositionY(int positionY)
        {
            this.positionY = positionY;
        }

        public void setSelectedMainOptionX(int selectedMainOption)
        {
            this.selectedMainOptionX = selectedMainOption;
        }

        public void setSelectedMainOptionY(int selectedMainOption)
        {
            this.selectedMainOptionY = selectedMainOption;
        }

        public int getSelectedMainOptionX()
        {
            return this.selectedMainOptionX;
        }

        public int getSelectedMainOptionY()
        {
            return this.selectedMainOptionY;
        }

        //---------------------------------------------------------------
        // Resets the selected positions of the options.
        //---------------------------------------------------------------
        public void resetSelectedMainOptions()
        {
            this.selectedMainOptionX = -1;
            this.selectedMainOptionY = -1;
        }

        public void setPlayerAttackDamage(int playerAttackDamage)
        {
            this.playerAttackDamage = playerAttackDamage;
        }

        public int getPlayerAttackDamage()
        {
            return this.playerAttackDamage;
        }

        public void setEnemy1AttackDamage(int enemyAttackDamage)
        {
            this.enemy1AttackDamage = enemyAttackDamage;
        }

        public int getEnemy1AttackDamage()
        {
            return this.enemy1AttackDamage;
        }

        public void setEnemy2AttackDamage(int enemyAttackDamage)
        {
            this.enemy2AttackDamage = enemyAttackDamage;
        }

        public int getEnemy2AttackDamage()
        {
            return this.enemy2AttackDamage;
        }

        public void setEnemy3AttackDamage(int enemyAttackDamage)
        {
            this.enemy3AttackDamage = enemyAttackDamage;
        }

        public int getEnemy3AttackDamage()
        {
            return this.enemy3AttackDamage;
        }

        public void setItemLocation(int itemLocation)
        {
            this.itemLocation = itemLocation;
        }

        public int getItemLocation()
        {
            return this.itemLocation;
        }

        public void setUsableItems(Item key, int value)
        {
            this.usableItems.Add(key, value);
        }

        public Dictionary<Item, int> getUsableItems()
        {
            return this.usableItems;
        }

        public void setAttackSelected(bool attackSelected)
        {
            this.attackSelected = attackSelected;
        }

        public bool getAttackSelected()
        {
            return this.attackSelected;
        }

        public int getSelectedEnemyIndex()
        {
            return this.selectedEnemyIndex;
        }

        public void setSelectedEnemyIndex(int selectedEnemyIndex)
        {
            this.selectedEnemyIndex = selectedEnemyIndex;
        }
    }
}
