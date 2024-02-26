using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Interfaces;
using RogueLike.DataManagement.EncounterEvent.Modifier;

namespace RogueLike.DataManagement.EncounterEvent.Removers;

public class Poison : ModifiedData,  IRemovableOn
{
    public static List<ModificationData> RemoveOn(Characteristics character)
    {
        ModifiedDataList = new List<ModificationData>();
        const string variableName = nameof(character.HealthPoints);
        character.HealthPoints -= 50;
        if (character.HealthPoints < 0)
            character.HealthPoints = 0;
        ModificationData data = new ModificationData(-50, variableName, character);
        ModifiedDataList.Add(data);
        return ModifiedDataList;
    }
}