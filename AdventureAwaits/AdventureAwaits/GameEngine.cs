using System;
namespace AdventureAwaits
{
    public class GameEngine
    {

       public string[] monList = new string[] { "Angry Rabbit", "Severely Snippy Snail", "Diggle", "Grue" };
       public Random rand = new Random();
       public String returnMon = "404 MONSTER NOT FOUND";

        public GameEngine()
        {



        }

        public int monRand()
        {
            
            return rand.Next(1, 5);

        }


        //Creates a monster from the list
        public string createMonster()
        {

           
            switch (monRand())
            {
                case 1:
                    Console.WriteLine("Monster summoned: " + monList[0]);
                    returnMon = monList[0];
                    break;
                case 2:
                    Console.WriteLine("Monster summoned: " + monList[1]);
                    returnMon = monList[1];
                    break;
                case 3:
                    Console.WriteLine("Monster summoned: " + monList[2]);
                    returnMon = monList[2];
                    break;
                case 4:
                    Console.WriteLine("Monster summoned: " + monList[3]);
                    returnMon = monList[3];
                    break;
            }
            return returnMon;
        }




    }
}
