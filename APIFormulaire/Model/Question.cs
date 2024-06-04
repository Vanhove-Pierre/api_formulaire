namespace APIFormulaire.Model;

public class Question
{
    private int id;
    private string text;
    private string[] choices;

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Text
    {
        get => text;
        set => text = value;
    }

    public string[] Choices
    {
        get => choices;
        set => choices = value;
    }

    public Question(int id, string text, string[]? choices)
    {
        Id = id;
        Text = text;
        Choices = choices ?? [];
    }
}