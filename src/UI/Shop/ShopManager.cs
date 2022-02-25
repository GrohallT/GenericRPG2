//---------------------------------------------------------------
// Name: Robert Becker
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Code to manage the shop
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using GenericRPG2.Items;
using GenericRPG2.Players;
using GenericRPG2.Items.Weapons;
using GenericRPG2.Items.Armors;
using GenericRPG2.Items.Accessories;

namespace GenericRPG2.UI.Shop
{
    //---------------------------------------------------------------
    // Contains the logic related to the shop
    //---------------------------------------------------------------
    public class ShopManager
    {

        protected ShopData shopData;
        protected ShopForm shopForm;
        protected ListBox shopInventory;
        protected PlayerManager playerManager;

        public ShopManager(ShopData shopData, ShopForm shopForm, PlayerManager playerManager)
        {
            this.shopData = shopData;
            this.shopForm = shopForm;
            this.playerManager = playerManager;
            this.shopInventory = shopForm.getInventory();
            displayInventory();
            shopInventory.SelectedIndex = shopData.getInvLocation();
            shopForm.getGoldLabel().Text += playerManager.getPlayer().getPlayerStats().getGold();

            Item tempItem = new Item();
            tempItem = shopData.getShopInventory().ElementAt<Item>(shopData.getInvLocation());
            shopForm.getInfoLabel().Text = tempItem.getItemDescription();
            shopForm.getInfoLabel().Text += "\nCost: " + tempItem.getItemCost() + " Gold";
            displayStatsInfo(tempItem);
        }

        //---------------------------------------------------------------
        // Manages the input from the user when in the shop
        //---------------------------------------------------------------
        public void manageInput(object sender, KeyEventArgs e)
        {
            if (!shopForm.isConfirmLabelVisible())
            {

                if (e.KeyCode == Keys.Up && shopData.getInvLocation() > 0)
                {
                    shopData.setInvLocation(shopData.getInvLocation() - 1);
                    Item tempItem = new Item();
                    tempItem = shopData.getShopInventory().ElementAt<Item>(shopData.getInvLocation());
                    shopForm.getInfoLabel().Text = tempItem.getItemDescription();
                    shopForm.getInfoLabel().Text += "\nCost: " + tempItem.getItemCost() + " Gold";
                    displayStatsInfo(tempItem);
                }
                else if (e.KeyCode == Keys.Down && shopData.getInvLocation() < shopData.getShopInventory().Count - 1)
                {
                    shopData.setInvLocation(shopData.getInvLocation() + 1);
                    Item tempItem = new Item();
                    tempItem = shopData.getShopInventory().ElementAt<Item>(shopData.getInvLocation());
                    shopForm.getInfoLabel().Text = tempItem.getItemDescription();
                    shopForm.getInfoLabel().Text += "\nCost: " + tempItem.getItemCost() + " Gold";
                    displayStatsInfo(tempItem);
                }
                else if (e.KeyCode == Keys.Z)
                {
                    shopForm.setConfirmLabelVisible(true);

                }
                else if (e.KeyCode == Keys.X)
                {
                    shopForm.Close();
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
            else if (shopForm.isConfirmLabelVisible())
            {
                if (e.KeyCode == Keys.Z)
                {
                    //add to inventory logic here
                    if (canPurchase())
                    {
                        Item tempItem = new Item();
                        tempItem = shopData.getShopInventory().ElementAt<Item>(shopData.getInvLocation());
                        playerManager.addItemToInventory(tempItem);
                        setGoldText();
                        shopForm.setConfirmLabelVisible(false);

                    }
                    else
                    {
                        shopForm.getConfirmLabel().Text = "Not enough gold!" +
                           "\n X - cancel";
                    }
                }
                else if (e.KeyCode == Keys.X)
                {
                    shopForm.setConfirmLabelVisible(false);
                    setConfirmationText();

                }
                else if (e.KeyCode == Keys.Up)
                {
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        //---------------------------------------------------------------
        // Checks if the user has sufficient gold to purchase their
        // selected item from the shop
        //---------------------------------------------------------------
        public Boolean canPurchase()
        {
            Boolean can = false;
            Item tempItem = new Item();
            tempItem = shopData.getShopInventory().ElementAt<Item>(shopData.getInvLocation());

            if (playerManager.getPlayer().getPlayerStats().getGold() - tempItem.getItemCost() >= 0)
            {
                can = true;
                playerManager.getPlayer().getPlayerStats().subtractGold(tempItem.getItemCost());
            }

            return can;
        }

        //---------------------------------------------------------------
        // Displays the player's stats, and displays the player's
        // increased stats given the effects of the selected item
        //---------------------------------------------------------------
        public void displayStatsInfo(Item tempItem)
        {
            int tempAttack = playerManager.getPlayer().getPlayerStats().getAttack();
            int tempDefense = playerManager.getPlayer().getPlayerStats().getDefense();
            int tempSpeed = playerManager.getPlayer().getPlayerStats().getSpeed();

            if (tempItem is Weapon)
            {
                Weapon tempWeapon = (Weapon)tempItem;
                shopForm.getPlayerStatChangeLabel().Text = "Stat Change: "
                   + "\nAttack: " + tempAttack + " --> " + (tempAttack + tempWeapon.getAttackIncreased())
                   + "\nDefense: " + tempDefense + " --> " + tempDefense
                   + "\nSpeed: " + tempSpeed + " --> " + tempSpeed;
            }
            else if (tempItem is Armor)
            {
                Armor tempArmor = (Armor)tempItem;
                shopForm.getPlayerStatChangeLabel().Text = "Stat Change: "
                   + "\nAttack: " + tempAttack + " --> " + tempAttack
                   + "\nDefense: " + tempDefense + " --> " + (tempDefense + tempArmor.getDefenseIncreased())
                   + "\nSpeed: " + tempSpeed + " --> " + tempSpeed;
            }
            else if (tempItem is Accessory)
            {
                Accessory tempAcc = (Accessory)tempItem;
                shopForm.getPlayerStatChangeLabel().Text = "Stat Change: "
                   + "\nAttack: " + tempAttack + " --> " + tempAttack
                   + "\nDefense: " + tempDefense + " --> " + tempDefense
                   + "\nSpeed: " + tempSpeed + " --> " + (tempSpeed + tempAcc.getSpeedIncreased());
            }
            else
            {
                shopForm.getPlayerStatChangeLabel().Text = "Stat Change: "
                   + "\nAttack: " + tempAttack + " --> " + tempAttack
                   + "\nDefense: " + tempDefense + " --> " + tempDefense
                   + "\nSpeed: " + tempSpeed + " --> " + tempSpeed;
            }
        }

        //---------------------------------------------------------------
        // Adds the shop inventory from shop data to the list box
        //---------------------------------------------------------------
        public void displayInventory()
        {
            foreach (Item item in shopData.getShopInventory())
                shopInventory.Items.Add(item);
        }

        public ShopData getShopData()
        {
            return this.shopData;
        }

        //---------------------------------------------------------------
        // Sets the text of the confirmation label if the user selects
        // an item by pressing 'z'
        //---------------------------------------------------------------
        public void setConfirmationText()
        {
            shopForm.getConfirmLabel().Text = "Do you want to purchase this item?" +
               "\n Z - yes X - no";
        }

        //---------------------------------------------------------------
        // Updates the text of the label displaying the player's gold
        //---------------------------------------------------------------
        public void setGoldText()
        {
            shopForm.getGoldLabel().Text = "Gold: " + playerManager.getPlayer().getPlayerStats().getGold();
        }

        public ShopForm getShopForm()
        {
            return this.shopForm;
        }
    }
}
