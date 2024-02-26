namespace RogueLike;

public static class Randomizer
{
    public static string GenerateName()
    {
        return LoremNETCore.Generate.Words(1);
    }
    public static int GenerateNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
    public static int GenerateNumber(int max)
    {
        Random random = new Random();
        return random.Next(max);
    }
}