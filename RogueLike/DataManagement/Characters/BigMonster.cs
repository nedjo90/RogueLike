using RogueLike.DataManagement.EncounterEvent.Interfaces;
using RogueLike.DataManagement.EncounterEvent.Main;

namespace RogueLike.DataManagement.Characters;

public class BigMonster : Encounter, ITriggerable
{
    public Characteristics Characteristics { get; set; }
    public BigMonster()
    {
        Name = "Big Monster";
        Characteristics = new Characteristics();
    }
    public void Trigger(Characteristics adventurer)
    {
        bool someoneDead = false;
        int i = 0;
        int max = ((Characteristics.Speed > adventurer.Speed) ? Characteristics.Speed : adventurer.Speed);
        // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
        while (!someoneDead)
        {
            if (i > max)
                i = 0;
            if (i % (100 - adventurer.Speed) == 0)
            {
                Characteristics.HealthPoints -= adventurer.Attack;
                Console.WriteLine(adventurer);
            }
            if (i % (100 - Characteristics.Speed) == 0)
                adventurer.HealthPoints -= Characteristics.Attack;
            if (adventurer.HealthPoints == 0 || Characteristics.HealthPoints == 0)
                someoneDead = true;
            i++;
        }

    }
}