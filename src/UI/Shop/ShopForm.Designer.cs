
namespace GenericRPG2
{
    partial class ShopForm
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
            this.itemsListLabel = new System.Windows.Forms.Label();
            this.itemInformationLabel = new System.Windows.Forms.Label();
            this.playerStatChangeLabel = new System.Windows.Forms.Label();
            this.playerGoldLabel = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsListLabel
            // 
            this.itemsListLabel.AutoSize = true;
            this.itemsListLabel.Location = new System.Drawing.Point(71, 9);
            this.itemsListLabel.Name = "itemsListLabel";
            this.itemsListLabel.Size = new System.Drawing.Size(0, 15);
            this.itemsListLabel.TabIndex = 0;
            // 
            // itemInformationLabel
            // 
            this.itemInformationLabel.BackColor = System.Drawing.Color.White;
            this.itemInformationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemInformationLabel.Location = new System.Drawing.Point(251, 55);
            this.itemInformationLabel.Name = "itemInformationLabel";
            this.itemInformationLabel.Size = new System.Drawing.Size(240, 128);
            this.itemInformationLabel.TabIndex = 4;
            this.itemInformationLabel.Text = "Item Infomaion";
            this.itemInformationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerStatChangeLabel
            // 
            this.playerStatChangeLabel.BackColor = System.Drawing.Color.White;
            this.playerStatChangeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerStatChangeLabel.Location = new System.Drawing.Point(251, 183);
            this.playerStatChangeLabel.Name = "playerStatChangeLabel";
            this.playerStatChangeLabel.Size = new System.Drawing.Size(240, 126);
            this.playerStatChangeLabel.TabIndex = 5;
            this.playerStatChangeLabel.Text = "Player Stat Changes";
            this.playerStatChangeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerGoldLabel
            // 
            this.playerGoldLabel.BackColor = System.Drawing.Color.White;
            this.playerGoldLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerGoldLabel.Location = new System.Drawing.Point(345, 439);
            this.playerGoldLabel.Name = "playerGoldLabel";
            this.playerGoldLabel.Size = new System.Drawing.Size(116, 15);
            this.playerGoldLabel.TabIndex = 6;
            this.playerGoldLabel.Text = "Gold:";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 15;
            this.itemListBox.Location = new System.Drawing.Point(12, 12);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(233, 409);
            this.itemListBox.TabIndex = 7;
            this.itemListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemListBox_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(251, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 409);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // confirmLabel
            // 
            this.confirmLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmLabel.Location = new System.Drawing.Point(251, 309);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(240, 112);
            this.confirmLabel.TabIndex = 9;
            this.confirmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(137, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Up/ Down - navigate shop\r\nZ - confirm   X - cancel/ exit shop";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.playerGoldLabel);
            this.Controls.Add(this.playerStatChangeLabel);
            this.Controls.Add(this.itemInformationLabel);
            this.Controls.Add(this.itemsListLabel);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShopForm_KeyDown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemsListLabel;
        private System.Windows.Forms.Label itemInformationLabel;
        private System.Windows.Forms.Label playerStatChangeLabel;
        private System.Windows.Forms.Label playerGoldLabel;
      private System.Windows.Forms.ListBox itemListBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label confirmLabel;
      private System.Windows.Forms.Label label2;
   }
}