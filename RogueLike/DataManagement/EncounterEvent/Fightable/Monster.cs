using System.Diagnostics;
using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Main;

namespace RogueLike.DataManagement.EncounterEvent.Fightable;

public class Monster : Encounter, IMeet, IFightable
{
    Characteristics _character;

    public Monster()
    {
        _character = new Characteristics();
    }
    public Monster(string name)
    {
        Name = name;
        _character = new Characteristics();
    }
    public Monster(string name, Characteristics character)
    {
        Name = name;
        _character = character;
    }
    public void Meet(Adventurer adventurer)
    {
        Fight(adventurer);
    }
    public void Fight(Adventurer adventurer)
    {
        bool bothAlive = true;
        int i = 1;
        // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
        while (bothAlive)
        {
            Console.Clear();
            if (i % 2 == 0)
                _character.HealthPoints -= adventurer.Characteristics.Attack;
            else
            {
                adventurer.Characteristics.HealthPoints -= _character.Attack;
            }
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"{adventurer} => {adventurer.Characteristics}");
            Console.SetCursorPosition(0, 30);
            Console.WriteLine($"{_character}<= {Name}");
            if (adventurer.Characteristics.HealthPoints == 0 || _character.HealthPoints == 0)
                bothAlive = false;
            Thread.Sleep(500);
            i++;
        }
    }
    public Monster Clone()
    {
        return new Monster(Name, _character);
    }
}