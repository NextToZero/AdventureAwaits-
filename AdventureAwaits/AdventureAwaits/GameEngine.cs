using System;
namespace AdventureAwaits
{
    public class GameEngine
    {
        //public declarations


        public int attackDamage;

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
            };

        //public string[] monList = new string[] {
        //     "Angry Rabbit",
        //     "Severely Snippy Snail",
        //     "Diggle",
        //     "Grue",
        //     "Sand Worm",
        //     "Murloc",
        //     "Mathemagical Mage",
        //     "Sleazy Lawyer",
        //     "Testificate",
        //     "Rabid Pokemon",
        //     "Irritable Professor",
        //     "Spooky Scary Skeleton",
        //     "Grid Bug",
        //     "Angry Orange Cheeto",
        //     "Cali Cartel Godfather"};

        public Monster[] monList = new Monster[3];
        //Format of Monster = (Name, HPMin, HPMax, DamMin, DamMax)
        public void popMonList()
        {
            monList[0] = new Monster("Grue", 50, 75, 10, 20);
            monList[1] = new Monster("Diggle", 50, 75, 10, 20);
            monList[2] = new Monster("Angry Rabbit", 50, 75, 10, 20);
        }




        public String returnMon = "404 MONSTER NOT FOUND";
        public string[] currentMonster = new string[5];





        public GameEngine()
        {
            popMonList();
            createMonster();


        }

        public Random rand = new Random();


        //Creates a monster from the list
        public void createMonster()
        {
            //Format of Monster = (Name, HPMin, HPMax, DamMin, DamMax)
      
            int curMonIndex = rand.Next(0, monList.Length);
            currentMonster[0] = monList[curMonIndex].Name;
            currentMonster[1] = monList[curMonIndex].HPMin.ToString();
            currentMonster[2] = monList[curMonIndex].HPMax.ToString();
            currentMonster[3] = monList[curMonIndex].DamMin.ToString();
            currentMonster[4] = monList[curMonIndex].DamMax.ToString();
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


    }
}
