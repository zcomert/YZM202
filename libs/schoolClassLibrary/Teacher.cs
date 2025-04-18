namespace SchoolClassLibrary
{
    public struct Teacher
    {
        public int TeacherId { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public String FullName { get => FirstName + " " + LastName; }

        public int Password { get; set; }
        public Teacher()
        {
            Random random = new Random();
            Password = random.Next(1, 1000);
        }

        public Teacher(String firstName, String lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Teacher(String firstName, String lastName, int id)
            : this(firstName, lastName)
        {
            TeacherId = id;
        }
    }
}
