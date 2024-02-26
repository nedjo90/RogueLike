using RogueLike.DataManagement.EncounterEvent.Adders;
using RogueLike.DataManagement.EncounterEvent.Interfaces;
using RogueLike.DataManagement.EncounterEvent.Main;

namespace RogueLike.DataManagement.Characters;
using Identity;


public class LittleMonster : Encounter, ITriggerable
{
    public Characteristics Characteristics { get; set; }

    public LittleMonster()
    {
        Name = "Little Monster";
        Characteristics = new Characteristics(20,20,20);
    }
    public void Trigger(Characteristics Adventurer)
    {
        bool someoneDead = false;
        int i = 0;
        int max = ((Characteristics.Speed > Adventurer.Speed) ? Characteristics.Speed : Adventurer.Speed);
        // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
        while (!someoneDead)
        {
            if (i > max)
                i = 0;
            if (i % (100 - Adventurer.Speed) == 0)
                Characteristics.HealthPoints -= Adventurer.Attack;
            if (i % (100 - Characteristics.Speed) == 0)
                Adventurer.HealthPoints -= Characteristics.Attack;
            if (Adventurer.HealthPoints == 0 || Characteristics.HealthPoints == 0)
                someoneDead = true;
            i++;
        }

    }
}