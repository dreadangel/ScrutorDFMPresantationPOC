namespace ScrutorLib.Services.Domain;

public record User(Guid Id, string Name, int Value)
{
    public Guid Id = Id;
    public string Name = Name;
    public int Value = Value;
}