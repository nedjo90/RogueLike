using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Interfaces;
using RogueLike.DataManagement.EncounterEvent.Modifier;

namespace RogueLike.DataManagement.EncounterEvent.Removers;

public class Blizzard : ModifiedData, IRemovableOn
{
    public static List<ModificationData> AddOn(Characteristics character)
    {
        ModifiedDataList = new List<ModificationData>();
        const string variableName = nameof(character.Speed);
        int value = -80;
        character.Speed += value;
        ModificationData data = new ModificationData(value, variableName, character);
        ModifiedDataList.Add(data);
        return ModifiedDataList;
    }
}