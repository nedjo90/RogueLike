using RogueLike.DataManagement.Characters;

namespace RogueLike.DataManagement.EncounterEvent.Triggerable;

public interface ITriggerable
{
    public void Trigger(Characteristics character);
}