using SuperLibrary.Repositories;

namespace SuperLibrary.Services;

public class DeleteBookService {
    private readonly BookRepository _bookRepository = new BookRepository();

    public void Execute(Guid id) {
        _bookRepository.Delete(id);
    }
}