using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Interfaces;
using RogueLike.DataManagement.EncounterEvent.Modifier;

namespace RogueLike.DataManagement.EncounterEvent.Adders;

public class Potion: ModifiedData, IAddable
{
    public static List<ModificationData> AddOn(Characteristics character)
    {
            ModifiedDataList = new List<ModificationData>();
           const string variableName = nameof(character.HealthPoints);
           int value = 50;
           character.HealthPoints += value;
           if (character.HealthPoints > 100)
               character.HealthPoints = 100;
           ModificationData data = new ModificationData(value, variableName, character);
           ModifiedDataList.Add(data);
           return ModifiedDataList;
    }
}