using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureAwaits
{


    public partial class Form1 : Form
    {
       public GameEngine ge = new GameEngine();
        public Random rand = new Random();
        public int monsterHP;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void attackBT_Click(object sender, EventArgs e)
        {

            if (MonsterHPPB.Value >= 10)
            {
                MonsterHPPB.Value -= 10;
                monsterHP -= 10;
                MonsterHPNumLB.Text = monsterHP.ToString();

                
            }
            else
            {
                MonsterHPPB.Value -= MonsterHPPB.Value;
                monsterHP -= MonsterHPPB.Value;
                MonsterHPNumLB.Text = monsterHP.ToString();
            }
            if (MonsterHPPB.Value <= 0)
            {
                    MessageBox.Show("You have defeated the voracious beast!");
                    this.Close();

            }
        }




        private void buttonTest_Click(object sender, EventArgs e)
        {
            MonsterStatusGB.Text = (ge.createMonster());
            MonsterHPNumLBMax.Text = (monRand());
        }



        public string monRand()
        {

            int finalHP = rand.Next(1, 100);
            MonsterHPPB.Maximum = finalHP;
            MonsterHPPB.Value = finalHP;
            MonsterHPNumLB.Text = finalHP.ToString();
            monsterHP = finalHP;

            String toString = ("\\" + finalHP);
            return toString;

        }
    }
}
