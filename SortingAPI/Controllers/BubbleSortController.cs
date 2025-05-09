using Microsoft.AspNetCore.Mvc;
using SortingAPI.Models;
using SortingAPI.Services;

namespace SortingAPI.Controllers
{
    [ApiController]
    [Route("api/bubblesort")]
    public class BubbleSortController : ControllerBase
    {
        public EmployeeService employeeService;

        public BubbleSortController(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var empArray = employeeService.GetAllEmployee();
                SortingAlgorithms.BubbleSort.Sort(empArray);
                return Ok(empArray);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Employee employee) {
            try
            {
                employeeService.EmployeeAdd(employee);
                return Created();
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
