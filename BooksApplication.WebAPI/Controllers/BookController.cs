using BooksApplication.WebAPI.DataAccess;
using BooksApplication.WebAPI.DataAccess.Entities;
using BooksApplication.WebAPI.DTOs.Book;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksApplication.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ApiContext _context;

        public BookController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var output = _context.Books.ToList();
                if (output.Any())
                {
                    return Ok(output);
                }
                return NotFound();
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var output = _context.Books.Where(b => b.Id == id).FirstOrDefault();
                if (output == null)
                {
                    return NotFound();
                }
                return Ok(output);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPost]
        public IActionResult Create([FromBody] BookDTO model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest();
                }
                var book = model.Adapt<Book>();
                _context.Books.Add(book);
                _context.SaveChanges();
                return Created();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPost("{id}")]
        public IActionResult Update([FromBody]BookDTO model, int id)
        {
            try
            {
                if (model == null || id <= 0)
                {
                    return BadRequest();
                }
                var book = _context.Books.FirstOrDefault(b => b.Id == id);
                if (book == null)
                {
                    return BadRequest();
                }
                model.Adapt(book);//book.Author = model.Author; ...
                _context.Books.Update(book);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest();
                }
                var book = _context.Books.Where(b => b.Id == id).FirstOrDefault();
                if (book == null)
                {
                    return BadRequest();
                }
                _context.Books.Remove(book);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
