namespace CompanyClassLibrary
{
    public class Employee
    {
        public int Id { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public String FullName { get => FirstName + " " + LastName; }
        public int Password { get; set; }

        public Employee()
        {
            Random random = new Random();
            Password = random.Next(1, 1000);
        }

        public Employee(string firstName, string lastName)
            : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee(int id, string firstName, string lastName)
            : this(firstName, lastName)
        {
            Id = id;
        }
    }
}
