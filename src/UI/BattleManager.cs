//---------------------------------------------------------------------
// Name:    Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Manages the flow of a battle
//---------------------------------------------------------------------
using GenericRPG2.Enemies;
using GenericRPG2.Items;
using GenericRPG2.Players;
using GenericRPG2.UI.Overworld;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericRPG2.UI
{
    //---------------------------------------------------------------------
    // Manages the flow of a battle and handles the logic.
    //---------------------------------------------------------------------
    public class BattleManager
    {
        private OverworldManager overworldManager;

        protected BattleData battleData;
        protected BattleForm battleForm;
        protected ListBox itemList;

        public BattleManager(OverworldManager overworldManager, PlayerManager playerManager, List<EnemyManager> enemyList, BattleForm battleForm)
        {
            this.overworldManager = overworldManager;
            this.itemList = battleForm.getItemList();
            this.battleForm = battleForm;

            battleData = new BattleData(playerManager, enemyList, battleForm);

            battleData.resetSelectedMainOptions();

            int selectionX = battleData.getPositionX();
            int selectionY = battleData.getPositionY();

            battleData.getMainOptions()[selectionY, selectionX].BackColor = Color.LightBlue;
            battleForm.getHPLabel().Text = "HP: " + battleData.getPlayerManager().getPlayer().getPlayerStats().getCurrentHp().ToString();
            battleForm.getSPLabel().Text = "SP: " + battleData.getPlayerManager().getPlayer().getPlayerStats().getCurrentSp().ToString();

            battleForm.getEnemy1PictureBox().Image = battleData.getEnemyList()[0].getEnemy().getEnemySprite().Image;
            battleForm.getEnemy1HealthBar().Visible = true;
            battleForm.getEnemy1HealthBar().Maximum = enemyList[0].getEnemy().getEnemyStats().getCurrentHp();
            battleForm.getEnemy1HealthBar().Value = battleForm.getEnemy1HealthBar().Maximum;
            battleForm.getEnemy1HealthBar().ForeColor = Color.Lime;
            if (battleData.getEnemyList().Count == 2)
            {
                battleForm.getEnemy2PictureBox().Image = battleData.getEnemyList()[1].getEnemy().getEnemySprite().Image;
                battleForm.getEnemy2HealthBar().Visible = true;
                battleForm.getEnemy2HealthBar().Maximum = enemyList[1].getEnemy().getEnemyStats().getCurrentHp();
                battleForm.getEnemy2HealthBar().Value = battleForm.getEnemy2HealthBar().Maximum;
                battleForm.getEnemy2HealthBar().ForeColor = Color.Lime;
            }
            else if (battleData.getEnemyList().Count == 3)
            {
                battleForm.getEnemy2PictureBox().Image = battleData.getEnemyList()[1].getEnemy().getEnemySprite().Image;
                battleForm.getEnemy2HealthBar().Visible = true;
                battleForm.getEnemy2HealthBar().Maximum = enemyList[1].getEnemy().getEnemyStats().getCurrentHp();
                battleForm.getEnemy2HealthBar().Value = battleForm.getEnemy2HealthBar().Maximum;
                battleForm.getEnemy2HealthBar().ForeColor = Color.Lime;
                battleForm.getEnemy3PictureBox().Image = battleData.getEnemyList()[2].getEnemy().getEnemySprite().Image;
                battleForm.getEnemy3HealthBar().Visible = true;
                battleForm.getEnemy3HealthBar().Maximum = enemyList[2].getEnemy().getEnemyStats().getCurrentHp();
                battleForm.getEnemy3HealthBar().Value = battleForm.getEnemy3HealthBar().Maximum;
                battleForm.getEnemy3HealthBar().ForeColor = Color.Lime;
            }
        }

        //---------------------------------------------------------------------
        // Chooses how to proceed from the option the player selected.
        //---------------------------------------------------------------------
        public void playerTurn()
        {
            if (battleData.getSelectedMainOptionY() == 0 && battleData.getSelectedMainOptionX() == 0)
            {
                //Attack
                battleData.setSelectedEnemyIndex(0);
                highlightEnemies();
                battleData.setAttackSelected(true);
            }
            else if (battleData.getSelectedMainOptionY() == 0 && battleData.getSelectedMainOptionX() == 1)
            {
                //Item
                battleData.setItemLocation(0);
                displayItemList();
                if (battleForm.getItemList().Items.Count > 0)
                    battleForm.getItemList().SelectedIndex = 0;
            }
            else if (battleData.getSelectedMainOptionY() == 1 && battleData.getSelectedMainOptionX() == 0)
            {
                //Skill
            }
            else if (battleData.getSelectedMainOptionY() == 1 && battleData.getSelectedMainOptionX() == 1)
            {
                //Flee
                battleForm.Close();
                overworldManager.getOverworldForm().Show();
            }
        }

        //---------------------------------------------------------------------
        // Calculates the damage the player will do.
        //---------------------------------------------------------------------
        public int calculatePlayerAttackDamage()
        {
            battleData.setPlayerAttackDamage((int)(((battleData.getPlayerManager().getPlayer().getPlayerStats().getAttack()
                / Math.Log(battleData.getEnemyList()[battleData.getSelectedEnemyIndex()].getEnemy().getEnemyStats().getDefense())) + 1)));

            return battleData.getPlayerAttackDamage();
        }

        //---------------------------------------------------------------------
        // Chooses what the enemy will do, currently calculates damage.
        //---------------------------------------------------------------------
        public void enemyTurn()
        {
            if (battleData.getEnemyList().Count > 0)
                battleData.setEnemy1AttackDamage((int)(((battleData.getEnemyList()[0].getEnemy().getEnemyStats().getAttack()
                    / Math.Log(battleData.getPlayerManager().getPlayer().getPlayerStats().getDefense())) + 1)));

            if (battleData.getEnemyList().Count >= 2)
            {
                battleData.setEnemy2AttackDamage((int)(((battleData.getEnemyList()[1].getEnemy().getEnemyStats().getAttack()
                    / Math.Log(battleData.getPlayerManager().getPlayer().getPlayerStats().getDefense())) + 1)));
            }
            if (battleData.getEnemyList().Count >= 3)
            {
                battleData.setEnemy3AttackDamage((int)(((battleData.getEnemyList()[2].getEnemy().getEnemyStats().getAttack()
                    / Math.Log(battleData.getPlayerManager().getPlayer().getPlayerStats().getDefense())) + 1)));
            }
        }

        //---------------------------------------------------------------------
        // Finalizes the turn in battle, updating health and choosing what to
        // display.
        //---------------------------------------------------------------------
        public void outcomeOfTurn()
        {
            int playerAccuracy = (int)(101 - battleData.getEnemyList()[battleData.getSelectedEnemyIndex()].getEnemy().getEnemyStats().getSpeed()
                / Math.Log(battleData.getPlayerManager().getPlayer().getPlayerStats().getSpeed()));
            Random rng = new Random();
            int playerDamageCheck = rng.Next(1, 101);

            if (playerDamageCheck <= playerAccuracy) 
            {
                battleData.getEnemyList()[battleData.getSelectedEnemyIndex()].getEnemy().getEnemyStats().subtractHp(battleData.getPlayerAttackDamage());
                battleForm.getBattleMsgLabel().Text = "You Dealt " + battleData.getPlayerAttackDamage() + " to enemy " + (battleData.getSelectedEnemyIndex() + 1) + "!";
                battleForm.getBattleMsgLabel().Refresh();
                switch (battleData.getSelectedEnemyIndex())
                {
                    case 0:
                        Animator.animateHealthBar(battleForm.getEnemy1HealthBar(), 0.5, battleData.getEnemyList()[battleData.getSelectedEnemyIndex()].getEnemy().getEnemyStats().getCurrentHp());
                        break;
                    case 1:
                        Animator.animateHealthBar(battleForm.getEnemy2HealthBar(), 0.5, battleData.getEnemyList()[battleData.getSelectedEnemyIndex()].getEnemy().getEnemyStats().getCurrentHp());
                        break;
                    case 2:
                        Animator.animateHealthBar(battleForm.getEnemy3HealthBar(), 0.5, battleData.getEnemyList()[battleData.getSelectedEnemyIndex()].getEnemy().getEnemyStats().getCurrentHp());
                        break;
                }
            }
            else
            {
                battleForm.getBattleMsgLabel().Text = "You missed!";
            }
            int enemyAccuracy = (int)(101 - battleData.getPlayerManager().getPlayer().getPlayerStats().getSpeed()
                / Math.Log(battleData.getEnemyList()[0].getEnemy().getEnemyStats().getSpeed()));
            int enemyDamageCheck = rng.Next(1, 101);
            if (battleData.getEnemyList()[0].getEnemy().getEnemyStats().getCurrentHp() > 0) {
                if (enemyDamageCheck <= enemyAccuracy)
                {
                    battleData.getPlayerManager().getPlayer().getPlayerStats().subtractHp(battleData.getEnemy1AttackDamage());
                    battleForm.getBattleMsgLabel().Text = battleForm.getBattleMsgLabel().Text + "\nEnemy 1 Dealt " + battleData.getEnemy1AttackDamage() + " to you!";
                }
                else
                {
                    battleForm.getBattleMsgLabel().Text = battleForm.getBattleMsgLabel().Text + "\nEnemy 1 missed!";
                }
            }
            if (battleData.getEnemyList().Count >= 2)
            {
                if (battleData.getEnemyList()[1].getEnemy().getEnemyStats().getCurrentHp() > 0) {
                    enemyAccuracy = (int)(101 - battleData.getPlayerManager().getPlayer().getPlayerStats().getSpeed()
                        / Math.Log(battleData.getEnemyList()[1].getEnemy().getEnemyStats().getSpeed()));
                    enemyDamageCheck = rng.Next(1, 101);
                    if (enemyDamageCheck <= enemyAccuracy)
                    {
                        battleData.getPlayerManager().getPlayer().getPlayerStats().subtractHp(battleData.getEnemy2AttackDamage());
                        battleForm.getBattleMsgLabel().Text = battleForm.getBattleMsgLabel().Text + "\nEnemy 2 Dealt " + battleData.getEnemy2AttackDamage() + " to you!";
                    }
                    else
                    {
                        battleForm.getBattleMsgLabel().Text = battleForm.getBattleMsgLabel().Text + "\nEnemy 2 missed!";
                    }
                }
            }

            if (battleData.getEnemyList().Count >= 3)
            {
                if (battleData.getEnemyList()[2].getEnemy().getEnemyStats().getCurrentHp() > 0)
                {
                    enemyAccuracy = (int)(101 - battleData.getPlayerManager().getPlayer().getPlayerStats().getSpeed()
                        / Math.Log(battleData.getEnemyList()[2].getEnemy().getEnemyStats().getSpeed()));
                    enemyDamageCheck = rng.Next(1, 101);
                    if (enemyDamageCheck <= enemyAccuracy)
                    {
                        battleData.getPlayerManager().getPlayer().getPlayerStats().subtractHp(battleData.getEnemy3AttackDamage());
                        battleForm.getBattleMsgLabel().Text = battleForm.getBattleMsgLabel().Text + "\nEnemy 3 Dealt " + battleData.getEnemy3AttackDamage() + " to you!";
                    }
                    else
                    {
                        battleForm.getBattleMsgLabel().Text = battleForm.getBattleMsgLabel().Text + "\nEnemy 3 missed!";
                    }
                }
            }

            battleForm.getHPLabel().Text = "HP: " + battleData.getPlayerManager().getPlayer().getPlayerStats().getCurrentHp().ToString();
            battleForm.getSPLabel().Text = "SP: " + battleData.getPlayerManager().getPlayer().getPlayerStats().getCurrentSp().ToString();

            removeDeadEnemies();
            battleData.setEnemy1AttackDamage(0);
            battleData.setEnemy2AttackDamage(0);
            battleData.setEnemy3AttackDamage(0);
            battleData.setPlayerAttackDamage(0);

            if (battleData.getPlayerManager().getPlayer().getPlayerStats().getCurrentHp() <= 0)
                gameOver(false);

        }

        //---------------------------------------------------------------------
        // Removes all dead enemies and shifts their display.
        //---------------------------------------------------------------------
        public void removeDeadEnemies()
        {
            if (battleData.getEnemyList()[0].getEnemy().getEnemyStats().getCurrentHp() <= 0)
            {
                battleData.getPlayerManager().addExperience(EnemyData.experienceValues.GetValueOrDefault(battleData.getEnemyList()[0].getEnemy().getEnemyType()), battleForm.getBattleMsgLabel());
                if (battleData.getEnemyList().Count > 1 && battleData.getEnemyList()[1].getEnemy().getEnemyStats().getCurrentHp() > 0)
                {
                    battleForm.getEnemy1PictureBox().Image = battleForm.getEnemy2PictureBox().Image;
                    battleForm.getEnemy1HealthBar().Maximum = battleForm.getEnemy2HealthBar().Maximum;
                    battleForm.getEnemy1HealthBar().Value = battleForm.getEnemy2HealthBar().Value;
                    battleForm.getEnemy1HealthBar().ForeColor = battleForm.getEnemy2HealthBar().ForeColor;
                    if (battleData.getEnemyList().Count > 2 && battleData.getEnemyList()[2].getEnemy().getEnemyStats().getCurrentHp() > 0)
                    {
                        battleForm.getEnemy2PictureBox().Image = battleForm.getEnemy3PictureBox().Image;
                        battleForm.getEnemy2HealthBar().Maximum = battleForm.getEnemy3HealthBar().Maximum;
                        battleForm.getEnemy2HealthBar().Value = battleForm.getEnemy3HealthBar().Value;
                        battleForm.getEnemy2HealthBar().ForeColor = battleForm.getEnemy3HealthBar().ForeColor;
                        battleForm.getEnemy3PictureBox().Visible = false;
                        battleForm.getEnemy3HealthBar().Visible = false;
                    }
                    else
                    {
                        battleForm.getEnemy2PictureBox().Visible = false;
                        battleForm.getEnemy2HealthBar().Visible = false;
                    }
                }
            }
            else if (battleData.getEnemyList().Count > 1 && battleData.getEnemyList()[1].getEnemy().getEnemyStats().getCurrentHp() <= 0)
            {
                battleData.getPlayerManager().addExperience(EnemyData.experienceValues.GetValueOrDefault(battleData.getEnemyList()[1].getEnemy().getEnemyType()), battleForm.getBattleMsgLabel());
                if (battleData.getEnemyList().Count > 2 && battleData.getEnemyList()[2].getEnemy().getEnemyStats().getCurrentHp() > 0)
                {
                    battleForm.getEnemy2PictureBox().Image = battleForm.getEnemy3PictureBox().Image;
                    battleForm.getEnemy2HealthBar().Maximum = battleForm.getEnemy3HealthBar().Maximum;
                    battleForm.getEnemy2HealthBar().Value = battleForm.getEnemy3HealthBar().Value;
                    battleForm.getEnemy2HealthBar().ForeColor = battleForm.getEnemy3HealthBar().ForeColor;
                    battleForm.getEnemy3PictureBox().Visible = false;
                    battleForm.getEnemy3HealthBar().Visible = false;
                }
                else
                {
                    battleForm.getEnemy2PictureBox().Visible = false;
                    battleForm.getEnemy2HealthBar().Visible = false;
                }
            }
            else if (battleData.getEnemyList().Count > 2 && battleData.getEnemyList()[2].getEnemy().getEnemyStats().getCurrentHp() <= 0)
            {
                battleData.getPlayerManager().addExperience(EnemyData.experienceValues.GetValueOrDefault(battleData.getEnemyList()[2].getEnemy().getEnemyType()), battleForm.getBattleMsgLabel());
                battleForm.getEnemy3PictureBox().Visible = false;
                battleForm.getEnemy3HealthBar().Visible = false;
            }
            battleForm.getHPLabel().Text = "HP: " + battleData.getPlayerManager().getPlayer().getPlayerStats().getCurrentHp();
            battleForm.getSPLabel().Text = "SP: " + battleData.getPlayerManager().getPlayer().getPlayerStats().getCurrentSp();

            for (int i = 0; i < battleData.getEnemyList().Count; i++)
                if (battleData.getEnemyList()[i].getEnemy().getEnemyStats().getCurrentHp() <= 0)
                {
                    if (battleData.getEnemyList()[i].getEnemy().getEnemyType() != CharacterClass.EnemyTypeEnum.MECHA_NAPOLEON)
                        battleData.getEnemyList().RemoveAt(i);
                    else
                        gameOver(true);
                }

            if (battleData.getEnemyList().Count == 0)
                endBattle();
        }
        
        //---------------------------------------------------------------------
        // What happens when the player's HP drops to zero or below.
        //---------------------------------------------------------------------
        public void gameOver(bool hasWon)
        {
            GameOverForm form = new GameOverForm(hasWon);
            battleForm.Hide();
            battleForm.Close();
            form.ShowDialog();
            
        }

        //---------------------------------------------------------------------
        // Ends the battle when all enemies are defeated and rewards the player.
        //---------------------------------------------------------------------
        public void endBattle()
        {
            battleData.getPlayerManager().getPlayer().getPlayerStats().addGold(100);
            battleForm.Close();
            overworldManager.getOverworldForm().Show();
        }

        //---------------------------------------------------------------
        // Highlights the labels that contain option names when the user
        // is currently "selecting" that option
        //---------------------------------------------------------------
        public void highlightMainOptions()
        {
            clearOptionHighlights();

            int selectionX = battleData.getPositionX();
            int selectionY = battleData.getPositionY();

            battleData.getMainOptions()[selectionX, selectionY].BackColor = Color.LightBlue;
        }

        //---------------------------------------------------------------
        // Clears the highlights on the labels that contain players options
        //---------------------------------------------------------------
        public void clearOptionHighlights()
        {
            for (int i = 0; i < battleData.getMainOptions().GetLength(0); i++)
            {
                for (int j = 0; j < battleData.getMainOptions().GetLength(1); j++)
                {
                    battleData.getMainOptions()[i, j].BackColor = Color.White;
                }
            }
        }

        //---------------------------------------------------------------
        // Highlights the picture boxes for the enimies
        //---------------------------------------------------------------
        public void highlightEnemies()
        {
            clearEnemyHighlights();

            int selection = battleData.getSelectedEnemyIndex();

            battleData.getEnemyPictures()[selection].BackColor = Color.LightBlue;
        }

        //---------------------------------------------------------------
        // Clears the highlights on the enemy picture boxes
        //---------------------------------------------------------------
        public void clearEnemyHighlights()
        {
            for (int i = 0; i < battleData.getEnemyPictures().Length; i++)
            {
                battleData.getEnemyPictures()[i].BackColor = Color.Transparent;
            }
        }

        //---------------------------------------------------------------
        // Manages the input from the user
        //---------------------------------------------------------------
        public void manageInput(object sender, KeyEventArgs e)
        {
            int positionX = battleData.getPositionX();
            int positionY = battleData.getPositionY();

            // Handles input for selecting the enemy to attack
            if (battleData.getAttackSelected())
            {
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    if (battleData.getSelectedEnemyIndex() > 0)
                    {
                        battleData.setSelectedEnemyIndex(battleData.getSelectedEnemyIndex() - 1);
                    }
                    else if (battleData.getSelectedEnemyIndex() == 0)
                    {
                        battleData.setSelectedEnemyIndex(0);
                    }
                    highlightEnemies();
                }
                else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    if (battleData.getEnemyList().Count == 1)
                    {
                        battleData.setSelectedEnemyIndex(0);
                    }
                    else if (battleData.getSelectedEnemyIndex() < battleData.getEnemyList().Count - 1)
                    {
                        battleData.setSelectedEnemyIndex(battleData.getSelectedEnemyIndex() + 1);
                    }
                    else if (battleData.getSelectedEnemyIndex() >= battleData.getEnemyList().Count)
                    {
                        battleData.setSelectedEnemyIndex(battleData.getEnemyList().Count - 1);
                    }

                    highlightEnemies();
                }
                else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Z)
                {
                    clearEnemyHighlights();
                    calculatePlayerAttackDamage();
                    battleData.setAttackSelected(false);
                    enemyTurn();
                    outcomeOfTurn();
                }
                else if (e.KeyCode == Keys.X || e.KeyCode == Keys.Back)
                {
                    clearEnemyHighlights();
                    battleData.setAttackSelected(false);
                }
            }
            // Handles input for the main 4 options
            else if (battleForm.getItemList().Items.Count == 0)
            {
                if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    if (positionY < battleData.getSelection().GetLength(0) - 1)
                    {
                        battleData.setPositionY(positionY + 1);
                        highlightMainOptions();
                    }
                }
                else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    if (positionY > 0)
                    {
                        battleData.setPositionY(positionY - 1);
                        highlightMainOptions();
                    }
                }
                else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    if (positionX > 0)
                    {
                        battleData.setPositionX(positionX - 1);
                        highlightMainOptions();
                    }
                }
                else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    if (positionX < battleData.getSelection().GetLength(1) - 1)
                    {
                        battleData.setPositionX(positionX + 1);
                        highlightMainOptions();
                    }
                }
                else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Z)
                {
                    battleData.setSelectedMainOptionX(positionX);
                    battleData.setSelectedMainOptionY(positionY);
                    playerTurn();
                }
            }
            // Handles input for using items
            else
            {
                if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    if (battleData.getItemLocation() < battleData.getPlayerManager().getPlayer().getInventoryManager().getUsableItems().Count)
                    {
                        battleData.setItemLocation(battleData.getItemLocation() + 1);
                    }
                }
                else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    if (battleData.getItemLocation() >= 0)
                    {
                        battleData.setItemLocation(battleData.getItemLocation() - 1);
                    }
                }
                else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Z)
                {
                    Item selectedItem = getEntryAtIndex(battleData.getItemLocation()).Key;

                    if (battleData.getPlayerManager().isUsable(selectedItem) && battleData.getPlayerManager().shouldUse(selectedItem))
                    {
                        battleData.getPlayerManager().useItem(selectedItem);
                        displayItemList();

                        battleForm.getBattleMsgLabel().Text = "Used " + selectedItem.getItemName();
                    }
                    // checks it the item will boost past max stats
                    else if (!battleData.getPlayerManager().shouldUse(selectedItem))
                    {
                        if (battleData.getPlayerManager().getPlayer().getPlayerStats().getCurrentHp() ==
                            battleData.getPlayerManager().getPlayer().getPlayerStats().getMaxHp())
                        {
                            battleForm.getBattleMsgLabel().Text = "Cannot use " + selectedItem.getItemName()
                              + ": HP is full";
                        }
                        else if (battleData.getPlayerManager().getPlayer().getPlayerStats().getCurrentSp() ==
                             battleData.getPlayerManager().getPlayer().getPlayerStats().getMaxSp())
                        {
                            battleForm.getBattleMsgLabel().Text = "Cannot use " + selectedItem.getItemName()
                                + ": SP is full";
                        }
                    }

                    itemList.Items.Clear();
                    enemyTurn();
                    outcomeOfTurn();
                }
                else if (e.KeyCode == Keys.X || e.KeyCode == Keys.Back)
                {
                    itemList.Items.Clear();
                }
            }
        }

        //---------------------------------------------------------------
        // Adds the shop inventory from shop data to the list box
        //---------------------------------------------------------------
        public void displayItemList()
        {
            itemList.Items.Clear();
            foreach (KeyValuePair<Item, int> entry in battleData.getPlayerManager().getPlayer().getInventoryManager().getUsableItems())
                itemList.Items.Add(string.Format("*" + entry.Value + "x\t" + entry.Key));
        }

        //--------------------------------------------------------
        // Since we are using a dictionary, this finds the entry
        // at a given index, to give linked list list properties
        //--------------------------------------------------------
        public KeyValuePair<Item, int> getEntryAtIndex(int index)
        {
            KeyValuePair<Item, int> output = battleData.getPlayerManager().getPlayer().getInventoryManager().getUsableItems().FirstOrDefault();
            int i = 0;

            foreach (KeyValuePair<Item, int> entry in battleData.getPlayerManager().getPlayer().getInventoryManager().getUsableItems())
            {
                if (i <= index)
                    output = entry;
                i++;
            }

            return output;
        }

        public BattleData getBattleData()
        {
            return this.battleData;
        }
    }
}