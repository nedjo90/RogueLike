using RogueLike.DataManagement.Characters;

namespace RogueLike.DataManagement.EncounterEvent.Fightable;

public interface IFightable
{
    public void Fight(Adventurer adventurer);
}