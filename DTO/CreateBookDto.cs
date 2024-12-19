using SuperLibrary.Enumerations;

namespace SuperLibrary.DTO;

public class CreateBookDto {
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public BookGender Gender { get; set; }
    public float Price { get; set; }
}