namespace SchoolClassLibrary
{
    public class Student
    {
        public int StudentId { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public String FullName { get => FirstName + " " + LastName; }

        public int Password { get; set; }
        public Student()
        {
            Random random = new Random();
            Password = random.Next(1, 1000);
        }

        public Student(String firstName, String lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Student(String firstName, String lastName, int id)
            : this(firstName, lastName)
        {
            StudentId = id;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({StudentId})";
        }
    }
}
