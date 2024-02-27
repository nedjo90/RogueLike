namespace RogueLike.DataManagement.Identity;

public class Identity
{
    public String Name { get; set; }

    public Identity()
    {
        Name = LoremNETCore.Generate.Words(1);
    }

    public Identity(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}