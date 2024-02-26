namespace RogueLike.DataManagement.EncounterEvent.Main;

public abstract class Encounter : Identity.Identity
{
    public Encounter()
    {
    }
    public Encounter(string name) : base(name)
    {
    }
}