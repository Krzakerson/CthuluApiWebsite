using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiTest.Data;

using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OuterOnesController : ControllerBase
    {
        private ApiDbContext _context;  

        public OuterOnesController(ApiDbContext context)
        {
            _context = context; 
        }

        [HttpGet]

        public async Task<ActionResult<List<OuterGod>>> Get()
        {
            return Ok(await _context.outerOnes.ToListAsync());
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<List<OuterGod>>> GetById(int id)
        {
            var selceted = await _context.outerOnes.FindAsync(id);

            if (selceted == null)
            {
                return NotFound();
            }

            return Ok(selceted);
        }

        [HttpPost]

        public async Task<ActionResult<List<OuterGod>>> Post(OuterGod outerGod)
        {
            _context.outerOnes.Add(outerGod);

            _context.SaveChanges();

            return Ok(await _context.outerOnes.ToListAsync());
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<OuterGod>>> Delete(int id)
        {
            var selected = await _context.outerOnes.FindAsync(id);  

            if(selected == null)
            {
                return NotFound();
            }

            _context.outerOnes.Remove(selected);

            _context.SaveChanges();

            return Ok(await _context.outerOnes.ToListAsync());
        }


        [HttpPut]

        public async Task<ActionResult<List<OuterGod>>> Update(OuterGod outer)
        {
            var selcted = await _context.outerOnes.FindAsync(outer.Id); 

            if(selcted == null)
            {
                return BadRequest();
            }

            selcted.Name = outer.Name;
            selcted.powers = outer.powers;
            selcted.FirstAppearance = outer.FirstAppearance;
            selcted.DangerousScaleOutOfTen = outer.DangerousScaleOutOfTen;

            _context.SaveChanges();

            return Ok(await _context.outerOnes.ToListAsync());
        }


    }
}
