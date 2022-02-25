
namespace GenericRPG2.UI
{
   partial class GameOverForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yesLabel = new System.Windows.Forms.Label();
            this.noLabel = new System.Windows.Forms.Label();
            this.restartConfirmLabel = new System.Windows.Forms.Label();
            this.quitConfirmLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME OVER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(335, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do you want to try again?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesLabel
            // 
            this.yesLabel.BackColor = System.Drawing.Color.White;
            this.yesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yesLabel.Location = new System.Drawing.Point(299, 229);
            this.yesLabel.Name = "yesLabel";
            this.yesLabel.Size = new System.Drawing.Size(100, 23);
            this.yesLabel.TabIndex = 2;
            this.yesLabel.Text = "Yes";
            this.yesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noLabel
            // 
            this.noLabel.BackColor = System.Drawing.Color.White;
            this.noLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noLabel.Location = new System.Drawing.Point(440, 229);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(100, 23);
            this.noLabel.TabIndex = 3;
            this.noLabel.Text = "No";
            this.noLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartConfirmLabel
            // 
            this.restartConfirmLabel.BackColor = System.Drawing.Color.White;
            this.restartConfirmLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.restartConfirmLabel.Location = new System.Drawing.Point(299, 207);
            this.restartConfirmLabel.Name = "restartConfirmLabel";
            this.restartConfirmLabel.Size = new System.Drawing.Size(241, 80);
            this.restartConfirmLabel.TabIndex = 4;
            this.restartConfirmLabel.Text = "Are you sure you want to restart?\r\n\r\nZ - yes   X - no";
            this.restartConfirmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitConfirmLabel
            // 
            this.quitConfirmLabel.BackColor = System.Drawing.Color.White;
            this.quitConfirmLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quitConfirmLabel.Location = new System.Drawing.Point(299, 207);
            this.quitConfirmLabel.Name = "quitConfirmLabel";
            this.quitConfirmLabel.Size = new System.Drawing.Size(241, 80);
            this.quitConfirmLabel.TabIndex = 5;
            this.quitConfirmLabel.Text = "Are you sure you want to quit?\r\n\r\nZ - yes   X - no";
            this.quitConfirmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 649);
            this.Controls.Add(this.quitConfirmLabel);
            this.Controls.Add(this.restartConfirmLabel);
            this.Controls.Add(this.noLabel);
            this.Controls.Add(this.yesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOverForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameOverForm_KeyDown);
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label yesLabel;
      private System.Windows.Forms.Label noLabel;
      private System.Windows.Forms.Label restartConfirmLabel;
      private System.Windows.Forms.Label quitConfirmLabel;
   }
}