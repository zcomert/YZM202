using CompanyClassLibrary;

namespace companyTest
{
    public class CompanyTester
    {
        private Employee _employee;
        private Department _department;

        public CompanyTester()
        {
            _employee = new Employee(1, "mehmet", "dag");
            _department = new Department(1, "Software", "software@company.com");
        }

        [Fact]
        public void EmployeeReferenceTest()
        {
            // 3A -> Arrange - Act - Assert
            Employee employee2 = _employee;
            employee2.FirstName = "sahin";
            employee2.LastName = "ozkaleli";
            employee2.Id = 2;

            // Assert
            Assert.Equal("sahin", _employee.FirstName);
            Assert.Equal("ozkaleli", _employee.LastName);
            Assert.Equal("sahin ozkaleli", _employee.FullName);
            Assert.Equal(2, _employee.Id);

            Assert.Equal("sahin", employee2.FirstName);
            Assert.Equal("ozkaleli", employee2.LastName);
            Assert.Equal("sahin ozkaleli", employee2.FullName);
            Assert.Equal(2, employee2.Id);
        }

        [Fact]
        public void DepartmentStrcutTest()
        {
            // Arrange - Act
            Department department2 = _department;
            department2.Id = 2;
            department2.Name = "AI";
            department2.Email = "ai@company.com";

            // Assert
            Assert.Equal(1, _department.Id);
            Assert.Equal("Software", _department.Name);

            Assert.Equal(2, department2.Id);
            Assert.Equal("AI", department2.Name);
        }
    }
}