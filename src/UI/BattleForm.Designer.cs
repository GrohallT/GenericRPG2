
namespace GenericRPG2.UI
{
   partial class BattleForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.enemy1PictureBox = new System.Windows.Forms.PictureBox();
            this.enemy2PictureBox = new System.Windows.Forms.PictureBox();
            this.enemy3PictureBox = new System.Windows.Forms.PictureBox();
            this.enemy1HealthBar = new System.Windows.Forms.ProgressBar();
            this.enemy2HealthBar = new System.Windows.Forms.ProgressBar();
            this.enemy3HealthBar = new System.Windows.Forms.ProgressBar();
            this.attackLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.skillLabel = new System.Windows.Forms.Label();
            this.fleeLabel = new System.Windows.Forms.Label();
            this.playerStatsLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.spLabel = new System.Windows.Forms.Label();
            this.bottomBorder = new System.Windows.Forms.Label();
            this.battleMsgLabel = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // enemy1PictureBox
            // 
            this.enemy1PictureBox.Location = new System.Drawing.Point(206, 106);
            this.enemy1PictureBox.Name = "enemy1PictureBox";
            this.enemy1PictureBox.Size = new System.Drawing.Size(128, 128);
            this.enemy1PictureBox.TabIndex = 1;
            this.enemy1PictureBox.TabStop = false;
            // 
            // enemy2PictureBox
            // 
            this.enemy2PictureBox.Location = new System.Drawing.Point(386, 73);
            this.enemy2PictureBox.Name = "enemy2PictureBox";
            this.enemy2PictureBox.Size = new System.Drawing.Size(128, 128);
            this.enemy2PictureBox.TabIndex = 2;
            this.enemy2PictureBox.TabStop = false;
            // 
            // enemy3PictureBox
            // 
            this.enemy3PictureBox.Location = new System.Drawing.Point(578, 106);
            this.enemy3PictureBox.Name = "enemy3PictureBox";
            this.enemy3PictureBox.Size = new System.Drawing.Size(128, 128);
            this.enemy3PictureBox.TabIndex = 3;
            this.enemy3PictureBox.TabStop = false;
            // 
            // enemy1HealthBar
            // 
            this.enemy1HealthBar.Location = new System.Drawing.Point(206, 240);
            this.enemy1HealthBar.Name = "enemy1HealthBar";
            this.enemy1HealthBar.Size = new System.Drawing.Size(128, 17);
            this.enemy1HealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy1HealthBar.TabIndex = 4;
            this.enemy1HealthBar.Visible = false;
            // 
            // enemy2HealthBar
            // 
            this.enemy2HealthBar.Location = new System.Drawing.Point(386, 207);
            this.enemy2HealthBar.Name = "enemy2HealthBar";
            this.enemy2HealthBar.Size = new System.Drawing.Size(128, 17);
            this.enemy2HealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy2HealthBar.TabIndex = 5;
            this.enemy2HealthBar.Visible = false;
            // 
            // enemy3HealthBar
            // 
            this.enemy3HealthBar.Location = new System.Drawing.Point(578, 240);
            this.enemy3HealthBar.Name = "enemy3HealthBar";
            this.enemy3HealthBar.Size = new System.Drawing.Size(128, 17);
            this.enemy3HealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy3HealthBar.TabIndex = 6;
            this.enemy3HealthBar.Visible = false;
            // 
            // attackLabel
            // 
            this.attackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attackLabel.Location = new System.Drawing.Point(365, 421);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(79, 28);
            this.attackLabel.TabIndex = 7;
            this.attackLabel.Text = "Attack";
            this.attackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemLabel
            // 
            this.itemLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemLabel.Location = new System.Drawing.Point(450, 421);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(79, 28);
            this.itemLabel.TabIndex = 8;
            this.itemLabel.Text = "Item";
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skillLabel
            // 
            this.skillLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skillLabel.Location = new System.Drawing.Point(365, 459);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(79, 28);
            this.skillLabel.TabIndex = 9;
            this.skillLabel.Text = "Skill";
            this.skillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fleeLabel
            // 
            this.fleeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fleeLabel.Location = new System.Drawing.Point(450, 459);
            this.fleeLabel.Name = "fleeLabel";
            this.fleeLabel.Size = new System.Drawing.Size(79, 28);
            this.fleeLabel.TabIndex = 10;
            this.fleeLabel.Text = "Flee";
            this.fleeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerStatsLabel
            // 
            this.playerStatsLabel.Location = new System.Drawing.Point(633, 421);
            this.playerStatsLabel.Name = "playerStatsLabel";
            this.playerStatsLabel.Size = new System.Drawing.Size(100, 23);
            this.playerStatsLabel.TabIndex = 11;
            this.playerStatsLabel.Text = "Player:";
            this.playerStatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hpLabel
            // 
            this.hpLabel.Location = new System.Drawing.Point(633, 441);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(100, 23);
            this.hpLabel.TabIndex = 12;
            this.hpLabel.Text = "HP: ";
            this.hpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spLabel
            // 
            this.spLabel.Location = new System.Drawing.Point(633, 464);
            this.spLabel.Name = "spLabel";
            this.spLabel.Size = new System.Drawing.Size(100, 23);
            this.spLabel.TabIndex = 13;
            this.spLabel.Text = "SP: ";
            this.spLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bottomBorder
            // 
            this.bottomBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomBorder.Location = new System.Drawing.Point(81, 260);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(717, 242);
            this.bottomBorder.TabIndex = 14;
            // 
            // battleMsgLabel
            // 
            this.battleMsgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.battleMsgLabel.Location = new System.Drawing.Point(354, 273);
            this.battleMsgLabel.Name = "battleMsgLabel";
            this.battleMsgLabel.Size = new System.Drawing.Size(436, 99);
            this.battleMsgLabel.TabIndex = 15;
            this.battleMsgLabel.Text = "Battle Message";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 15;
            this.itemListBox.Location = new System.Drawing.Point(90, 273);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(244, 214);
            this.itemListBox.TabIndex = 16;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 649);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.battleMsgLabel);
            this.Controls.Add(this.spLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.playerStatsLabel);
            this.Controls.Add(this.fleeLabel);
            this.Controls.Add(this.skillLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.attackLabel);
            this.Controls.Add(this.enemy3HealthBar);
            this.Controls.Add(this.enemy2HealthBar);
            this.Controls.Add(this.enemy1HealthBar);
            this.Controls.Add(this.enemy3PictureBox);
            this.Controls.Add(this.enemy2PictureBox);
            this.Controls.Add(this.enemy1PictureBox);
            this.Controls.Add(this.bottomBorder);
            this.KeyPreview = true;
            this.Name = "BattleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BattleForm";
            this.Load += new System.EventHandler(this.BattleForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BattleForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.enemy1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3PictureBox)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.PictureBox enemy1PictureBox;
      private System.Windows.Forms.PictureBox enemy2PictureBox;
      private System.Windows.Forms.PictureBox enemy3PictureBox;
      private System.Windows.Forms.ProgressBar enemy1HealthBar;
      private System.Windows.Forms.ProgressBar enemy2HealthBar;
      private System.Windows.Forms.ProgressBar enemy3HealthBar;
      private System.Windows.Forms.Label attackLabel;
      private System.Windows.Forms.Label itemLabel;
      private System.Windows.Forms.Label skillLabel;
      private System.Windows.Forms.Label fleeLabel;
      private System.Windows.Forms.Label playerStatsLabel;
      private System.Windows.Forms.Label hpLabel;
      private System.Windows.Forms.Label spLabel;
      private System.Windows.Forms.Label bottomBorder;
      private System.Windows.Forms.Label battleMsgLabel;
      private System.Windows.Forms.ListBox itemListBox;
   }
}