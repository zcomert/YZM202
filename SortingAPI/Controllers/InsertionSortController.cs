using Microsoft.AspNetCore.Mvc;
using SortingAPI.Services;

namespace SortingAPI.Controllers
{
    [ApiController]
    [Route("api/insertionsort")]
    public class InsertionSortController : ControllerBase
    {
        public EmployeeService employeeService;

        public InsertionSortController(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var empArray = employeeService.GetAllEmployee();

                SortingAlgorithms.InsertionSort.Sort(empArray, Utilities.SortDirection.Asceding);
                return Ok(empArray);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
