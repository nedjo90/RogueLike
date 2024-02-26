namespace RogueLike.DataManagement.Identity;

public class Identity
{
    public String Name { get; set; }

    public Identity()
    {
        Name = "Name is empty";
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