using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Interfaces;
using RogueLike.DataManagement.EncounterEvent.Main;
using static RogueLike.DataManagement.EncounterEvent.Modifier.Delegator;

namespace RogueLike.DataManagement.EncounterEvent.Modifier;

public class CharacteristicsModifier : Encounter, ITriggerable
{
    readonly ActionOnCharacteristics _modifier;
    public List<ModificationData> ListOfActionData { get; set; }
    
    public CharacteristicsModifier(string name, ActionOnCharacteristics modifier): base(name)
    {
        _modifier = modifier;
        ListOfActionData = new List<ModificationData>();
    }
    public void Trigger(Characteristics character)
    {
        ListOfActionData = _modifier(character);
    }

    public override string ToString()
    {
        string modificationInfo = $"{base.ToString()}";
        foreach (ModificationData data in ListOfActionData)
        {
            modificationInfo += (data.Value >= 0) ? " +" : " ";
            modificationInfo += $"{data.Value} " +
                                $" {data.NameOfVariable}";
        }
        return modificationInfo;
    }
}