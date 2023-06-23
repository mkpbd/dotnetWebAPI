using BasicWEBApI.Model;
using BasicWEBApI.Repository.Books;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BasicWEBApI.Controllers
{
    public class BooksController : ControllerBase
    {
        // GET api/books
        [HttpGet]
        [Route("api/books")]
        public IEnumerable<Book> Get() 
        {    
            return  BookRepository.Books.ToList();
        }

        // GET api/books/5
        [HttpGet]
        [Route("{id:int}")]
        public Book Get(int id)
        {
            return BookRepository.Books.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/books
        [HttpPost]
        [Route("api/books")]
        public void  Post(Book book) 
        { 
                var bk = new Book();
        }
    
    }
}
