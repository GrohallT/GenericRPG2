//---------------------------------------------------------------
// Name: Robert Becker
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Form for the game over screen
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Forms;

namespace GenericRPG2.UI
{
    //---------------------------------------------------------------
    // Contains the form used for a game over
    //---------------------------------------------------------------
    public partial class GameOverForm : Form
    {
        GameOverFormData data;
        GameOverFormManager manager;

        private bool restartConfirmLabelVisible;
        private bool quitConfirmLabelVisible;

        public GameOverForm(bool hasWon)
        {
            InitializeComponent();
            data = new GameOverFormData();
            manager = new GameOverFormManager(data, this, hasWon);
        }

        //getters for the labels on the game over form
        public Label getYesLabel() { return this.yesLabel; }
        public Label getNoLabel() { return this.noLabel; }
        public Label getConfirmRestartLabel() { return this.restartConfirmLabel; }
        public Label getConfirmQuitLabel() { return this.quitConfirmLabel; }
        public Label getHeaderLabel() { return this.label1; }

        //---------------------------------------------------------------
        // Sends a key down event to the manager to handle
        //---------------------------------------------------------------
        private void GameOverForm_KeyDown(object sender, KeyEventArgs e)
        {
            manager.handleInput(sender, e);
        }

        public bool isRestartConfirmLabelVisible()
        {
            return this.restartConfirmLabelVisible;
        }

        public bool isQuitConfirmLabelVisible()
        {
            return this.quitConfirmLabelVisible;
        }

        public void setRestartConfirmLabelVisible(bool visible)
        {
            this.restartConfirmLabelVisible = visible;
            this.restartConfirmLabel.Visible = visible;
        }

        public void setQuitConfirmLabelVisible(bool visible)
        {
            this.quitConfirmLabelVisible = visible;
            this.quitConfirmLabel.Visible = visible;
        }

    }

}
