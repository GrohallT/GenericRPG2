namespace GenericRPG2.UI.Overworld
{
    partial class Overworld
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statsLabel = new System.Windows.Forms.Label();
            this.shopEnterConfirm = new System.Windows.Forms.Label();
            this.innRestConfirm = new System.Windows.Forms.Label();
            this.innRested = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statsLabel
            // 
            this.statsLabel.Location = new System.Drawing.Point(814, 527);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(82, 113);
            this.statsLabel.TabIndex = 0;
            this.statsLabel.Text = "HP:\r\nSP:\r\nLevel:\r\nAttack:\r\nDefense:\r\nSpeed:\r\nGold:";
            // 
            // shopEnterConfirm
            // 
            this.shopEnterConfirm.AutoSize = true;
            this.shopEnterConfirm.Location = new System.Drawing.Point(12, 625);
            this.shopEnterConfirm.Name = "shopEnterConfirm";
            this.shopEnterConfirm.Size = new System.Drawing.Size(150, 15);
            this.shopEnterConfirm.TabIndex = 1;
            this.shopEnterConfirm.Text = "Press \"Z\" to enter the shop.";
            this.shopEnterConfirm.Visible = false;
            // 
            // innRestConfirm
            // 
            this.innRestConfirm.AutoSize = true;
            this.innRestConfirm.Location = new System.Drawing.Point(16, 625);
            this.innRestConfirm.Name = "innRestConfirm";
            this.innRestConfirm.Size = new System.Drawing.Size(146, 15);
            this.innRestConfirm.TabIndex = 2;
            this.innRestConfirm.Text = "Press \"Z\" to rest at the inn.";
            this.innRestConfirm.Visible = false;
            // 
            // innRested
            // 
            this.innRested.AutoSize = true;
            this.innRested.Location = new System.Drawing.Point(16, 625);
            this.innRested.Name = "innRested";
            this.innRested.Size = new System.Drawing.Size(278, 15);
            this.innRested.TabIndex = 3;
            this.innRested.Text = "You have rested at the inn, your HP was maxed out.";
            this.innRested.Visible = false;
            // 
            // Overworld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 649);
            this.Controls.Add(this.innRested);
            this.Controls.Add(this.innRestConfirm);
            this.Controls.Add(this.shopEnterConfirm);
            this.Controls.Add(this.statsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Overworld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overworld";
            this.Load += new System.EventHandler(this.Overworld_Load);
            this.VisibleChanged += new System.EventHandler(this.Overworld_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Overworld_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.Label shopEnterConfirm;
        private System.Windows.Forms.Label innRestConfirm;
        private System.Windows.Forms.Label innRested;
    }
}

