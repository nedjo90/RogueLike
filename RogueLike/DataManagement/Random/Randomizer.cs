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
}