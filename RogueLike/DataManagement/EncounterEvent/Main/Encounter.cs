namespace RogueLike.DataManagement.EncounterEvent.Main;
using RogueLike.DataManagement.Identity;

public abstract class Encounter : Identity
{
    public Encounter()
    {
        Name = LoremNETCore.Generate.Words(1);
    }
    public Encounter(string name) : base(name)
    {
    }
}