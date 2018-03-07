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


    public partial class MainForm : Form
    {

        //Declaration of public variables/rands/classes
        public GameEngine ge = new GameEngine();
        public Random rand = new Random();
        public int monsterHP;
        public int monsterHPMax;
        public int playerHP;
        public int playerHPMax;
        public int attackDamage;
        public string currentMonster;
        public string playerName;
        
        public MainForm()
        {
            InitializeComponent();
            playerName = Microsoft.VisualBasic.Interaction.InputBox("Select your name Adventurer! ", "Name Select", "Chance");
            playerGB.Text = playerName;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //why do I exist
        }

        private void attackBT_Click(object sender, EventArgs e)
        {
            //main attack button --> Sort into GE class 

            attack();
            monsterAttack();
        }

        public void monsterAttack()
        {

            attackDamage = ge.attack();
            monsterAttackDescLB.Text = genAttackDesc(currentMonster, playerName) + " ( " + attackDamage + " damage)";

        }
        public void attack()
        {
            attackDamage = ge.attack();
            playerAttackDescLB.Text = genAttackDesc(playerName, currentMonster) + " ( " + attackDamage + " damage)";
            if (monsterHP >= attackDamage)
            {
                monsterHP -= attackDamage;
                MonsterHPPB.Value = monsterHP;
                MonsterHPNumLB.Text = monsterHP.ToString()+ "\\" + monsterHPMax;


            }
            else
            {
                MonsterHPPB.Value -= MonsterHPPB.Value;
                monsterHP = 0 ;
                MonsterHPNumLB.Text = monsterHP.ToString() + "\\" + monsterHPMax;
            }
            if (monsterHP <= 0)
            {
                DefMonsterLB.Text += MonsterStatusGB.Text + "\n";
                MonsterHPNumLB.Text = "0" + "\\" + monsterHPMax;
                playerAttackDescLB.Text = "You have defeated the voracious beast!";
                genMonster();

            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            genMonster();
        }





            

            
            
        

        

        public string genAttackDesc(string dealer, string recipient)
        {

           return dealer + ge.attackDesc() + recipient;
            

        }
        public void genMonster()
        {
            currentMonster = (ge.createMonster());
            MonsterStatusGB.Text = currentMonster;
            monsterHP = rand.Next(1, 100);
            monsterHPMax = monsterHP;
            MonsterHPPB.Maximum = monsterHP;
            MonsterHPPB.Value = monsterHP;
            MonsterHPNumLB.Text = monsterHP + "\\" + monsterHPMax;

        }
    }
}
