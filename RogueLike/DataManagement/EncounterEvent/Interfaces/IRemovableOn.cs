using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Modifier;

namespace RogueLike.DataManagement.EncounterEvent.Interfaces;

public interface IRemovableOn
{
    public List<ModificationData> RemoveOn(Characteristics character);
}