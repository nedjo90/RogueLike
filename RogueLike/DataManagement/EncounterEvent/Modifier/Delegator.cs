using RogueLike.DataManagement.Characters;

namespace RogueLike.DataManagement.EncounterEvent.Modifier;

public class Delegator
{
    public delegate List<ModificationData> ActionOnCharacteristics(Characteristics character);
}