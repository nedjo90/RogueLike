using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Main;

namespace RogueLike.DataManagement.EncounterEvent.Triggerable;

public class Faster : Encounter, ITriggerable, IMeet, ICloneable
{
    private readonly int _fastedValue; 

    public Faster()
    {
        _fastedValue = GenerateNumber(10, 100);
        Name = LoremNETCore.Generate.Words(1);
    }

    public Faster(int fastedValue)
    {
        _fastedValue = fastedValue;
        Name = LoremNETCore.Generate.Words(1);
    }
    
    public Faster(string name)
    {
        _fastedValue = GenerateNumber(10, 100);
        Name = name;
    }
    public Faster(string name, int fastedValue)
    {
        _fastedValue = fastedValue;        
        Name = name;
    }
    public void Trigger(Characteristics character)
    {
        character.Speed += _fastedValue;
    }
    
    public void Meet(Adventurer adventurer)
    {
        Trigger(adventurer.Characteristics);
    }
    
    public override string ToString()
    {
        return $"Speed + {_fastedValue} " + base.ToString();
    }
    
    public object Clone()
    {
        return new Faster().Clone();
    }
}