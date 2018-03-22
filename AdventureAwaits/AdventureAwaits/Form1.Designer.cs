namespace AdventureAwaits
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.playerGB = new System.Windows.Forms.GroupBox();
            this.PlayerXPNumLB = new System.Windows.Forms.Label();
            this.PlayerLevelLB = new System.Windows.Forms.Label();
            this.expLabel = new System.Windows.Forms.Label();
            this.PlayerXPPB = new System.Windows.Forms.ProgressBar();
            this.PotionLB = new System.Windows.Forms.Label();
            this.PlayerHPNumLB = new System.Windows.Forms.Label();
            this.HPText = new System.Windows.Forms.Label();
            this.PlayerHPPB = new System.Windows.Forms.ProgressBar();
            this.attackBT = new System.Windows.Forms.Button();
            this.MonsterStatusGB = new System.Windows.Forms.GroupBox();
            this.MonsterHPNumLB = new System.Windows.Forms.Label();
            this.MonsterHPPB = new System.Windows.Forms.ProgressBar();
            this.MonsterHPLB = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.playerAttackDescLB = new System.Windows.Forms.Label();
            this.monsterAttackDescLB = new System.Windows.Forms.Label();
            this.InvGB = new System.Windows.Forms.GroupBox();
            this.DefMonsterGB = new System.Windows.Forms.GroupBox();
            this.DefMonsterLB = new System.Windows.Forms.Label();
            this.playerPicBox = new System.Windows.Forms.PictureBox();
            this.monsterPicB = new System.Windows.Forms.PictureBox();
            this.AttackTimer = new System.Windows.Forms.Timer(this.components);
            this.HealB = new System.Windows.Forms.Button();
            this.Wep1R = new System.Windows.Forms.RadioButton();
            this.Wep2R = new System.Windows.Forms.RadioButton();
            this.Wep3R = new System.Windows.Forms.RadioButton();
            this.Wep4R = new System.Windows.Forms.RadioButton();
            this.Wep5R = new System.Windows.Forms.RadioButton();
            this.playerGB.SuspendLayout();
            this.MonsterStatusGB.SuspendLayout();
            this.InvGB.SuspendLayout();
            this.DefMonsterGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterPicB)).BeginInit();
            this.SuspendLayout();
            // 
            // playerGB
            // 
            this.playerGB.Controls.Add(this.PlayerXPNumLB);
            this.playerGB.Controls.Add(this.PlayerLevelLB);
            this.playerGB.Controls.Add(this.expLabel);
            this.playerGB.Controls.Add(this.PlayerXPPB);
            this.playerGB.Controls.Add(this.PotionLB);
            this.playerGB.Controls.Add(this.PlayerHPNumLB);
            this.playerGB.Controls.Add(this.HPText);
            this.playerGB.Controls.Add(this.PlayerHPPB);
            this.playerGB.Location = new System.Drawing.Point(12, 12);
            this.playerGB.Name = "playerGB";
            this.playerGB.Size = new System.Drawing.Size(200, 100);
            this.playerGB.TabIndex = 0;
            this.playerGB.TabStop = false;
            this.playerGB.Text = "Status";
            // 
            // PlayerXPNumLB
            // 
            this.PlayerXPNumLB.AutoSize = true;
            this.PlayerXPNumLB.Location = new System.Drawing.Point(144, 40);
            this.PlayerXPNumLB.Name = "PlayerXPNumLB";
            this.PlayerXPNumLB.Size = new System.Drawing.Size(0, 13);
            this.PlayerXPNumLB.TabIndex = 9;
            // 
            // PlayerLevelLB
            // 
            this.PlayerLevelLB.AutoSize = true;
            this.PlayerLevelLB.Location = new System.Drawing.Point(5, 56);
            this.PlayerLevelLB.Name = "PlayerLevelLB";
            this.PlayerLevelLB.Size = new System.Drawing.Size(45, 13);
            this.PlayerLevelLB.TabIndex = 8;
            this.PlayerLevelLB.Text = "Level: 1";
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(5, 39);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(31, 13);
            this.expLabel.TabIndex = 7;
            this.expLabel.Text = "Exp: ";
            // 
            // PlayerXPPB
            // 
            this.PlayerXPPB.Location = new System.Drawing.Point(38, 39);
            this.PlayerXPPB.Name = "PlayerXPPB";
            this.PlayerXPPB.Size = new System.Drawing.Size(100, 14);
            this.PlayerXPPB.TabIndex = 6;
            this.PlayerXPPB.Value = 100;
            // 
            // PotionLB
            // 
            this.PotionLB.AutoSize = true;
            this.PotionLB.Location = new System.Drawing.Point(7, 84);
            this.PotionLB.Name = "PotionLB";
            this.PotionLB.Size = new System.Drawing.Size(84, 13);
            this.PotionLB.TabIndex = 5;
            this.PotionLB.Text = "Healing Potions:";
            // 
            // PlayerHPNumLB
            // 
            this.PlayerHPNumLB.AutoSize = true;
            this.PlayerHPNumLB.Location = new System.Drawing.Point(144, 19);
            this.PlayerHPNumLB.Name = "PlayerHPNumLB";
            this.PlayerHPNumLB.Size = new System.Drawing.Size(0, 13);
            this.PlayerHPNumLB.TabIndex = 4;
            // 
            // HPText
            // 
            this.HPText.AutoSize = true;
            this.HPText.Location = new System.Drawing.Point(7, 20);
            this.HPText.Name = "HPText";
            this.HPText.Size = new System.Drawing.Size(25, 13);
            this.HPText.TabIndex = 1;
            this.HPText.Text = "HP:";
            // 
            // PlayerHPPB
            // 
            this.PlayerHPPB.Location = new System.Drawing.Point(38, 19);
            this.PlayerHPPB.Name = "PlayerHPPB";
            this.PlayerHPPB.Size = new System.Drawing.Size(100, 14);
            this.PlayerHPPB.TabIndex = 0;
            this.PlayerHPPB.Value = 100;
            // 
            // attackBT
            // 
            this.attackBT.Location = new System.Drawing.Point(10, 437);
            this.attackBT.Name = "attackBT";
            this.attackBT.Size = new System.Drawing.Size(75, 23);
            this.attackBT.TabIndex = 1;
            this.attackBT.Text = "Attack!";
            this.attackBT.UseVisualStyleBackColor = true;
            this.attackBT.Click += new System.EventHandler(this.attackBT_Click);
            // 
            // MonsterStatusGB
            // 
            this.MonsterStatusGB.Controls.Add(this.MonsterHPNumLB);
            this.MonsterStatusGB.Controls.Add(this.MonsterHPPB);
            this.MonsterStatusGB.Controls.Add(this.MonsterHPLB);
            this.MonsterStatusGB.Location = new System.Drawing.Point(226, 12);
            this.MonsterStatusGB.Name = "MonsterStatusGB";
            this.MonsterStatusGB.Size = new System.Drawing.Size(200, 100);
            this.MonsterStatusGB.TabIndex = 2;
            this.MonsterStatusGB.TabStop = false;
            this.MonsterStatusGB.Text = "MonsterName";
            // 
            // MonsterHPNumLB
            // 
            this.MonsterHPNumLB.AutoSize = true;
            this.MonsterHPNumLB.Location = new System.Drawing.Point(144, 19);
            this.MonsterHPNumLB.Name = "MonsterHPNumLB";
            this.MonsterHPNumLB.Size = new System.Drawing.Size(0, 13);
            this.MonsterHPNumLB.TabIndex = 3;
            // 
            // MonsterHPPB
            // 
            this.MonsterHPPB.Location = new System.Drawing.Point(38, 19);
            this.MonsterHPPB.Name = "MonsterHPPB";
            this.MonsterHPPB.Size = new System.Drawing.Size(100, 14);
            this.MonsterHPPB.TabIndex = 1;
            this.MonsterHPPB.Value = 100;
            // 
            // MonsterHPLB
            // 
            this.MonsterHPLB.AutoSize = true;
            this.MonsterHPLB.Location = new System.Drawing.Point(7, 20);
            this.MonsterHPLB.Name = "MonsterHPLB";
            this.MonsterHPLB.Size = new System.Drawing.Size(25, 13);
            this.MonsterHPLB.TabIndex = 0;
            this.MonsterHPLB.Text = "HP:";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(91, 437);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(254, 23);
            this.buttonTest.TabIndex = 3;
            this.buttonTest.Text = "Search the Dungeon";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // playerAttackDescLB
            // 
            this.playerAttackDescLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerAttackDescLB.Location = new System.Drawing.Point(10, 115);
            this.playerAttackDescLB.Name = "playerAttackDescLB";
            this.playerAttackDescLB.Size = new System.Drawing.Size(416, 23);
            this.playerAttackDescLB.TabIndex = 4;
            this.playerAttackDescLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monsterAttackDescLB
            // 
            this.monsterAttackDescLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monsterAttackDescLB.Location = new System.Drawing.Point(10, 157);
            this.monsterAttackDescLB.Name = "monsterAttackDescLB";
            this.monsterAttackDescLB.Size = new System.Drawing.Size(416, 23);
            this.monsterAttackDescLB.TabIndex = 5;
            this.monsterAttackDescLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InvGB
            // 
            this.InvGB.Controls.Add(this.Wep5R);
            this.InvGB.Controls.Add(this.Wep4R);
            this.InvGB.Controls.Add(this.Wep3R);
            this.InvGB.Controls.Add(this.Wep2R);
            this.InvGB.Controls.Add(this.Wep1R);
            this.InvGB.Location = new System.Drawing.Point(10, 289);
            this.InvGB.Name = "InvGB";
            this.InvGB.Size = new System.Drawing.Size(202, 142);
            this.InvGB.TabIndex = 6;
            this.InvGB.TabStop = false;
            this.InvGB.Text = "Inventory";
            // 
            // DefMonsterGB
            // 
            this.DefMonsterGB.Controls.Add(this.DefMonsterLB);
            this.DefMonsterGB.Location = new System.Drawing.Point(219, 289);
            this.DefMonsterGB.Name = "DefMonsterGB";
            this.DefMonsterGB.Size = new System.Drawing.Size(207, 142);
            this.DefMonsterGB.TabIndex = 7;
            this.DefMonsterGB.TabStop = false;
            this.DefMonsterGB.Text = "Defeated Foes";
            // 
            // DefMonsterLB
            // 
            this.DefMonsterLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DefMonsterLB.Location = new System.Drawing.Point(6, 16);
            this.DefMonsterLB.Name = "DefMonsterLB";
            this.DefMonsterLB.Size = new System.Drawing.Size(194, 112);
            this.DefMonsterLB.TabIndex = 0;
            // 
            // playerPicBox
            // 
            this.playerPicBox.Image = global::AdventureAwaits.Properties.Resources.Player;
            this.playerPicBox.Location = new System.Drawing.Point(10, 183);
            this.playerPicBox.Name = "playerPicBox";
            this.playerPicBox.Size = new System.Drawing.Size(100, 100);
            this.playerPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicBox.TabIndex = 8;
            this.playerPicBox.TabStop = false;
            // 
            // monsterPicB
            // 
            this.monsterPicB.Location = new System.Drawing.Point(326, 183);
            this.monsterPicB.Name = "monsterPicB";
            this.monsterPicB.Size = new System.Drawing.Size(100, 100);
            this.monsterPicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monsterPicB.TabIndex = 9;
            this.monsterPicB.TabStop = false;
            // 
            // AttackTimer
            // 
            this.AttackTimer.Enabled = true;
            this.AttackTimer.Interval = 200;
            // 
            // HealB
            // 
            this.HealB.Location = new System.Drawing.Point(351, 437);
            this.HealB.Name = "HealB";
            this.HealB.Size = new System.Drawing.Size(75, 23);
            this.HealB.TabIndex = 10;
            this.HealB.Text = "Heal";
            this.HealB.UseVisualStyleBackColor = true;
            this.HealB.Click += new System.EventHandler(this.HealB_Click);
            // 
            // Wep1R
            // 
            this.Wep1R.AutoSize = true;
            this.Wep1R.Location = new System.Drawing.Point(10, 20);
            this.Wep1R.Name = "Wep1R";
            this.Wep1R.Size = new System.Drawing.Size(85, 17);
            this.Wep1R.TabIndex = 0;
            this.Wep1R.TabStop = true;
            this.Wep1R.Text = "radioButton1";
            this.Wep1R.UseVisualStyleBackColor = true;
            this.Wep1R.Visible = false;
            // 
            // Wep2R
            // 
            this.Wep2R.AutoSize = true;
            this.Wep2R.Location = new System.Drawing.Point(10, 43);
            this.Wep2R.Name = "Wep2R";
            this.Wep2R.Size = new System.Drawing.Size(85, 17);
            this.Wep2R.TabIndex = 1;
            this.Wep2R.TabStop = true;
            this.Wep2R.Text = "radioButton2";
            this.Wep2R.UseVisualStyleBackColor = true;
            this.Wep2R.Visible = false;
            // 
            // Wep3R
            // 
            this.Wep3R.AutoSize = true;
            this.Wep3R.Location = new System.Drawing.Point(10, 66);
            this.Wep3R.Name = "Wep3R";
            this.Wep3R.Size = new System.Drawing.Size(85, 17);
            this.Wep3R.TabIndex = 2;
            this.Wep3R.TabStop = true;
            this.Wep3R.Text = "radioButton3";
            this.Wep3R.UseVisualStyleBackColor = true;
            this.Wep3R.Visible = false;
            // 
            // Wep4R
            // 
            this.Wep4R.AutoSize = true;
            this.Wep4R.Location = new System.Drawing.Point(10, 89);
            this.Wep4R.Name = "Wep4R";
            this.Wep4R.Size = new System.Drawing.Size(85, 17);
            this.Wep4R.TabIndex = 3;
            this.Wep4R.TabStop = true;
            this.Wep4R.Text = "radioButton4";
            this.Wep4R.UseVisualStyleBackColor = true;
            this.Wep4R.Visible = false;
            // 
            // Wep5R
            // 
            this.Wep5R.AutoSize = true;
            this.Wep5R.Location = new System.Drawing.Point(10, 111);
            this.Wep5R.Name = "Wep5R";
            this.Wep5R.Size = new System.Drawing.Size(85, 17);
            this.Wep5R.TabIndex = 4;
            this.Wep5R.TabStop = true;
            this.Wep5R.Text = "radioButton5";
            this.Wep5R.UseVisualStyleBackColor = true;
            this.Wep5R.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 469);
            this.Controls.Add(this.HealB);
            this.Controls.Add(this.monsterPicB);
            this.Controls.Add(this.playerPicBox);
            this.Controls.Add(this.DefMonsterGB);
            this.Controls.Add(this.InvGB);
            this.Controls.Add(this.monsterAttackDescLB);
            this.Controls.Add(this.playerAttackDescLB);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.MonsterStatusGB);
            this.Controls.Add(this.attackBT);
            this.Controls.Add(this.playerGB);
            this.Name = "MainForm";
            this.Text = "Adventure Awaits!";
            this.playerGB.ResumeLayout(false);
            this.playerGB.PerformLayout();
            this.MonsterStatusGB.ResumeLayout(false);
            this.MonsterStatusGB.PerformLayout();
            this.InvGB.ResumeLayout(false);
            this.InvGB.PerformLayout();
            this.DefMonsterGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterPicB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox playerGB;
        private System.Windows.Forms.Label HPText;
        private System.Windows.Forms.ProgressBar PlayerHPPB;
        private System.Windows.Forms.Button attackBT;
        private System.Windows.Forms.GroupBox MonsterStatusGB;
        private System.Windows.Forms.ProgressBar MonsterHPPB;
        private System.Windows.Forms.Label MonsterHPLB;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label MonsterHPNumLB;
        private System.Windows.Forms.Label playerAttackDescLB;
        private System.Windows.Forms.Label monsterAttackDescLB;
        private System.Windows.Forms.GroupBox InvGB;
        private System.Windows.Forms.GroupBox DefMonsterGB;
        private System.Windows.Forms.Label DefMonsterLB;
        private System.Windows.Forms.Label PlayerHPNumLB;
        private System.Windows.Forms.PictureBox playerPicBox;
        private System.Windows.Forms.PictureBox monsterPicB;
        private System.Windows.Forms.Timer AttackTimer;
        private System.Windows.Forms.Button HealB;
        private System.Windows.Forms.Label PotionLB;
        private System.Windows.Forms.Label PlayerLevelLB;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.ProgressBar PlayerXPPB;
        private System.Windows.Forms.Label PlayerXPNumLB;
        private System.Windows.Forms.RadioButton Wep5R;
        private System.Windows.Forms.RadioButton Wep4R;
        private System.Windows.Forms.RadioButton Wep3R;
        private System.Windows.Forms.RadioButton Wep2R;
        private System.Windows.Forms.RadioButton Wep1R;
    }
}

