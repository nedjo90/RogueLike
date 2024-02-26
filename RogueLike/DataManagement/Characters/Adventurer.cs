namespace RogueLike.DataManagement.Characters;

public class Adventurer : Identity.Identity
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