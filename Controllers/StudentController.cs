using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Database;
using Sample.Services;

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentServices _studentServices;

        public StudentController(IStudentServices studentservices)
        {
            _studentServices = studentservices;
        }
        [HttpPost ("add-product")]
        public async Task<IActionResult> addStudent(Student student)
        {
            try
            {
                var data = await _studentServices.addStudent(student);
                return Ok(data);

            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }

            }

    }
    }
