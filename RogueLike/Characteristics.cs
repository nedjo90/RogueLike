namespace RogueLike;

public class Characteristics
{
    public int HealthPoints { get; set; } 

    public int Attack { get; set; }

    public int Speed { get; set; }
    
    public List<ITriggerable>? ListOfITriggerables { get; set; }

    public Characteristics(int healthPoints, int attack, int speed, List<ITriggerable>? listOfITriggerables)
    {
        HealthPoints = healthPoints;
        Attack = attack;
        Speed = speed;
        ListOfITriggerables = listOfITriggerables;
    }

    public Characteristics(int healthPoints, int attack, int speed)
    {
        HealthPoints = healthPoints;
        Attack = attack;
        Speed = speed;
        ListOfITriggerables = new List<ITriggerable>();
    }

    public Characteristics()
    {
        HealthPoints = 100;
        Attack = 100;
        Speed = 100;
        ListOfITriggerables = new List<ITriggerable>();
    }

    public override string ToString()
    {
        string characteristics = string.Format(
                "❤️{0, -30}⚔️{1,-30}🏃🏻{2,-30}\n", HealthPoints ,  Attack, Speed
            );
        if(ListOfITriggerables != null)
        {
            characteristics += "Tools:\n";
            foreach (ITriggerable trigger in ListOfITriggerables)
            {
                characteristics += $"- {trigger.ToString()}\n";
            }
        }
        return characteristics;
    }
}