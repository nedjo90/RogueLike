using System.Runtime.CompilerServices;
using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Main;
using RogueLike.DataManagement.Random;

namespace RogueLike.DataManagement.EncounterEvent.Triggerable;

public class Weapon : Encounter, ITriggerable, IMeet, ICloneable
{
    private readonly int _attackValue; 

    public Weapon()
    {
        _attackValue = GenerateNumber(10, 100);
        Name = LoremNETCore.Generate.Words(1);
    }

    public Weapon(int attackValue)
    {
        _attackValue = attackValue;
        Name = LoremNETCore.Generate.Words(1);
    }
    
    public Weapon(string name)
    {
        _attackValue = GenerateNumber(10, 100);
        Name = name;
    }
    public Weapon(string name, int attackValue)
    {
        _attackValue = attackValue;        
        Name = name;
    }
    public void Trigger(Characteristics character)
    {
        character.Attack = _attackValue;
    }
    

    public void Meet(Adventurer adventurer)
    {
        Trigger(adventurer.Characteristics);
    }

    public override string ToString()
    {
        return $"Attack -> {_attackValue} " + base.ToString();
    }
    
    public object Clone()
    {
        return new Trapper().Clone();
    }
}