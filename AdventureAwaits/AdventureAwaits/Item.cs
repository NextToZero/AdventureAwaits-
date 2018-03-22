using System;
public class Item
{
    public Item(string Name, int Dam)
    {
        this.Name = Name;
        this.Dam = Dam;
    }
    public Item(string Name)
    {
        this.Name = Name;

    }
        public string Name
    { get; set; }
    public int Dam
    { get; set; }
}
