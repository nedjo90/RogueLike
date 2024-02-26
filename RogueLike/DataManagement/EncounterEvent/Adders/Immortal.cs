using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Interfaces;
using RogueLike.DataManagement.EncounterEvent.Modifier;

namespace RogueLike.DataManagement.EncounterEvent.Adders;

public class Immortal : ModifiedData, IAddable
{
    public static List<ModificationData> AddOn(Characteristics character)
    {
        ModifiedDataList = new List<ModificationData>();
        const string variableName = nameof(character.HealthPoints);
        int value = int.MaxValue;
        character.HealthPoints = value;
        ModificationData data = new ModificationData(value, variableName, character);
        ModifiedDataList.Add(data);
        return ModifiedDataList;
    }
}