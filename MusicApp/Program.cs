using MusicLibrary;

var musicList = new MusicPlayer("doubly", 
    new Music[] { 
    new Music(0, "A", 1.0, "A_Album")
});

musicList.AddMusic(new Music(1, "B", 1.0, "A_Album"));
musicList.AddMusic(new Music(2, "C", 1.0, "A_Album"));
musicList.AddMusic(new Music(3, "D", 1.0, "B_Album"));
//musicList.AddMusic(new Music(4, "E", 1.0, "B_Album"));

Console.WriteLine(musicList.GetMusicById(2).ToString());

Console.WriteLine(musicList.RemoveMusic().ToString());
