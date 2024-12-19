using SuperLibrary.Enumerations;

namespace SuperLibrary.Entities;

public class Book {
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; }
    public string Author { get; set; }
    public BookGender Gender { get; set; }
    public float Price { get; set; }
    public int StockQuantity { get; set; }
}