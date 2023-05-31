namespace Domain;

public record Item
{
    public int Id { get; }
    private string Name { get; }
    
    public Item(int id, string name) {
        Id = id;
        Name = name;
    }
}

