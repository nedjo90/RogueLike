using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Interfaces;
using RogueLike.DataManagement.EncounterEvent.Modifier;

namespace RogueLike.DataManagement.EncounterEvent.Adders;

public class SuperPotion: ModifiedData ,IAddable
{
    public List<ModificationData> AddOn(Characteristics character)
    {
        character.HealthPoints = 100;
        ModificationData data = new ModificationData(100, nameof(character.HealthPoints), character);
        ModifiedDataList.Add(data);
        return ModifiedDataList;
    }
}