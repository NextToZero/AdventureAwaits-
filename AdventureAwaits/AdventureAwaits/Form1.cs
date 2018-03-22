using System;
using System.Collections;
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
        public string currentItem;
        public int currentItemDam;
        public int hPotions;
        public int attackDamage;
        
        public MainForm()
        {
            InitializeComponent(); 
            ge.player.Name = Microsoft.VisualBasic.Interaction.InputBox("Select your name Adventurer! ", "Name Select", "Chance");
            playerGB.Text = ge.player.Name;
            ge.player.HP = 100;
            ge.player.HPMax = 100;
            setPotion();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //why do I exist
        }
        private void attackBT_Click(object sender, EventArgs e)
        {
            turnOrder();
        }
        public void turnOrder()
        {
            
            if (monsterHP != 0)
            {
                attack();
                if (monsterHP != 0)
                {
                    monsterAttack();
                }
                
            }
            else
            {
                monsterAttackDescLB.Text = "There is nothing there!";
            }
        }
        public void monsterAttack()
        {
            attackDamage = ge.attack(ge.currentMonster.DamMin, ge.currentMonster.DamMax);
            monsterAttackDescLB.Text = genAttackDesc(ge.currentMonster.Name, ge.player.Name) + " ( " + attackDamage + " damage)";
            if (ge.player.HP >= attackDamage)
            {
                ge.player.HP -= attackDamage;
                PlayerHPPB.Value = ge.player.HP;
                PlayerHPNumLB.Text = ge.player.HP.ToString() + "\\" + ge.player.HPMax;
            }
            else
            {
                PlayerHPPB.Value -= PlayerHPPB.Value;
                ge.player.HP = 0;
                PlayerHPNumLB.Text = ge.player.HP.ToString() + "\\" + ge.player.HPMax;
            }
            if (ge.player.HP <= 0)
            {
                PlayerHPNumLB.Text = "0" + "\\" + ge.player.HPMax;
                MessageBox.Show("You have been vanquished! Try again later!");
                this.Close();
            }
        }
        public void attack()
        {
            attackDamage = ge.attack(ge.player.DamMin,ge.player.DamMax) + currentItemDam;
            playerAttackDescLB.Text = genAttackDesc(ge.player.Name, ge.currentMonster.Name) + " ( " + attackDamage + " damage)";
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

                Loot();
                
                int xp = ge.genExp(ge.currentMonster.Level);
                ge.player.exp += xp;
                PlayerXPNumLB.Text = ge.player.exp.ToString() + "\\" + ge.player.expToLevel.ToString();
                
                if (ge.player.exp >= ge.player.expToLevel)
                {
                    levelUp();
                    PlayerXPPB.Value = ge.player.exp;
                    monsterAttackDescLB.Text = "You've gained " + xp + " experience!" + " You have Leveled Up!";
                }
                else {
                    PlayerXPPB.Value = ge.player.exp;
                    monsterAttackDescLB.Text = "You've gained " + xp + " experience!";
                }
                
                
            }
        }
        private void buttonTest_Click(object sender, EventArgs e)
        { //test button please ignore
            genMonster();
            // heal(20, 50);
            
            
            
        }
        public string genAttackDesc(string dealer, string recipient)
        {
           return dealer + ge.attackDesc() + recipient;
        }
        public void genMonster()
        {
            ge.createMonster();

            MonsterStatusGB.Text = ge.currentMonster.Name;
                
            monsterPicB.Load("..\\Icons\\" + ge.currentMonster.Name + ".png");
            monsterHP = rand.Next(ge.currentMonster.HPMin, ge.currentMonster.HPMax);
            monsterHPMax = monsterHP;
            MonsterHPPB.Maximum = monsterHP;
            MonsterHPPB.Value = monsterHP;
            MonsterHPNumLB.Text = monsterHP + "\\" + monsterHPMax;
        }
        public void heal(int min, int max)
        {
            int healing = ge.heal(min, max);
                ge.player.HP += healing;
            if(ge.player.HP > ge.player.HPMax)
            {
                ge.player.HP = ge.player.HPMax;
                monsterAttackDescLB.Text = "You have healed to full";
            }
            else
            {
                monsterAttackDescLB.Text = "You have healed for " + healing.ToString();
            }
            refreshStats();
        }
        private void PlayerInvListB_SelectedIndexChanged(object sender, EventArgs e)
        {



           // currentItem = ge.player.playerInv[PlayerInvListB.SelectedIndex].Name;
          //  currentItemDam = ge.player.playerInv[PlayerInvListB.SelectedIndex].Dam;
        }
        private void HealB_Click(object sender, EventArgs e)
        {
            if (hPotions > 0)
            {
                heal(75,75);
                hPotions--;
                PotionLB.Text = ("Healing Potions: " + hPotions);
            }
            else
            {
                playerAttackDescLB.Text = "You are out of potions!";
            }
        }
        private void setPotion()
        {
            hPotions = 3;
            PotionLB.Text = ("Healing Potions: " + hPotions);
        }

        private void levelUp()
        {

            ge.levelUp();
            PlayerLevelLB.Text = ge.player.Level.ToString();
            refreshStats();
            

        }

        private void Loot()
        {
            int index = ge.findLoot();
            ge.player.addPlayerInv(ge.LootTable[index], index);
            WeaponVis(index);
		

    }

        private void WeaponVis(int index)
        {

            switch (index)
            {
                case 0:
                    Wep1R.Text = (ge.LootTable[0].Name + "\t" + ge.LootTable[0].Dam.ToString());
                    Wep1R.Visible = true;
                    break;
                case 1:
                    Wep2R.Text = (ge.LootTable[1].Name + "\t" + ge.LootTable[1].Dam.ToString());
                    Wep2R.Visible = true;
                    break;
                case 2:
                    Wep3R.Text = (ge.LootTable[2].Name + "\t" + ge.LootTable[2].Dam.ToString());
                    Wep3R.Visible = true;
                    break;
                case 3:
                    Wep4R.Text = (ge.LootTable[3].Name + "\t" + ge.LootTable[3].Dam.ToString());
                    Wep4R.Visible = true;
                    break;
                case 4:
                    Wep5R.Text = (ge.LootTable[4].Name + "\t" + ge.LootTable[4].Dam.ToString());
                    Wep5R.Visible = true;
                    break;
                default:
                    break;
            }
        }
        private void refreshStats()
        {
            

            PlayerHPPB.Maximum = ge.player.HPMax;
            PlayerHPPB.Value = ge.player.HP;
            PlayerHPNumLB.Text = ge.player.HP.ToString() + "\\" + ge.player.HPMax.ToString();

            PlayerXPPB.Maximum = ge.player.expToLevel;
            PlayerXPPB.Value = ge.player.exp;
            PlayerXPNumLB.Text = ge.player.exp.ToString() + "\\" + ge.player.expToLevel.ToString();

        }




    }
}
