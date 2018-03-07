using System;
namespace AdventureAwaits
{
    public class Monster
    {

        
       



        public Monster(string Name, int HPMin, int HPMax, int DamMin, int DamMax)
        {

            this.Name = Name;
            this.HPMin = HPMin;
            this.HPMax = HPMax;
            this.DamMin = DamMin;
            this.DamMax = DamMax;
        }

        public string Name
        {get; set;}
        public int HPMin
        { get; set; }
        public int HPMax
        { get; set; }
        public int DamMin
        { get; set; }
        public int DamMax
        { get; set; }






    }


    
}