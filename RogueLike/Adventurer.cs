namespace RogueLike;

public class Adventurer : Identity
{
    public Characteristics Characteristics { get; set; }
    public Adventurer(string name, Characteristics characteristics) : base(name)
    {
        Characteristics = characteristics;
    }
    // public Adventurer(Characteristics characteristics)
    // {
    //     Characteristics = characteristics;
    // }
}