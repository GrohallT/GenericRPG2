//---------------------------------------------------------------------
// Name:    Marshall Paider
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Runs the logic of the Inventory Form
//---------------------------------------------------------------------

using GenericRPG2.Items;
using GenericRPG2.Items.Potions.HealingPotions;
using GenericRPG2.Items.Potions.SpPotions;
using GenericRPG2.Players;
using GenericRPG2.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GenericRPG2.Inventory
{
    //------------------------------------------------------------------
    // Control the behavior of the Inventory Form
    //------------------------------------------------------------------
    public class InventoryFormManager
    {
        private PlayerManager playerManager; // the player that needs their inventory displayed
        private InventoryForm inventoryForm; // the form of the inventory
        private int location; // the location of where the selected index in the ListBox is
        private ListBox displayableInventory; // a displayable list of the inventory

        //--------------------------------------------------------------
        // Constructor to create the Manager
        //--------------------------------------------------------------
        public InventoryFormManager(PlayerManager playerManager, InventoryForm form)
        {
            this.playerManager = playerManager;
            this.displayableInventory = form.getInventoryDisplay();
            this.inventoryForm = form;

            this.location = 0;

            // updates the inventory display to the player's current stats
            updateInventoryDisplay();

            // Sets the progress bar to their current state
            setProgressBars();
        }

        //-------------------------------------------------------------
        // updates the form with new information
        //-------------------------------------------------------------
        public void updateInventoryDisplay()
        {
            // loop through map and add to listbox
            displayableInventory.Items.Clear();
            foreach (KeyValuePair<Item, int> entry in playerManager.getPlayer().getInventoryManager().getInventory())
            {
                if (playerManager.isEquipped(entry.Key))
                    displayableInventory.Items.Add(string.Format("*" + entry.Value + "x\t" + entry.Key));
                else
                    displayableInventory.Items.Add(string.Format("  " + entry.Value + "x\t" + entry.Key));
            }

            // only sets the selected index of the ListBox if there is an element in the list
            if (playerManager.getPlayer().getInventoryManager().getInventory().Count > 0)
                displayableInventory.SelectedIndex = location;

            inventoryForm.getEquipConfirm().Text = "";
            updateStatsDisplay();
            updateEquippedItems();
            updateItemDiscription();
        }

        public ListBox getDisplayableInventory()
        {
            return displayableInventory;
        }

        public int getLocation()
        {
            return location;
        }

        public PlayerManager getPlayerManager()
        {
            return playerManager;
        }

        //------------------------------------------------------------
        // Updates the labels on the form with the current status
        // of all the stats of the player
        //------------------------------------------------------------
        public void updateStatsDisplay()
        {
            inventoryForm.getAttackLabel().Text = "Attack: " + playerManager.getPlayer().getPlayerStats().getAttack();
            inventoryForm.getDefenseLabel().Text = "Defense: " + playerManager.getPlayer().getPlayerStats().getDefense();
            inventoryForm.getSpeedLabel().Text = "Speed: " + playerManager.getPlayer().getPlayerStats().getSpeed();
            inventoryForm.getPlayerLevel().Text = "Level: " + playerManager.getPlayer().getPlayerStats().getLevel();
            inventoryForm.getPlayerGoldLabel().Text = "Gold: " + playerManager.getPlayer().getPlayerStats().getGold();
            inventoryForm.getClassLabel().Text = "Class: " + playerManager.getPlayer().getCharacterClass();
            inventoryForm.getPlayerHPLabel().Text = "HP: " + playerManager.getPlayer().getPlayerStats().getCurrentHp()
                                    + "/" + playerManager.getPlayer().getPlayerStats().getMaxHp();
            inventoryForm.getPlayerSPLabel().Text = "SP: " + playerManager.getPlayer().getPlayerStats().getCurrentSp()
                                    + "/" + playerManager.getPlayer().getPlayerStats().getMaxSp();
            inventoryForm.getExpToNextLabel().Text = "Next EXP: " + playerManager.getPlayer().getPlayerStats().getExpToNextLevel();
        }

        //---------------------------------------------------------------
        // Updates the labels on the form with the items that the player
        // has equipped
        //---------------------------------------------------------------
        public void updateEquippedItems()
        {
            if (playerManager.isWeaponEquipped())
                inventoryForm.getWeaponLabel().Text = "Weapon: " + playerManager.getEquippedWeapon().getItemName();
            else
                inventoryForm.getWeaponLabel().Text = "Weapon: ";

            if (playerManager.isArmorEquipped())
                inventoryForm.getArmorLabel().Text = "Armor: " + playerManager.getEquippedArmor().getItemName();
            else
                inventoryForm.getArmorLabel().Text = "Armor: ";

            if (playerManager.isAccessoryEquipped())
                inventoryForm.getAccessoryLabel().Text = "Accessory: " + playerManager.getEquippedAccessory().getItemName();
            else
                inventoryForm.getAccessoryLabel().Text = "Accessory: ";
        }

        //----------------------------------------------------------------
        // Updates the label of the item description with the item's 
        // description from the item class
        //----------------------------------------------------------------
        public void updateItemDiscription()
        {
            if (playerManager.getPlayer().getInventoryManager().getInventory().Count > 0)
                inventoryForm.getDescription().Text = playerManager.getPlayer().getInventoryManager().getEntryAtIndex(location).Key.getItemDescription();
            else
                inventoryForm.getDescription().Text = "";
        }

        //-----------------------------------------------------------------------------
        // Sets the progress bar for the Hp, sp and exp progress bar
        //-----------------------------------------------------------------------------
        public void setProgressBars()
        {
            inventoryForm.getHpProgressBar().Maximum = playerManager.getPlayer().getPlayerStats().getMaxHp();
            inventoryForm.getHpProgressBar().Value = playerManager.getPlayer().getPlayerStats().getCurrentHp();

            inventoryForm.getSpProgressBar().Maximum = playerManager.getPlayer().getPlayerStats().getMaxSp();
            inventoryForm.getSpProgressBar().Value = playerManager.getPlayer().getPlayerStats().getCurrentSp();

            inventoryForm.getNextLevelProgressBar().Maximum = playerManager.getPlayer().getPlayerStats().getNextLevelExp();
            inventoryForm.getNextLevelProgressBar().Value = playerManager.getPlayer().getPlayerStats().getNextLevelExp() 
                                                - playerManager.getPlayer().getPlayerStats().getExpToNextLevel();
        }


        //-----------------------------------------------------------------------------
        // handles the input of all the keybinds for the inventory form
        //-----------------------------------------------------------------------------
        public void handleInput(object sender, KeyEventArgs e)
        {
            // moves up the ListBox
            if ((e.KeyCode == Keys.Up) && location > 0)
            {
                this.location--;
                updateItemDiscription();
                inventoryForm.getEquipConfirm().Text = "";
            }
            // moves down the ListBox
            else if ((e.KeyCode == Keys.Down) && location < playerManager.getPlayer().getInventoryManager().getInventory().Count - 1)
            {
                this.location++;
                updateItemDiscription();
                inventoryForm.getEquipConfirm().Text = "";
            }
            else if (e.KeyCode == Keys.Z)
            {
                doItem();
            }
            else if (e.KeyCode == Keys.X)
            {
                inventoryForm.Close();
            }
            else
            {
                e.SuppressKeyPress = true;
            }
        }

        //-----------------------------------------------------------------
        // determines what actions need to be done to the selected item
        //-----------------------------------------------------------------
        public void doItem()
        {
            if (playerManager.getPlayer().getInventoryManager().getInventory().Count > 0)
            {
                Item selectedItem = playerManager.getPlayer().getInventoryManager().getEntryAtIndex(location).Key;

                // if the item is equippable, then it will either equip or unequip it
                if (playerManager.isEquippable(selectedItem))
                {
                    if (!playerManager.isEquipped(selectedItem))
                        equipItem(selectedItem);
                    else
                        unequipItem(selectedItem);
                }
                // checks if the item is usable
                else if (playerManager.isUsable(selectedItem))
                {
                    useItem(selectedItem);
                }
            }
        }

        //-----------------------------------------------------------------
        // Performs the logic to equip an item to the player
        //-----------------------------------------------------------------
        public void equipItem(Item selectedItem)
        {
            if (playerManager.canEquip(selectedItem) && 
                !playerManager.isEquipped(selectedItem) && !playerManager.isItemTypeEquipped(selectedItem))
            {
                playerManager.equipItem(selectedItem);
                updateInventoryDisplay();

                inventoryForm.getEquipConfirm().Text = "Equipped " + selectedItem.getItemName();
            }
            else if (playerManager.isEquipped(selectedItem))
            {
                unequipItem(selectedItem);
                updateInventoryDisplay();
                inventoryForm.getEquipConfirm().Text = selectedItem.getItemName() + " has been unequipped.";
            }
            else if (playerManager.isItemTypeEquipped(selectedItem))
            {
                // find same type item
                Item foundItem = playerManager.findEquippedItemOfSameType(selectedItem);
                // unequip that item\
                unequipItem(foundItem);
                equipItem(selectedItem);

                updateInventoryDisplay();
                inventoryForm.getEquipConfirm().Text = foundItem.getItemName() + "has been unequipped\n" + selectedItem.getItemName() + " has been equipped.";
            }
            else if (playerManager.isEquippable(selectedItem))
            {
                inventoryForm.getEquipConfirm().Text = "Cannot equip " + selectedItem.getItemName()
                    + ": Wrong Class";
            }
            else
            {
                inventoryForm.getEquipConfirm().Text = "Cannot equip " + selectedItem.getItemName()
                    + ": Not an equippable item";
            }
        }

        //-------------------------------------------------------------------
        // Performs the logic to unequip an item from the player
        //-------------------------------------------------------------------
        public void unequipItem(Item selectedItem)
        {
            playerManager.unequipItem(selectedItem);
            updateInventoryDisplay();
            inventoryForm.getEquipConfirm().Text = selectedItem.getItemName() + " has been unequipped.";
        }

        //--------------------------------------------------------------------
        // Performs the logic to use an item on the player
        //--------------------------------------------------------------------
        public void useItem(Item selectedItem)
        {
            // checks if a player can use an item
            if (playerManager.isUsable(selectedItem) && playerManager.shouldUse(selectedItem))
            {
                playerManager.useItem(selectedItem);
                updateInventoryDisplay();

                inventoryForm.getEquipConfirm().Text = "Used " + selectedItem.getItemName();
            }
            // checks it the item will boost past max stats
            else if (playerManager.isUsable(selectedItem) && !playerManager.shouldUse(selectedItem))
            {
                if (playerManager.getPlayer().getPlayerStats().getCurrentHp() ==
                    playerManager.getPlayer().getPlayerStats().getMaxHp())
                {
                    if (selectedItem is HealingPotion)
                        inventoryForm.getEquipConfirm().Text = "Cannot use " + selectedItem.getItemName()
                          + ": HP is full";
                }
                if (playerManager.getPlayer().getPlayerStats().getCurrentSp() ==
                     playerManager.getPlayer().getPlayerStats().getMaxSp())
                {
                    if (selectedItem is SpPotion)
                        inventoryForm.getEquipConfirm().Text = "Cannot use " + selectedItem.getItemName()
                            + ": SP is full";
                }
            }
            else
            {
                inventoryForm.getEquipConfirm().Text = "Cannot use " + selectedItem.getItemName()
                    + ": Not an usable item";
            }
        }
    }
}
