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

        public string[] monList = new string[] {
             "Angry Rabbit",
             "Severely Snippy Snail",
             "Diggle",
             "Grue",
             "Sand Worm",
             "Murloc",
             "Mathemagical Mage",
             "Sleazy Lawyer",
             "Testificate",
             "Rabid Pokemon",
             "Irritable Professor",
             "Spooky Scary Skeleton",
             "Grid Bug"};





        public String returnMon = "404 MONSTER NOT FOUND";
        





        public GameEngine()
        {

            Monster[] monList = new Monster[3];

        }

        public Random rand = new Random();


        //Creates a monster from the list
        public string createMonster()
        {

            string returnMonster = monList[rand.Next(0, monList.Length)];
            return returnMonster;

        }

        public int attack()
        {

            attackDamage = rand.Next(4, 10);
            return attackDamage;

        }


        public string attackDesc()
        {

            string returnDesc = attackList[rand.Next(0, attackList.Length)];
            return returnDesc;
        }


    }
}
