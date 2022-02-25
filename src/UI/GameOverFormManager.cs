//---------------------------------------------------------------
// Name: Robert Becker
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Contains the logic for managing the game over form
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GenericRPG2.UI
{
    //---------------------------------------------------------------
    // Contains the logic for managing the game over form
    //---------------------------------------------------------------
    public class GameOverFormManager
    {
        private bool hasWon;
        protected GameOverFormData data;
        protected GameOverForm form;

        public GameOverFormManager(GameOverFormData data, GameOverForm form, bool hasWon)
        {
            this.data = data;
            this.form = form;
            populateOptions(); //initialize the array of labels representing options
            setHighlights(); //initialize the highlights of the labels
            form.getConfirmRestartLabel().Visible = false;
            form.getConfirmQuitLabel().Visible = false;
            this.hasWon = hasWon;

            if (hasWon)
                setLabelText();

        }

        public void setLabelText()
        {
            form.getHeaderLabel().Text = "Congrats, You Win";
        }

        //---------------------------------------------------------------
        // Populates the options array with the labels
        // representing the options
        //---------------------------------------------------------------
        public void populateOptions()
        {
            data.getOptions()[0] = form.getYesLabel();
            data.getOptions()[1] = form.getNoLabel();
        }

        //---------------------------------------------------------------
        // Handles the input from the user
        //---------------------------------------------------------------
        public void handleInput(object sender, KeyEventArgs e)
        {
            if (!form.isQuitConfirmLabelVisible() && !form.isRestartConfirmLabelVisible())
            {
                if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && data.getPoisition() > 0)
                    data.setPosition(data.getPoisition() - 1);
                else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && data.getPoisition() < data.getOptions().Length - 1)
                    data.setPosition(data.getPoisition() + 1);
                else if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Enter)
                    confirmLogic();

                setHighlights();
            }
            else if (form.isRestartConfirmLabelVisible())
            {
                if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Enter)
                {
                    confirmRestartLogic();
                }
                else if (e.KeyCode == Keys.X || e.KeyCode == Keys.Back)
                {
                    exitRestartLogic();
                }
            }
            else if (form.isQuitConfirmLabelVisible())
            {
                if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Enter)
                {
                    confirmQuitLogic();
                }
                else if (e.KeyCode == Keys.X || e.KeyCode == Keys.Back)
                {
                    exitQuitLogic();
                }
            }
        }

        //---------------------------------------------------------------
        // Sets the highlights of the labels representing the options
        //---------------------------------------------------------------
        public void setHighlights()
        {
            for (int i = 0; i < data.getOptions().Length; i++)
            {
                if (data.getPoisition() == i)
                    data.getOptions()[i].BackColor = Color.LightBlue;
                else
                    data.getOptions()[i].BackColor = Color.White;
            }
        }

        //---------------------------------------------------------------
        // Contains the logic to restart the game
        //---------------------------------------------------------------
        public void confirmRestartLogic()
        {
            //restarts the game be making a new class selection form


            ClassSelectionForm classSelectionForm = new ClassSelectionForm();
            form.Visible = false;
            form.Close();
            classSelectionForm.ShowDialog();

        }

        //---------------------------------------------------------------
        // Contains the logic to cancel the restart confirmation
        //---------------------------------------------------------------
        public void exitRestartLogic()
        {
            toggleConfirmRestartLabelVisible(false);
            toggleOptionsVisible(true);
        }

        //---------------------------------------------------------------
        // Contains the logic for confirming a quit
        //---------------------------------------------------------------
        public void confirmQuitLogic()
        {
            form.Close();
        }

        //---------------------------------------------------------------
        // Contains the logic for canceling the quit confirmation
        //---------------------------------------------------------------
        public void exitQuitLogic()
        {
            toggleConfirmQuitLabelVisible(false);
            toggleOptionsVisible(true);
        }

        //---------------------------------------------------------------
        // Contains the logic for when the user selects an option
        // in the option array
        //---------------------------------------------------------------
        public void confirmLogic()
        {
            toggleOptionsVisible(false);

            Label selected = data.getOptions()[data.getPoisition()];

            if (selected == form.getYesLabel())
            {
                toggleConfirmRestartLabelVisible(true);
            }
            else if (selected == form.getNoLabel())
            {
                toggleConfirmQuitLabelVisible(true);
            }
        }

        //---------------------------------------------------------------
        // Contains the logic for setting the restart label
        // to be invisibile or visible
        //---------------------------------------------------------------
        public void toggleConfirmRestartLabelVisible(Boolean b)
        {
            if (b)
                form.setRestartConfirmLabelVisible(true);
            else
                form.setRestartConfirmLabelVisible(false);
        }

        //---------------------------------------------------------------
        // Contains the logic for setting the quit label
        // to be invisible or visible
        //---------------------------------------------------------------
        public void toggleConfirmQuitLabelVisible(Boolean b)
        {
            if (b)
                form.setQuitConfirmLabelVisible(true);
            else
                form.setQuitConfirmLabelVisible(false);
        }

        //---------------------------------------------------------------
        // Contains the logic for setting the options labels
        // to be invisible or visible
        //---------------------------------------------------------------
        public void toggleOptionsVisible(Boolean b)
        {
            if (b)
            {
                foreach (Label L in data.getOptions())
                    L.Visible = true;
            }
            else
            {
                foreach (Label L in data.getOptions())
                    L.Visible = false;
            }
        }

        public GameOverForm getForm()
        {
            return this.form;
        }

        public GameOverFormData getData()
        {
            return this.data;
        }

    }

}
