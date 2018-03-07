using System;
namespace AdventureAwaits
{
    public class Monster
    {

        private int HPMin, HPMax, DamMin, DamMax;
        private string Name;




        public Monster(string Name, int HPMin, int HPMax, int DamMin, int DamMax)
        {

            this.Name = Name;
            this.HPMin = HPMin;
            this.HPMax = HPMax;
            this.DamMin = DamMin;
            this.DamMax = DamMax;
        }

        //public string Name
        //{
        //    get { return Name; }
        //    set { Name = value; }
        //}
        //public string HPMin
        //{
        //    get { return HPMin; }
        //    set { HPMin = value; }
        //}
        //public string HPMax
        //{
        //    get { return HPMax; }
        //    set { HPMax = value; }
        //}
        //public string DamMin
        //{
        //    get { return DamMin; }
        //    set { DamMin = value; }
        //}
        //public string DamMax
        //{
        //    get { return DamMax; }
        //    set { DamMax = value; }
        //}






    }


    
}