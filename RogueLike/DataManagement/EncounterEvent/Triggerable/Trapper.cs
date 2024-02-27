using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Main;
using RogueLike.DataManagement.Random;

namespace RogueLike.DataManagement.EncounterEvent.Triggerable;

public class Trapper : Encounter, ITriggerable, IMeet, ICloneable
{
    private readonly int _damageValue; 

    public Trapper()
    {
        _damageValue = Randomizer.GenerateNumber(10, 100);
        Name = LoremNETCore.Generate.Words(1);
    }
    
    public Trapper(int damageValue)
    {
        _damageValue = damageValue;
        Name = LoremNETCore.Generate.Words(1);
    }
    
    public Trapper(string name)
    {
        _damageValue = GenerateNumber(10, 100);
        Name = name;
    }
    public Trapper(string name, int damageValue)
    {
        _damageValue = damageValue;        
        Name = name;
    }
    public void Trigger(Characteristics character)
    {
        character.HealthPoints += _damageValue;
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
        return new Trapper().Clone();
    }
}