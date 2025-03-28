namespace TabsLibrary
{
    public class Tab
    {
        public int Id { get; set; }
        public String TabName { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public Tab()
        {
            CreatedTime = DateTime.Now;
        }

        public Tab(int id, string tabName, string title, string description)
            : this()
        {
            Id = id;
            TabName = tabName;
            Title = title;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Id} " +
                $"{TabName} " +
                $"{Description} " +
                $"{Title} " +
                $"{CreatedTime.Date}";
        }
    }
}
