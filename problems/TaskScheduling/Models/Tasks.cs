namespace TaskScheduling.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Tasks(int id, string description)
        {
            this.Id = id;
            this.Description = description;
            this.Date = DateTime.Now;
        }
    }
}
