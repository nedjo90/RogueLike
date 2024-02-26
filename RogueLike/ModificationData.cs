namespace RogueLike;

public class ModificationData
{
    public int Value { get; set; }
    public string? NameOfVariable { get; set; }
    public Characteristics? Character { get; set; }
    

    public ModificationData(int value, string nameOfVariable, Characteristics character)
    {
        Value = value;
        NameOfVariable = nameOfVariable;
        Character = character;
    }
}