using System;
public class Player
{
    public Player(string Name, int HP, int HPMax, int DamMin, int DamMax, int Level, int exp, int expToLevel)
    {
        this.Name = Name;
        this.HP = HP;
        this.HPMax = HPMax;
        this.DamMin = DamMin;
        this.DamMax = DamMax;
        this.Level = Level;
        this.exp = exp;
        this.expToLevel = expToLevel;

        for (int i = 0; i < playerInv.Length; i++)
        {
            playerInv[i] = new Item("");
        }

    }

    public Item[] playerInv = new Item[5];
    
    public Item[] getPlayerInv()
    {
        return playerInv;
    }

    public void addPlayerInv(Item addedItem, int index)
    {
        playerInv[index] = addedItem;


    }



    public string Name
    { get; set; }
    public int HP
    { get; set; }
    public int HPMax
    { get; set; }
    public int DamMin
    { get; set; }
    public int DamMax
    { get; set; }
    public int Level
    { get; set; }
    public int exp
    { get; set; }
    public int expToLevel
    { get; set; }





    public string consoleValues()
    {
        return (Name + HP + HPMax + DamMin + DamMax + Level);
    }
}
