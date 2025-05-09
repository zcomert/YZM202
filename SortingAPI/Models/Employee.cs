namespace SortingAPI.Models
{
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public string FullName { get => $"{FirstName} {LastName}"; }

        public Employee(int id, string firstName, string lastName, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public override string? ToString()
        {
            return $"{Id} {FullName} {Salary}";
        }

        public int CompareTo(Employee? other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
