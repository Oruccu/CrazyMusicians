using Microsoft.AspNetCore.Mvc;
using CrazyMusicians.Data;
using System.Collections.Generic;

namespace CrazyMusicians.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrazyMusiciansController : ControllerBase
    {
        //GET: api/CrazyMusicians
        [HttpGet]
        public List<CrazyMusician> Get()
        {
            return DataList.GetCrazyMusicians();
        }

        //GET: api/CrazyMusicians/2
        [HttpGet("{id}")]
        public ActionResult<CrazyMusician> Get(int id)
        {
            CrazyMusician? crazyMusician = DataList.GetCrazyMusicians().FirstOrDefault(c => c.Id == id);
            if (crazyMusician == null)
            {
                return NotFound();
            }
            return Ok(crazyMusician);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CrazyMusician updateCrazyMusician)
        {
            var crazyMusician = DataList.GetCrazyMusicians().FirstOrDefault(c => c.Id == id);
            if (crazyMusician == null)
            {
                return NotFound();
            }
            crazyMusician.Name = updateCrazyMusician.Name;
            crazyMusician.Profession = updateCrazyMusician.Profession;
            crazyMusician.Property = updateCrazyMusician.Property;
            return NoContent();
        }

        [HttpPost]
        public ActionResult<CrazyMusician> Post([FromBody] CrazyMusician crazyMusician)
        {
            crazyMusician.Id = DataList.GetCrazyMusicians().Max(c => c.Id) + 1;
            DataList.GetCrazyMusicians().Add(crazyMusician);
            return CreatedAtAction(nameof(Get), new { id = crazyMusician.Id }, crazyMusician);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id){
            var deleteCrazyMusician = DataList.GetCrazyMusicians().FirstOrDefault(c => c.Id==id);
            if (deleteCrazyMusician == null) return NotFound();
            DataList.GetCrazyMusicians().Remove(deleteCrazyMusician);
            return NoContent();
        }
    }
}
