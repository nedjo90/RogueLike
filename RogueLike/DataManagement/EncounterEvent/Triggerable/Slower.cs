using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Main;

namespace RogueLike.DataManagement.EncounterEvent.Triggerable;

public class Slower : Encounter, ITriggerable, IMeet, ICloneable
{
    private readonly int _slowValue; 

    public Slower()
    {
        _slowValue = GenerateNumber(10, 100);
        Name = LoremNETCore.Generate.Words(1);
    }

    public Slower(int slowValue)
    {
        _slowValue = slowValue;
        Name = LoremNETCore.Generate.Words(1);
    }
    
    public Slower(string name)
    {
        _slowValue = GenerateNumber(10, 100);
        Name = name;
    }
    public Slower(string name, int slowValue)
    {
        _slowValue = slowValue;        
        Name = name;
    }
    public void Trigger(Characteristics character)
    {
        character.Speed += _slowValue;
    }
    
    public void Meet(Adventurer adventurer)
    {
        Trigger(adventurer.Characteristics);
    }

    public override string ToString()
    {
        return $"Speed - {_slowValue} " + base.ToString();
    }
    
    public object Clone()
    {
        return new Slower().Clone();
    }
}