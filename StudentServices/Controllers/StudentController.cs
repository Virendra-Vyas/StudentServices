using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentServices.Data;
using StudentServices.Data.Models;

namespace StudentServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Students>> Get()
        {
            try
            {
                return Ok(_repository.GetStudents());
            }
            catch(Exception ex)
            {
                return BadRequest($"Failed to get Students Record: { ex }");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Students model)
        {
            try
            {
                _repository.addStudent(model);
                if(_repository.SaveAll())
                {
                    return Created($"/api/student/{model.Id}", model);
                }
            }
            catch(Exception ex)
            {
                return BadRequest($"Failed to get Students Record: { ex }");
            }

            return BadRequest("Failed to get Students Record");
        }
    }
}