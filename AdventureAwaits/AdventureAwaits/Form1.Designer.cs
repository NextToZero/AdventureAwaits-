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
            this.playerGB = new System.Windows.Forms.GroupBox();
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
            this.PlayerHPNumLB = new System.Windows.Forms.Label();
            this.playerGB.SuspendLayout();
            this.MonsterStatusGB.SuspendLayout();
            this.DefMonsterGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerGB
            // 
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
            this.attackBT.Location = new System.Drawing.Point(13, 451);
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
            this.buttonTest.Location = new System.Drawing.Point(95, 451);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(238, 23);
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
            this.InvGB.Location = new System.Drawing.Point(10, 184);
            this.InvGB.Name = "InvGB";
            this.InvGB.Size = new System.Drawing.Size(202, 261);
            this.InvGB.TabIndex = 6;
            this.InvGB.TabStop = false;
            this.InvGB.Text = "Inventory";
            // 
            // DefMonsterGB
            // 
            this.DefMonsterGB.Controls.Add(this.DefMonsterLB);
            this.DefMonsterGB.Location = new System.Drawing.Point(219, 184);
            this.DefMonsterGB.Name = "DefMonsterGB";
            this.DefMonsterGB.Size = new System.Drawing.Size(207, 261);
            this.DefMonsterGB.TabIndex = 7;
            this.DefMonsterGB.TabStop = false;
            this.DefMonsterGB.Text = "Defeated Foes";
            // 
            // DefMonsterLB
            // 
            this.DefMonsterLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DefMonsterLB.Location = new System.Drawing.Point(6, 16);
            this.DefMonsterLB.Name = "DefMonsterLB";
            this.DefMonsterLB.Size = new System.Drawing.Size(194, 238);
            this.DefMonsterLB.TabIndex = 0;
            // 
            // PlayerHPNumLB
            // 
            this.PlayerHPNumLB.AutoSize = true;
            this.PlayerHPNumLB.Location = new System.Drawing.Point(144, 19);
            this.PlayerHPNumLB.Name = "PlayerHPNumLB";
            this.PlayerHPNumLB.Size = new System.Drawing.Size(0, 13);
            this.PlayerHPNumLB.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 488);
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
            this.DefMonsterGB.ResumeLayout(false);
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
    }
}

