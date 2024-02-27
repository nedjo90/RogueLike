using RogueLike.DataManagement.EncounterEvent;
using RogueLike.DataManagement.EncounterEvent.Fightable;
using RogueLike.DataManagement.EncounterEvent.Triggerable;

namespace RogueLike.DataManagement.Random;

public static class Randomizer
{
    public static string GenerateName()
    {
        return LoremNETCore.Generate.Words(1);
    }
    public static int GenerateNumber(int min, int max)
    {
        System.Random random = new System.Random();
        return random.Next(min, max);
    }
    public static int GenerateNumber(int max)
    {
        System.Random random = new System.Random();
        return random.Next(max);
    }

    public static ITriggerable GenerateTriggerable()
    {
        int numberOfClass = 6;
        while (true)
        {
            int number = GenerateNumber(1, numberOfClass);
            switch (number)
            {
                case 1:
                    return new Carer();
                case 2:
                    return new Faster();
                case 3:
                    return new Hurter();
                case 4:
                    return new Slower();
                case 5:
                    return new Trapper();
                case 6:
                    return new Weapon();
            }
        }
    }
    
    public static IMeet GenerateMeetable()
    {
        int numberOfClass = 7;
        while (true)
        {
            int number = GenerateNumber(1, numberOfClass);
            switch (number)
            {
                case 1:
                    return new Carer();
                case 2:
                    return new Faster();
                case 3:
                    return new Hurter();
                case 4:
                    return new Slower();
                case 5:
                    return new Trapper();
                case 6:
                    return new Weapon();
                case 7:
                    return new Monster();
            }
        }
    }
}