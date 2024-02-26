using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent.Adders;
using RogueLike.DataManagement.EncounterEvent.Modifier;
using RogueLike.DataManagement.EncounterEvent.Removers;


namespace RogueLike;

class Program
{
    static void Main(string[] args)
    {
        Adventurer jones = new Adventurer("Jones");
        BigMonster monster = new BigMonster();
        monster.Trigger((jones.Characteristics));
    }
}