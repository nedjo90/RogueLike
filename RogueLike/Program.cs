using System.ComponentModel.DataAnnotations;
using RogueLike.DataManagement;
using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent;
using RogueLike.DataManagement.EncounterEvent.Fightable;
using RogueLike.DataManagement.EncounterEvent.Main;
using RogueLike.DataManagement.EncounterEvent.Triggerable;
using RogueLike.DataManagement.Random;
using Characteristics = System.Reflection.PortableExecutable.Characteristics;

namespace RogueLike;

class Program
{
    static void Main(string[] args)
    {
        List<Room> listOfRoom = new List<Room>();
        for (int i = 0; i < 10; i++)
        {
            List<IMeet> listOfMeet = new List<IMeet>();
            for (int j = 0; j < 30; j++)
            {
                listOfMeet.Add(Randomizer.GenerateMeetable());
            }
            Room newRoom = new Room(listOfMeet);
            listOfRoom.Add(newRoom);
        }
            
        Adventurer adventurer = new Adventurer("Indiana Jones");
        Dungeon dungeon = new Dungeon(listOfRoom, adventurer);
        dungeon.Start();
    }
}

