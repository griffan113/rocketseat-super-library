using SuperLibrary.DTO;
using SuperLibrary.Entities;
using SuperLibrary.Repositories;

namespace SuperLibrary.Services;

public class CreateBookService {
    private readonly BookRepository _bookRepository = new BookRepository();

    public Book Execute(CreateBookDto dto) {
        var findByTitle = _bookRepository.GetByTitle(dto.Title);

        if (findByTitle != null) throw new BadHttpRequestException("A book with this title already exists.");

        return _bookRepository.Create(dto);
    }
}