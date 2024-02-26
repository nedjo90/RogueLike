using static RogueLike.Delegator;

namespace RogueLike;

public class CharacteristicsModifier : Encounter, ITriggerable
{
    readonly ActionOnCharacteristics _modifier;

    public ModificationData? ActionData { get; set; }
    public CharacteristicsModifier(string name, ActionOnCharacteristics modifier): base(name)
    {
        _modifier = modifier;
        ActionData = null;
    }
    public void Trigger(Characteristics character)
    {
        ActionData = _modifier(character);
    }

    public override string ToString()
    {
        string toReturn = $"{base.ToString()} => {ActionData.Value} {ActionData.NameOfVariable}";
        return toReturn;
    }
}