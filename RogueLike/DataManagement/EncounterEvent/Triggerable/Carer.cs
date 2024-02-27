using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Main;

namespace RogueLike.DataManagement.EncounterEvent.Triggerable;

[Serializable]
public class Carer : Encounter, ITriggerable, IMeet
{
    private readonly int _healthValue; 

    public Carer()
    {
        _healthValue = GenerateNumber(10, 100);
        Name = LoremNETCore.Generate.Words(1);
    }

    public Carer(int healthValue)
    {
        _healthValue = healthValue;
        Name = LoremNETCore.Generate.Words(1);
    }
    
    public Carer(string name)
    {
        _healthValue = GenerateNumber(10, 100);
        Name = name;
    }
    public Carer(string name, int healthValue)
    {
        _healthValue = healthValue;        
        Name = name;
    }
    public void Trigger(Characteristics character)
    {
        character.HealthPoints += _healthValue;
    }
    
    public void Meet(Adventurer adventurer)
    {
        Carer newCarer = new Carer(); 
        Trigger(adventurer.Characteristics);
    }
    
    public override string ToString()
    {
        return $"Health Points + {_healthValue} " + base.ToString();
    }

}