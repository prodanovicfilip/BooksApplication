using BooksApplication.WebAPI.DataAccess;
using BooksApplication.WebAPI.DataAccess.Entities;
using BooksApplication.WebAPI.DTOs.Client;
using Microsoft.AspNetCore.Mvc;
using Mapster;

namespace BooksApplication.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly ApiContext _context;
        public ClientController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var output = _context.Clients.ToList();
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
                var output = _context.Clients.Where(c => c.Id == id).FirstOrDefault();
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
        public IActionResult Create([FromBody] ClientDTO model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest();
                }
                var client = model.Adapt<Client>();
                _context.Clients.Add(client);
                _context.SaveChanges();
                return Created();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPost("{id}")]
        public IActionResult Update([FromBody] ClientDTO model, int id)
        {
            try
            {
                if (model == null || id <= 0)
                {
                    return BadRequest();
                }
                var client = _context.Clients.FirstOrDefault(c => c.Id == id);
                if (client == null)
                {
                    return BadRequest();
                }
                model.Adapt(client);
                _context.Clients.Update(client);
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
                var client = _context.Clients.Where(c => c.Id == id).FirstOrDefault();
                if (client == null)
                {
                    return BadRequest();
                }
                _context.Clients.Remove(client);
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
