
namespace GenericRPG2
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.ItemsList = new System.Windows.Forms.ListBox();
            this.ItemDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerAttack = new System.Windows.Forms.Label();
            this.PlayerDefense = new System.Windows.Forms.Label();
            this.PlayerSpeed = new System.Windows.Forms.Label();
            this.PlayerHP = new System.Windows.Forms.Label();
            this.PlayerSP = new System.Windows.Forms.Label();
            this.PlayerLevel = new System.Windows.Forms.Label();
            this.EXPtoNext = new System.Windows.Forms.Label();
            this.PlayerClass = new System.Windows.Forms.Label();
            this.PlayerGold = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerWeapon = new System.Windows.Forms.Label();
            this.PlayerArmor = new System.Windows.Forms.Label();
            this.PlayerAcc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.equipConfirm = new System.Windows.Forms.Label();
            this.playerSprite = new System.Windows.Forms.PictureBox();
            this.hpProgressBar = new System.Windows.Forms.ProgressBar();
            this.spProgressBar = new System.Windows.Forms.ProgressBar();
            this.expToNextProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsList
            // 
            this.ItemsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ItemsList.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemsList.ForeColor = System.Drawing.Color.White;
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.ItemHeight = 21;
            this.ItemsList.Location = new System.Drawing.Point(397, 9);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(201, 256);
            this.ItemsList.TabIndex = 0;
            this.ItemsList.SelectedIndexChanged += new System.EventHandler(this.ItemsList_SelectedIndexChanged);
            // 
            // ItemDescription
            // 
            this.ItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemDescription.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemDescription.ForeColor = System.Drawing.Color.White;
            this.ItemDescription.Location = new System.Drawing.Point(397, 312);
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Size = new System.Drawing.Size(201, 52);
            this.ItemDescription.TabIndex = 1;
            this.ItemDescription.Text = "label1";
            this.ItemDescription.Click += new System.EventHandler(this.ItemDescription_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(397, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerAttack
            // 
            this.PlayerAttack.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerAttack.ForeColor = System.Drawing.Color.White;
            this.PlayerAttack.Location = new System.Drawing.Point(25, 106);
            this.PlayerAttack.Name = "PlayerAttack";
            this.PlayerAttack.Size = new System.Drawing.Size(116, 19);
            this.PlayerAttack.TabIndex = 3;
            this.PlayerAttack.Text = "Attack:";
            // 
            // PlayerDefense
            // 
            this.PlayerDefense.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerDefense.ForeColor = System.Drawing.Color.White;
            this.PlayerDefense.Location = new System.Drawing.Point(12, 125);
            this.PlayerDefense.Name = "PlayerDefense";
            this.PlayerDefense.Size = new System.Drawing.Size(129, 19);
            this.PlayerDefense.TabIndex = 4;
            this.PlayerDefense.Text = "Defense:";
            // 
            // PlayerSpeed
            // 
            this.PlayerSpeed.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerSpeed.ForeColor = System.Drawing.Color.White;
            this.PlayerSpeed.Location = new System.Drawing.Point(25, 144);
            this.PlayerSpeed.Name = "PlayerSpeed";
            this.PlayerSpeed.Size = new System.Drawing.Size(116, 19);
            this.PlayerSpeed.TabIndex = 5;
            this.PlayerSpeed.Text = "Speed:";
            // 
            // PlayerHP
            // 
            this.PlayerHP.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerHP.ForeColor = System.Drawing.Color.White;
            this.PlayerHP.Location = new System.Drawing.Point(12, 22);
            this.PlayerHP.Name = "PlayerHP";
            this.PlayerHP.Size = new System.Drawing.Size(90, 19);
            this.PlayerHP.TabIndex = 6;
            this.PlayerHP.Text = "HP:";
            // 
            // PlayerSP
            // 
            this.PlayerSP.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerSP.ForeColor = System.Drawing.Color.White;
            this.PlayerSP.Location = new System.Drawing.Point(12, 57);
            this.PlayerSP.Name = "PlayerSP";
            this.PlayerSP.Size = new System.Drawing.Size(90, 19);
            this.PlayerSP.TabIndex = 7;
            this.PlayerSP.Text = "SP:";
            // 
            // PlayerLevel
            // 
            this.PlayerLevel.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerLevel.ForeColor = System.Drawing.Color.White;
            this.PlayerLevel.Location = new System.Drawing.Point(256, 144);
            this.PlayerLevel.Name = "PlayerLevel";
            this.PlayerLevel.Size = new System.Drawing.Size(110, 19);
            this.PlayerLevel.TabIndex = 8;
            this.PlayerLevel.Text = "Level:";
            // 
            // EXPtoNext
            // 
            this.EXPtoNext.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EXPtoNext.ForeColor = System.Drawing.Color.White;
            this.EXPtoNext.Location = new System.Drawing.Point(230, 179);
            this.EXPtoNext.Name = "EXPtoNext";
            this.EXPtoNext.Size = new System.Drawing.Size(110, 19);
            this.EXPtoNext.TabIndex = 9;
            this.EXPtoNext.Text = "Next EXP:";
            // 
            // PlayerClass
            // 
            this.PlayerClass.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerClass.ForeColor = System.Drawing.Color.White;
            this.PlayerClass.Location = new System.Drawing.Point(256, 22);
            this.PlayerClass.Name = "PlayerClass";
            this.PlayerClass.Size = new System.Drawing.Size(110, 19);
            this.PlayerClass.TabIndex = 10;
            this.PlayerClass.Text = "Class:";
            // 
            // PlayerGold
            // 
            this.PlayerGold.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerGold.ForeColor = System.Drawing.Color.White;
            this.PlayerGold.Location = new System.Drawing.Point(12, 194);
            this.PlayerGold.Name = "PlayerGold";
            this.PlayerGold.Size = new System.Drawing.Size(90, 19);
            this.PlayerGold.TabIndex = 11;
            this.PlayerGold.Text = "Gold:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Equipped";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PlayerWeapon
            // 
            this.PlayerWeapon.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerWeapon.ForeColor = System.Drawing.Color.White;
            this.PlayerWeapon.Location = new System.Drawing.Point(12, 278);
            this.PlayerWeapon.Name = "PlayerWeapon";
            this.PlayerWeapon.Size = new System.Drawing.Size(201, 19);
            this.PlayerWeapon.TabIndex = 13;
            this.PlayerWeapon.Text = "Weapon:";
            // 
            // PlayerArmor
            // 
            this.PlayerArmor.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerArmor.ForeColor = System.Drawing.Color.White;
            this.PlayerArmor.Location = new System.Drawing.Point(12, 345);
            this.PlayerArmor.Name = "PlayerArmor";
            this.PlayerArmor.Size = new System.Drawing.Size(201, 19);
            this.PlayerArmor.TabIndex = 14;
            this.PlayerArmor.Text = "Armor:";
            // 
            // PlayerAcc
            // 
            this.PlayerAcc.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerAcc.ForeColor = System.Drawing.Color.White;
            this.PlayerAcc.Location = new System.Drawing.Point(12, 407);
            this.PlayerAcc.Name = "PlayerAcc";
            this.PlayerAcc.Size = new System.Drawing.Size(201, 19);
            this.PlayerAcc.TabIndex = 15;
            this.PlayerAcc.Text = "Accessory:";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 222);
            this.label3.TabIndex = 16;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(2, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 205);
            this.label4.TabIndex = 17;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // equipConfirm
            // 
            this.equipConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipConfirm.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equipConfirm.ForeColor = System.Drawing.Color.White;
            this.equipConfirm.Location = new System.Drawing.Point(397, 376);
            this.equipConfirm.Name = "equipConfirm";
            this.equipConfirm.Size = new System.Drawing.Size(201, 65);
            this.equipConfirm.TabIndex = 18;
            this.equipConfirm.Text = "label5";
            // 
            // playerSprite
            // 
            this.playerSprite.Image = ((System.Drawing.Image)(resources.GetObject("playerSprite.Image")));
            this.playerSprite.Location = new System.Drawing.Point(279, 44);
            this.playerSprite.Name = "playerSprite";
            this.playerSprite.Size = new System.Drawing.Size(61, 65);
            this.playerSprite.TabIndex = 19;
            this.playerSprite.TabStop = false;
            // 
            // hpProgressBar
            // 
            this.hpProgressBar.Location = new System.Drawing.Point(12, 44);
            this.hpProgressBar.Name = "hpProgressBar";
            this.hpProgressBar.Size = new System.Drawing.Size(100, 10);
            this.hpProgressBar.TabIndex = 20;
            // 
            // spProgressBar
            // 
            this.spProgressBar.Location = new System.Drawing.Point(12, 79);
            this.spProgressBar.Name = "spProgressBar";
            this.spProgressBar.Size = new System.Drawing.Size(100, 10);
            this.spProgressBar.TabIndex = 21;
            // 
            // expToNextProgressBar
            // 
            this.expToNextProgressBar.Location = new System.Drawing.Point(230, 201);
            this.expToNextProgressBar.Name = "expToNextProgressBar";
            this.expToNextProgressBar.Size = new System.Drawing.Size(136, 12);
            this.expToNextProgressBar.TabIndex = 22;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(904, 649);
            this.Controls.Add(this.expToNextProgressBar);
            this.Controls.Add(this.spProgressBar);
            this.Controls.Add(this.hpProgressBar);
            this.Controls.Add(this.playerSprite);
            this.Controls.Add(this.equipConfirm);
            this.Controls.Add(this.PlayerAcc);
            this.Controls.Add(this.PlayerArmor);
            this.Controls.Add(this.PlayerWeapon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerGold);
            this.Controls.Add(this.PlayerClass);
            this.Controls.Add(this.EXPtoNext);
            this.Controls.Add(this.PlayerLevel);
            this.Controls.Add(this.PlayerSP);
            this.Controls.Add(this.PlayerHP);
            this.Controls.Add(this.PlayerSpeed);
            this.Controls.Add(this.PlayerDefense);
            this.Controls.Add(this.PlayerAttack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemDescription);
            this.Controls.Add(this.ItemsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InventoryForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsList;
        private System.Windows.Forms.Label ItemDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlayerAttack;
        private System.Windows.Forms.Label PlayerDefense;
        private System.Windows.Forms.Label PlayerSpeed;
        private System.Windows.Forms.Label PlayerHP;
        private System.Windows.Forms.Label PlayerSP;
        private System.Windows.Forms.Label PlayerLevel;
        private System.Windows.Forms.Label EXPtoNext;
        private System.Windows.Forms.Label PlayerClass;
        private System.Windows.Forms.Label PlayerGold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PlayerWeapon;
        private System.Windows.Forms.Label PlayerArmor;
        private System.Windows.Forms.Label PlayerAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label equipConfirm;
        private System.Windows.Forms.PictureBox playerSprite;
        private System.Windows.Forms.ProgressBar hpProgressBar;
        private System.Windows.Forms.ProgressBar spProgressBar;
        private System.Windows.Forms.ProgressBar expToNextProgressBar;
    }
}