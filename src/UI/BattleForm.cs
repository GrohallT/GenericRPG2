//---------------------------------------------------------------
// Name: Robert Becker
// Project: Generic RPG 2, a simple turn based RPG
// Purpose: Form for the battle
//---------------------------------------------------------------
using GenericRPG2.Players;
using GenericRPG2.Enemies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GenericRPG2.UI.Overworld;

namespace GenericRPG2.UI
{

   //---------------------------------------------------------------
   // Contains the form used for battle
   //---------------------------------------------------------------
   public partial class BattleForm : Form
    {
        BattleManager battleManager;
        public BattleForm(OverworldManager overworldManager, PlayerManager playerManager, List<EnemyManager> enemyList)
        {
            InitializeComponent();
            battleManager = new BattleManager(overworldManager, playerManager, enemyList, this);
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {

        }
        //getters to get the labels for updating purposes
        public Label getAttackLabel() { return this.attackLabel; }
        public Label getItemLabel() { return this.itemLabel; }
        public Label getSkillLabel() { return this.skillLabel; }
        public Label getFleeLabel() { return this.fleeLabel; }
        public Label getHPLabel() { return this.hpLabel; }
        public Label getSPLabel() { return this.spLabel; }
        public Label getBattleMsgLabel() { return this.battleMsgLabel; }
        
        public PictureBox getEnemy1PictureBox() { return this.enemy1PictureBox; }
        public PictureBox getEnemy2PictureBox() { return this.enemy2PictureBox; }
        public PictureBox getEnemy3PictureBox() { return this.enemy3PictureBox; }

        public ProgressBar getEnemy1HealthBar() { return this.enemy1HealthBar; }
        public ProgressBar getEnemy2HealthBar() { return this.enemy2HealthBar; }
        public ProgressBar getEnemy3HealthBar() { return this.enemy3HealthBar; }
        //getter for the list box, we can use this one list box
        // to display skills, items, or attacks if applicable
        public ListBox getItemList() { return this.itemListBox; }

        //---------------------------------------------------------------
        // The form key down event
        //---------------------------------------------------------------
        private void BattleForm_KeyDown(object sender, KeyEventArgs e)
        {
            battleManager.manageInput(sender, e);
        }
    }
}
