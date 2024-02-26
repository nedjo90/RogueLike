using RogueLike.DataManagement.Characters;

namespace RogueLike.DataManagement.EncounterEvent.Interfaces;

public interface ITriggerable
{
    public void Trigger(Characteristics Adventurer);
}