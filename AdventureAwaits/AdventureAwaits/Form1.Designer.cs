namespace AdventureAwaits
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HPText = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.attackBT = new System.Windows.Forms.Button();
            this.MonsterStatusGB = new System.Windows.Forms.GroupBox();
            this.MonsterHPNumLBMax = new System.Windows.Forms.Label();
            this.MonsterHPPB = new System.Windows.Forms.ProgressBar();
            this.MonsterHPLB = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.MonsterHPNumLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.MonsterStatusGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HPText);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 14);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 100;
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
            this.MonsterStatusGB.Controls.Add(this.MonsterHPNumLBMax);
            this.MonsterStatusGB.Controls.Add(this.MonsterHPPB);
            this.MonsterStatusGB.Controls.Add(this.MonsterHPLB);
            this.MonsterStatusGB.Location = new System.Drawing.Point(13, 267);
            this.MonsterStatusGB.Name = "MonsterStatusGB";
            this.MonsterStatusGB.Size = new System.Drawing.Size(200, 100);
            this.MonsterStatusGB.TabIndex = 2;
            this.MonsterStatusGB.TabStop = false;
            this.MonsterStatusGB.Text = "MonsterName";
            // 
            // MonsterHPNumLBMax
            // 
            this.MonsterHPNumLBMax.AutoSize = true;
            this.MonsterHPNumLBMax.Location = new System.Drawing.Point(160, 19);
            this.MonsterHPNumLBMax.Name = "MonsterHPNumLBMax";
            this.MonsterHPNumLBMax.Size = new System.Drawing.Size(0, 13);
            this.MonsterHPNumLBMax.TabIndex = 2;
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
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 3;
            this.buttonTest.Text = "TestButton";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // MonsterHPNumLB
            // 
            this.MonsterHPNumLB.AutoSize = true;
            this.MonsterHPNumLB.Location = new System.Drawing.Point(144, 19);
            this.MonsterHPNumLB.Name = "MonsterHPNumLB";
            this.MonsterHPNumLB.Size = new System.Drawing.Size(0, 13);
            this.MonsterHPNumLB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 486);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.MonsterStatusGB);
            this.Controls.Add(this.attackBT);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MonsterStatusGB.ResumeLayout(false);
            this.MonsterStatusGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label HPText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button attackBT;
        private System.Windows.Forms.GroupBox MonsterStatusGB;
        private System.Windows.Forms.ProgressBar MonsterHPPB;
        private System.Windows.Forms.Label MonsterHPLB;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label MonsterHPNumLBMax;
        private System.Windows.Forms.Label MonsterHPNumLB;
    }
}

