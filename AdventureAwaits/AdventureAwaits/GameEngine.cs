using System;
using System.IO;
namespace AdventureAwaits
{
    public class GameEngine
    {
        //public declarations
        public GameEngine()
        {
            
            createMonList();
            readFile("monList");
            genLootTable();

        }
        public Item[] LootTable = new Item[5];
        
        public Player player = new Player("Chance", 100, 100, 5, 10, 1, 0, 100);
        public Random rand = new Random();
        public Monster[] monList = new Monster[9];
        public int attackDamage;
        public String returnMon = "404 MONSTER NOT FOUND";
        public Monster currentMonster = new Monster("test", 1,1,1,1,1);
        public string[] attackList = new string[] { " slices at ",
            " stabs the center of ",
            " lets out a mighty cry and scare ",
            " break-dances aggresively toward ",
            " sweeps the leg of ",
            " can't stop lauging hurtfully at ",
            " stares literal daggers at ",
            " curses vehemently at ",
            " hurls a hot bowl of soup at ",
            " hurts the feelings of ",
            " winks flirtatiously at ",
            " breaks the heart of ",
            " screams excitedly at ",
            " yells out complex math at ",
            " quotes the finest Vogon Poetry at ",
            " cuts at the ",
            " throws phonebooks at the ",
            " gets real with ",
            };
        //Format of Monster = (Name, HPMin, HPMax, DamMin, DamMax)
        public void createMonList()
        {
            for (int i = 0; i < 9; i++) {
                monList[i] = new Monster("Test", 1, 1, 1, 1, 1);
                Console.WriteLine("Created blank MonList Entry: " + i + "\t" + monList[i].Name);
            }
        }
        public void readFile(string inputFile)
        {
            try
            {
                StreamReader reader = new StreamReader(inputFile + ".csv");
                int i = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //Format of Monster = (Name, HPMin, HPMax, DamMin, DamMax)
                    string[] values = line.Split(',');
                    monList[i].Name = values[0];
                    monList[i].HPMin = int.Parse(values[1]);
                    monList[i].HPMax = int.Parse(values[2]);
                    monList[i].DamMin = int.Parse(values[3]);
                    monList[i].DamMax = int.Parse(values[4]);
                    monList[i].Level = int.Parse(values[5]);
                    i++;
                   
                }
                Console.WriteLine("Monster Read From File. Stats are: ");
                for (int x = 0; x < monList.Length; x++)
                {

                    
                    Console.WriteLine("\tName: " + monList[x].Name);
                    Console.WriteLine("\tHPMin: " + monList[x].HPMin);
                    Console.WriteLine("\tHPMax: " + monList[x].HPMax);
                    Console.WriteLine("\tDamMin: " + monList[x].DamMin);
                    Console.WriteLine("\tDamMax: " + monList[x].DamMax);
                    Console.WriteLine("\tLevel: " + monList[x].Level);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        //Creates a monster from the list
        public void createMonster()
        {
            //Format of Monster = (Name, HPMin, HPMax, DamMin, DamMax, Level)
            // clearCurrentMonster();
            int curMonIndex = rand.Next(0, monList.Length);


            currentMonster.Name = monList[curMonIndex].Name;
            currentMonster.HPMin = monList[curMonIndex].HPMin;
            currentMonster.HPMax = monList[curMonIndex].HPMax;
            currentMonster.DamMin = monList[curMonIndex].DamMin;
            currentMonster.DamMax = monList[curMonIndex].DamMax;
            currentMonster.Level = monList[curMonIndex].Level;


            if (monList[curMonIndex].Level > player.Level)
            {
                curMonIndex = rand.Next(0, monList.Length);
                currentMonster.Name = monList[curMonIndex].Name;
                currentMonster.HPMin = monList[curMonIndex].HPMin;
                currentMonster.HPMax = monList[curMonIndex].HPMax;
                currentMonster.DamMin = monList[curMonIndex].DamMin;
                currentMonster.DamMax = monList[curMonIndex].DamMax;
                currentMonster.Level = monList[curMonIndex].Level;

            }

        }
        public int attack(int Min, int Max)
        {
            attackDamage = rand.Next(Min, Max);
            return attackDamage;
        }
        public string attackDesc()
        {
            string returnDesc = attackList[rand.Next(0, attackList.Length)];
            return returnDesc;
        }
        public int heal(int Min, int Max)
        {
            int healTotal = rand.Next(Min, Max);
            return healTotal;
        }
        

        public void levelUp()
        {
                player.Level += 1;
                player.expToLevel *= 2;
                player.exp = 0;
            player.DamMin += 5;
            player.DamMax += 5;
            player.HPMax += 50;
            player.HP = player.HPMax;

        }

        public int genExp(int level)
        {

            int xpOut = 0;
            switch (level)
            {
                case 1:
                    xpOut = rand.Next(10, 25);
                    break;
                case 2:
                    xpOut = rand.Next(30, 60);
                    break;
                case 3:
                    xpOut = rand.Next(70, 150);
                    break;



                default:
                    break;
            }

            return xpOut;
        }

        //unfinished, add to game. If dupe item, add zorkmids
        public void genLootTable()
        {
          
            LootTable[0] = new Item("Iron Sword", 5);
            LootTable[1] = new Item("Steel Rapier", 7);
            LootTable[2] = new Item("Lambda Crowbar", 9);
            LootTable[3] = new Item("Vorpal Knife", 12);
            LootTable[4] = new Item("Weaponized Mojo", 20);
        }

        public int findLoot()
        {
            //Expand to 
            return rand.Next(0, LootTable.Length);

        }

    }
}
