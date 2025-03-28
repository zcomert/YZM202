namespace MusicLibrary
{
    public class Music
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Double Duration { get; set; }
        public String AlbumName { get; set; }

        public Music(int id, string name, double duration, string albumName)
        {
            Id = id;
            Name = name;
            Duration = duration;
            AlbumName = albumName;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Duration} {AlbumName}";
        }
    }
}
