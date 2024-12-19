using SuperLibrary.DTO;
using SuperLibrary.Entities;

namespace SuperLibrary.Repositories;

public class BookRepository {
    private readonly List<Book> _data = [];

    public Book Create(CreateBookDto createBookDto) {
        var newBook = new Book {
            Title = createBookDto.Title,
            Author = createBookDto.Author,
            Gender = createBookDto.Gender,
            Price = createBookDto.Price,
            StockQuantity = 0,
        };

        _data.Add(newBook);

        return newBook;
    }

    public void Delete(Guid id) {
        var book = GetById(id);

        if (book == null) throw new BadHttpRequestException("Book not found.");

        _data.Remove(book);
    }

    public List<Book> GetAll() {
        return _data;
    }

    public Book? GetById(Guid id) {
        return _data.FirstOrDefault(x => x.Id == id);
    }

    public Book? GetByTitle(string title) {
        return _data.FirstOrDefault(x => string.Equals(x.Title, title, StringComparison.CurrentCultureIgnoreCase));
    }
}