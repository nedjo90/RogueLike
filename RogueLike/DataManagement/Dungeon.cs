using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent;
using RogueLike.DataManagement.EncounterEvent.Triggerable;
using RogueLike.DataManagement.Random;

namespace RogueLike.DataManagement;

public class Dungeon : Identity.Identity
{
    public List<Room> ListOfRooms { get; set; }

    public Adventurer Adventurer { get; set; }


    public Dungeon(List<Room> listOfRooms, Adventurer adventurer)
    {
        Adventurer = adventurer;
        ListOfRooms = listOfRooms;
    }
    public void Start()
    {
        foreach (Room room in ListOfRooms)
        {
            room.CrossTheRoom(Adventurer);
            Thread.Sleep(500);
            if (Adventurer.Characteristics.HealthPoints == 0)
            {
                Console.WriteLine("You're dead loser! 👎🏻");
                return;
            }
        }
    }
}