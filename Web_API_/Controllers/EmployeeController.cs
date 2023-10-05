using Microsoft.AspNetCore.Mvc;
using Web_API_.Model;
using Web_API_.Repository;

namespace Web_API_.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IGenericRepository<Employee> _genericRepository;
        public EmployeeController(IGenericRepository<Employee> employee)
        {
            _genericRepository = employee;

        }

        [HttpGet("all")]
        public IActionResult GetAllEmployee()
        {
            var result = _genericRepository.GetAll();
            if (result.Result != null)
            {
                return Ok(result.Result);
            }
            return NotFound();
        }
        [HttpGet("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var result = _genericRepository.Get(id);
            if (result.Result != null)
            {
                return new JsonResult((Employee)result.Result);
            }
            return NotFound();
        }

        [HttpPost("add")]
        public IActionResult AddEmployee(Employee model)
        {

            //if ( )
            //{

            //}
            _genericRepository.Insert(model);
            return Ok();
        }

        [HttpPost("edit/{id}")]
        public async Task<IActionResult> UpdateEmployee(Employee id)
        {


            await _genericRepository.Update(id);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteEmployee(Guid id)
        {
            var res = await _genericRepository.Delete(id);



            return Ok(res);
        }

        



    }
}
