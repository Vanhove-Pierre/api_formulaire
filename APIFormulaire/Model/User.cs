namespace APIFormulaire.Model;

public class User
{
    private int id;
    private string lastName;
    private string firstName;

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value;
    }

    public string FirstName
    {
        get => firstName;
        set => firstName = value;
    }

    public User(int id, string lastName, string firstName)
    {
        this.id = id;
        this.lastName = lastName;
        this.firstName = firstName;
    }
}