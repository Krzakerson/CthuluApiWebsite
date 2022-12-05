using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiTest.Data;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreatOnesController : ControllerBase
    {
        private ApiDbContext _context;

        public GreatOnesController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<GreatOne>>> Get()
        {
            return Ok(await _context.greatOnes.ToListAsync());  
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<List<GreatOne>>> GetById(int id)
        {
            var selected = _context.greatOnes.FindAsync(id);

            if(selected == null)
            {
                return NotFound();
            }

            

            return Ok(selected);
        }

        [HttpPost]

        public async Task<ActionResult<List<GreatOne>>> Post(GreatOne greatOne)
        {
            _context.greatOnes.Add(greatOne);   
            _context.SaveChanges();
            return Ok(await _context.greatOnes.ToListAsync());
        }

        [HttpPut]

        public async Task<ActionResult<List<GreatOne>>> Update(GreatOne newgreatone)
        {
            var greatOne = await _context.greatOnes.FindAsync(newgreatone.Id);

            if (greatOne == null)
            {
                return BadRequest("You can't change the Great One you stupid mortal,we are beyond this");
            }
            greatOne.Name = newgreatone.Name;
            greatOne.className = newgreatone.className;
            greatOne.FirstAppearance = newgreatone.FirstAppearance;
            greatOne.DangerousScaleOutOfTen = newgreatone.DangerousScaleOutOfTen;
            _context.SaveChanges();
            return Ok(await _context.greatOnes.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<GreatOne>>> Delete (int id)
        {
            var greatonetodel = await _context.greatOnes.FindAsync(id);  
            
            if(greatonetodel == null)
            {
                return BadRequest("How dare you stand against me (not found :c)");
            }

            _context.greatOnes.Remove(greatonetodel);
            _context.SaveChanges();
            return Ok(await _context.greatOnes.ToListAsync());
        }
    }
}
