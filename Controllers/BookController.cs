using Microsoft.AspNetCore.Mvc;
using SuperLibrary.Communication.Requests;
using SuperLibrary.Entities;
using SuperLibrary.Services;

namespace SuperLibrary.Controllers;

public class BookController : SuperLibraryBaseController {
    private readonly CreateBookService _createBookService = new();
    private readonly DeleteBookService _deleteBookService = new();
    
    [HttpGet]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Index([FromBody] RequestCreateBookJson request) {
        var createNewBook = _createBookService.Execute(request);
        
        return Created(string.Empty, createNewBook);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] Guid id) {
        _deleteBookService.Execute(id);
        
        return NoContent();
    }
}