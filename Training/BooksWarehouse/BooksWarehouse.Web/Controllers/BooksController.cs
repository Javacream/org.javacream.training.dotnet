using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BooksWarehouse.Api;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BooksWebServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksModel model;

        public BooksController(BooksModel model)
        {
            this.model = model;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return model.FindAll();
        }

        [HttpGet("{isbn}")]
        public Book Get(string isbn)
        {
            return model.FindByIsbn(isbn);
        }

        [HttpPost("{title}")]
        public string Post(string title)
        {
            return model.Create(title);
        }

        [HttpPut()]
        public void Put([FromBody] Book book)
        {
            model.Update(book);
        }

        [HttpDelete("{isbn}")]
        public void Delete(string isbn)
        {
            model.DeleteByIsbn(isbn);
        }
    }
}
