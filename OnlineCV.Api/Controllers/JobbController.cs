using Microsoft.AspNetCore.Mvc;
using OnlineCV.Api.Models;
using System;
using System.Linq;


namespace OnlineCV.Api.Controllers
{
    [ApiController]
    [Route("api/jobbcontroller")]
    public class JobbController : ControllerBase
    {
        private readonly JobbLibary _jobb;

        public JobbController(JobbLibary jobb)
        {
            _jobb = jobb;
        }

        // /api/Jobb
        [HttpGet]
        public IActionResult GetAll() => Ok(_jobb.GetAll);

        // /api/Jobb{id}
        [HttpGet("{id}")]
        public IActionResult GetId(int id) => Ok(_jobb.GetAll.FirstOrDefault(x => x.Id.Equals(id)));

        [HttpPost]
        public IActionResult Create([FromBody] Jobb jobb)
        {
            _jobb.Add(jobb);
            return Ok();
        }
        // /api/Jobb
        [HttpPut]
        public IActionResult Update([FromBody] Jobb jobb)
        {
            throw new NotImplementedException();
        }
        // /api/Jobb{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
