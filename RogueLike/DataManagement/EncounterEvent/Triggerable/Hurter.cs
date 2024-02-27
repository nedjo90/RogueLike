using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Main;

namespace RogueLike.DataManagement.EncounterEvent.Triggerable;

public class Hurter : Encounter, ITriggerable, IMeet, ICloneable
{
    private readonly int _damageValue; 

    public Hurter()
    {
        _damageValue = GenerateNumber(10, 100);
        Name = LoremNETCore.Generate.Words(1);
    }

    public Hurter(int damageValue)
    {
        _damageValue = damageValue;
        Name = LoremNETCore.Generate.Words(1);
    }
    
    public Hurter(string name)
    {
        _damageValue = GenerateNumber(10, 100);
        Name = name;
    }
    public Hurter(string name, int damageValue)
    {
        _damageValue = damageValue;        
        Name = name;
    }
    public void Trigger(Characteristics character)
    {
        character.HealthPoints -= _damageValue;
        if (character.HealthPoints < 0)
            character.HealthPoints = 0;
    }
    
    public void Meet(Adventurer adventurer)
    {
        Trigger(adventurer.Characteristics);
    }
    
    public override string ToString()
    {
        return $"Health Points - {_damageValue} " + base.ToString();
    }
    
    public object Clone()
    {
        return new Hurter().Clone();
    }
}