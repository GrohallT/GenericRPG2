//---------------------------------------------------------------------
// Name:    Marshall Paider
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Contains the layout of the inventory form
//---------------------------------------------------------------------

using GenericRPG2.Inventory;
using GenericRPG2.Players;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenericRPG2
{
    //-----------------------------------------------------------------
    // This class is the getters for all of the labels and
    // other UI components on the form
    //-----------------------------------------------------------------
    public partial class InventoryForm : Form
    {
        private InventoryFormManager inventoryFormManager;

        public InventoryForm(PlayerManager playerManager)
        {
            InitializeComponent();
            this.inventoryFormManager = new InventoryFormManager(playerManager, this);
        }

        public Label getPlayerHPLabel()
        {
            return this.PlayerHP;
        }

        public Label getPlayerSPLabel()
        {
            return this.PlayerSP;
        }

        public Label getPlayerLevel()
        {
            return this.PlayerLevel;
        }

        public Label getNextExpLabel()
        {
            return this.EXPtoNext;
        }

        public Label getAttackLabel()
        {
            return this.PlayerAttack;
        }
        public Label getDefenseLabel()
        {
            return this.PlayerDefense;
        }
        public Label getSpeedLabel()
        {
            return this.PlayerSpeed;
        }
        public Label getPlayerGoldLabel()
        {
            return this.PlayerGold;
        }
        public Label getClassLabel()
        {
            return this.PlayerClass;
        }
        public Label getWeaponLabel()
        {
            return this.PlayerWeapon;
        }

        public Label getArmorLabel()
        {
            return this.PlayerArmor;
        }

        public Label getAccessoryLabel()
        {
            return this.PlayerAcc;
        }

        public ListBox getItemsList()
        {
            return this.ItemsList;
        }

        public Label getEquipConfirm()
        {
            return equipConfirm;
        }

        public Label getDescription()
        {
            return this.ItemDescription;
        }

        public PictureBox GetPictureBox()
        {
            return playerSprite;
        }

        public ListBox getInventoryDisplay()
        {
            return this.ItemsList;
        }

        public ProgressBar getHpProgressBar()
        {
            return this.hpProgressBar;
        }

        public ProgressBar getSpProgressBar()
        {
            return this.spProgressBar;
        }

        public ProgressBar getNextLevelProgressBar()
        {
            return this.expToNextProgressBar;
        }

        public Label getExpToNextLabel()
        {
            return this.EXPtoNext;
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void ItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------
        // method to handle the event if a key is pressed
        //-------------------------------------------------------
        private void InventoryForm_KeyDown(object sender, KeyEventArgs e)
        {
            inventoryFormManager.handleInput(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ItemDescription_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
