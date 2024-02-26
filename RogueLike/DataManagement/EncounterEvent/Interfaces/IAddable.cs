using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Modifier;

namespace RogueLike.DataManagement.EncounterEvent.Interfaces;

public interface IAddable
{
    public List<ModificationData> AddOn(Characteristics character);
}