using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Interfaces;
using RogueLike.DataManagement.EncounterEvent.Modifier;

namespace RogueLike.DataManagement.EncounterEvent.Adders;

public class Potion: ModifiedData, IAddable
{
    public List<ModificationData> AddOn(Characteristics character)
    {
        const string variableName = nameof(character.HealthPoints);
        character.HealthPoints += 50;
        if (character.HealthPoints > 100)
            character.HealthPoints = 100;
        ModificationData data = new ModificationData(50, variableName, character);
        ModifiedDataList.Add(data);
        return ModifiedDataList;
    }
}