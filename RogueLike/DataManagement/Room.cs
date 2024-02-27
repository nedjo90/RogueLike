using RogueLike.DataManagement.Characters;
using RogueLike.DataManagement.EncounterEvent;
using RogueLike.DataManagement.EncounterEvent.Triggerable;


namespace RogueLike.DataManagement;

public class Room : Identity.Identity
{
    public List<IMeet> ListOfMeet { get; set; }

    public Room(List<IMeet> listOfMeet)
    {
        ListOfMeet = listOfMeet;
    }

    public void CrossTheRoom(Adventurer adventurer)
    {
        adventurer.Characteristics.HealthPoints = 50000;
        List<IMeet> listOfAlreadyMeet = new List<IMeet>();
        foreach (IMeet meet in ListOfMeet)
        {
            
            Console.Clear();
            Console.WriteLine($"{adventurer.Name}\t{adventurer.Characteristics}" +
                              $"Enter in the {Name} room");
            Thread.Sleep(500);
            meet.Meet(adventurer);
            Console.WriteLine(meet.ToString());
            Thread.Sleep(500);
            if (adventurer.Characteristics.HealthPoints == 0)
            {
                return ;
            }
        }
    }
}