using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiTest.Data;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreatOldOnesController : ControllerBase
    {
        private ApiDbContext _context;

        public GreatOldOnesController(ApiDbContext context)
        {
            _context = context;
        }

        private static List<GreatOldOne> greatOldOnes = new List<GreatOldOne>
            {
                new GreatOldOne
                {
                    Id = 1,
                    Name = "Cthulu",
                    FirstAppearance = "Call of Cthulu",
                    DangerousScaleOutOfTen = 10,
                    WhereItCurrentlyIs = "R'lyeh",
                    Stage = "Dead , waits dreaming"
                }
            };

        [HttpGet]
 
        

        public async Task<ActionResult<List<GreatOldOne>>> Get()
        {
            //return Ok(greatOldOnes);
            return Ok(await _context.greatOldOnes.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<GreatOldOne>>> Get(int id)
        {
            var greatoldone = await _context.greatOldOnes.FindAsync(id);
            if (greatoldone == null)
            {
                return BadRequest("Great Old Ones not found -- maybe he is sleeping ?");
            }
            return Ok(greatoldone);
        }

        [HttpPost]

        public async Task<ActionResult<List<GreatOldOne>>> AddGreatOldOne(GreatOldOne greatOld)
        {
          
            _context.greatOldOnes.Add(greatOld);
            _context.SaveChanges();
            //_context.Add(greatOld);
            return Ok(greatOldOnes);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<GreatOldOne>>> Delete(int id)
        {
            var greaoldone = await _context.greatOldOnes.FindAsync(id);
            if(greaoldone == null)
            {
                return BadRequest("How dare you stand against me (not found :c)");
            }
            _context.greatOldOnes.Remove(greaoldone);
            _context.SaveChanges();
            return Ok(await _context.greatOldOnes.ToListAsync());
        }


        [HttpPut]

        public async Task<ActionResult<List<GreatOldOne>>> Update(GreatOldOne newgreatoldone)
        {
            var greaoldone = await _context.greatOldOnes.FindAsync(newgreatoldone.Id);

            if (greaoldone == null)
            {
                return BadRequest("You can't change the Great Old One you stupid mortal,we are beyond this (not found :c)");
            }
            greaoldone.Name = newgreatoldone.Name;
            greaoldone.FirstAppearance = newgreatoldone.FirstAppearance;
            greaoldone.DangerousScaleOutOfTen = newgreatoldone.DangerousScaleOutOfTen;
            greaoldone.WhereItCurrentlyIs = newgreatoldone.WhereItCurrentlyIs;
            greaoldone.Stage = newgreatoldone.Stage;
            await _context.SaveChangesAsync();
            return Ok(await _context.greatOldOnes.ToListAsync());

           
        }

    }

}

