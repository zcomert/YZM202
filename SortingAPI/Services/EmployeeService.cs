using SortingAPI.Models;

namespace SortingAPI.Services
{
    public class EmployeeService
    {
        private List<Employee> empList;

        public EmployeeService()
        {
            empList = new List<Employee>() {
                new Employee(10, "a", "a", 20000),
                new Employee(1, "b", "b", 25000),
                new Employee(5, "c", "c", 200000),
                new Employee(9, "d", "d", 80000),
                new Employee(6, "e", "e", 10000),
                new Employee(2, "f", "f", 15000),
                new Employee(7, "g", "g", 40000),
                new Employee(4, "h", "h", 100000),
                new Employee(8, "j", "j", 45001),
            };
        }

        public Employee[] GetAllEmployee()
        {
            return empList.ToArray();
        }

        public void EmployeeAdd(Employee emp)
        {
            empList.Add(emp);
        }
    }
}
