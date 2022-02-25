//---------------------------------------------------------------------
// Name:    Bennett Ceku
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: The code for the Overworld form to display to the player
//---------------------------------------------------------------------

using GenericRPG2.Map;
using GenericRPG2.Players;
using GenericRPG2.UI.Overworld;
using GenericRPG2.UI.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericRPG2.UI.Overworld
{
    //-------------------------------------------------------------------    
    // The class that has the Overworld display for the player to see  
    //-------------------------------------------------------------------
    public partial class Overworld : Form
    {
        private PlayerManager playerManager;
        private MapManager mapManager;
        private PictureBox mapPictureBox;
        private OverworldManager overworldManager;

        private bool innConfirmationVisible;
        private bool innRestedVisible;

        public Overworld(PlayerManager playerManager, MapManager mapManager)
        {
            this.playerManager = playerManager;
            this.mapManager = mapManager;
            this.mapPictureBox = new PictureBox();
            this.playerManager.getPlayer().getPlayerSprite().BackColor = Color.Transparent;
            this.playerManager.getPlayer().getPlayerSprite().Parent = this.mapPictureBox;
            this.Controls.Add(mapPictureBox);
            
            InitializeComponent();

            this.ClientSize = new Size(896, 640);
            
            overworldManager = new OverworldManager(playerManager, mapManager, this);

        }

        //-------------------------------------------------------------------
        // Runs when the form is shown and displays all needed information
        // like player sprite and stats
        //-------------------------------------------------------------------
        private void Overworld_VisibleChanged(object sender, EventArgs e)
        {
            statsLabel.Text = playerManager.getPlayer().getPlayerStats().displayStats();
            shopEnterConfirm.BringToFront();
            innRestConfirm.BringToFront();
            innRested.BringToFront();
            mapManager.displayPlayer(playerManager.getPlayer());
            mapManager.displayMap(this);
        }

        //-------------------------------------------------------------------
        // Runs when the form is loaded and moves the statsLabel to the front
        //-------------------------------------------------------------------
        private void Overworld_Load(object sender, EventArgs e)
        {
            statsLabel.BringToFront();
        }

        //-------------------------------------------------------------------    
        // This method handles keyboard input and sends it to the overworld manager if the player tried to move.
        //-------------------------------------------------------------------
        private void Overworld_KeyDown(object sender, KeyEventArgs e)
        {
            overworldManager.handleInput(e);
        }

        public PictureBox getMapPictureBox()
        {
            return this.mapPictureBox;
        }

        public Label getShopConfirmation()
        {
            return this.shopEnterConfirm;
        }

        public Label getInnConfirmation()
        {
            return this.innRestConfirm;
        }

        public Label getInnRested()
        {
            return this.innRested;
        }

        public Label getStatsLabel()
        {
            return this.statsLabel;
        }

        public bool isInnConfirmationVisible()
        {
            return this.innConfirmationVisible;
        }

        public bool isInnRestedVisible()
        {
            return this.innRestedVisible;
        }
        
        public void setInnConfirmationVisible(bool visible)
        {
            this.innConfirmationVisible = visible;
            this.innRestConfirm.Visible = visible;
        }

        public void setInnRestedVisible(bool visible)
        {
            this.innRestedVisible = visible;
            this.innRested.Visible = visible;
        }

    }

}
