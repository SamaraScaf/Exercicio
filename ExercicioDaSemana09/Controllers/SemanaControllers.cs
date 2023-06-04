using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioDaSemana09.Model;
using Microsoft.AspNetCore.Mvc;

namespace ExercicioDaSemana09.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SemanaController : ControllerBase
    {
        private readonly SemanaContext semanaContext;

        public SemanaController(SemanaContext semanaContext)
        {
            this.semanaContext = semanaContext;
        }
        [HttpGet]
            public ActionResult Get()
            {
                return Ok();
            }

        [HttpGet("{id}")]
            public ActionResult Get([FromRoute] int id)
            {
                return Ok();
            }
        [HttpPost("POST")]
        public ActionResult Post([FromBody] SemanaModel semanaModel)
            {
             if (semanaModel.Id > 0)
                {
                    return Ok(true);
                }
                {
                    return BadRequest("ID tem que ser maior que 0");
                }
            }
        [HttpPut("PUT")]
        public ActionResult Put([FromBody] SemanaModel semanaModel)
        {
           if (semanaModel.Id != 0)
                {
                    return Ok(true);
                }
                {
                    return BadRequest("ID tem que ser maior que 0");
                }
        }
        [HttpDelete("DELETE")]
        public ActionResult Delete(int id)
        {
            var Id = semanaContext.Semana.Find(id);

            if (Id == null)
            {
                return NotFound();
            }

            semanaContext.Semana.Remove(Id);
            semanaContext.SaveChanges();

            return NoContent();
        }
    }
}