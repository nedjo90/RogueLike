namespace RogueLike.DataManagement.Characters;
using Identity;


public class Adventurer : Identity
{
    public Characteristics Characteristics { get; set; }

    public Adventurer()
    {
        Name = LoremNETCore.Generate.Words(1);
        Characteristics = new Characteristics();
    }
    public Adventurer(string name) : base(name)
    {
        Characteristics = new Characteristics();
    }
    public Adventurer(string name, Characteristics characteristics) : base(name) 
    {
        Characteristics = characteristics;
    }

    public override string ToString()
    {
        return $"{Name} :";
    }
}