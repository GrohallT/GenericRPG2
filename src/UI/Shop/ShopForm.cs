//---------------------------------------------------------------
// Name: Taryn Grohall
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Form for the shop
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GenericRPG2.UI.Shop;
using GenericRPG2.Players;

namespace GenericRPG2
{
    //---------------------------------------------------------------
    // Contains the form related to the shop
    //---------------------------------------------------------------
    public partial class ShopForm : Form
    {
        private ShopManager shopManager;

        private bool confirmLabelVisible;

        public ShopForm(ShopData shopData, PlayerManager playerManager)
        {
            InitializeComponent();

            shopManager = new ShopManager(shopData, this, playerManager);
            confirmLabel.Visible = false;
            confirmLabel.Text = "Do you want to purchase this item?" +
               "\n Z - yes X - no";

        }

        public ListBox getInventory()
        {
            return this.itemListBox;
        }

        public Label getInfoLabel()
        {
            return this.itemInformationLabel;
        }
        public Label getConfirmLabel()
        {
            return this.confirmLabel;
        }

        public Label getGoldLabel()
        {
            return this.playerGoldLabel;
        }

        public Label getPlayerStatChangeLabel()
        {
            return this.playerStatChangeLabel;
        }

        //---------------------------------------------------------------
        // The form key down event
        //---------------------------------------------------------------
        private void ShopForm_KeyDown_1(object sender, KeyEventArgs e)
        {
            shopManager.manageInput(sender, e);
        }
        private void itemListBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShopForm_Load(object sender, EventArgs e)
        {

        }

        private void itemListBox_MouseDown(object sender, MouseEventArgs e)
        {
            itemListBox.SelectedIndex = shopManager.getShopData().getInvLocation();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public bool isConfirmLabelVisible()
        {
            return this.confirmLabelVisible;
        }

        public void setConfirmLabelVisible(bool visible)
        {
            this.confirmLabelVisible = visible;
            this.confirmLabel.Visible = visible;
        }

    }

}
