using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiTest.Data;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoriesController : ControllerBase
    {
        private ApiDbContext _context;

        public StoriesController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Story>>> Get()
        {
            return Ok(await _context.stories.ToListAsync());
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<List<Story>>> GetById(int id)
        {
            var selcted = await _context.stories.FindAsync(id);

            return Ok(selcted);
        }

        [HttpPost]

        public async Task<ActionResult<List<Story>>> Post(Story story)
        {
            _context.Add(story);
            _context.SaveChanges();
            return Ok(await _context.stories.ToListAsync());
        }

        [HttpPut]

        public async Task<ActionResult<List<Story>>> Update(Story newstory)
        {
            var story = await _context.stories.FindAsync(newstory.Id);
            if(story == null)
            {
                return BadRequest("You dont have acces to this epic story (not found)");
            }
            story.Name = newstory.Name;
            story.CreationTime = newstory.CreationTime;
            _context.SaveChanges();
            return Ok(await _context.stories.ToListAsync());

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Story>>> Delete(int id)
        {
            var stroytodel = await _context.stories.FindAsync(id);  
            if(stroytodel == null)
            {
                return BadRequest("You cant delete this epic story (not found)");
            }
            _context.Remove(stroytodel);
            _context.SaveChanges();
            return Ok(await _context.stories.ToListAsync());    
        }
    }
}
