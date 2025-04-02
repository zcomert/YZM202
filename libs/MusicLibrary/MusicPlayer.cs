using DataStructures.Array;
using DataStructures.LinkedList.Doubly;
using DataStructures.LinkedList.Singly;
using System.Collections;

namespace MusicLibrary
{
    public class MusicPlayer : IEnumerable
    {
        private readonly StaticArray<Music> arrayPlayer;
        private readonly SinglyLinkedList<Music> singlyPLayer;
        private readonly DoublyLinkedList<Music> doublyPLayer;

        private String Type { get; set; }
        private int _index = 0;

        public MusicPlayer(String type = "array")
        {
            if (type == "array")
            {
                arrayPlayer = new StaticArray<Music>(4);
                Type = type;
            }
            else if (type == "singly")
            {
                singlyPLayer = new SinglyLinkedList<Music>();
                Type = type;
            }

            else if (type == "doubly")
            {
                doublyPLayer = new DoublyLinkedList<Music>();
                Type = type;
            }

            else
                throw new Exception("Given type not found!");
        }

        public MusicPlayer(String type, IEnumerable<Music> items) : this(type)
        {
            foreach (var item in items)
            {
                AddMusic(item);
            }
        }

        public void AddMusic(Music item)
        {
            if (Type == "array")
            {
                arrayPlayer.SetItem(_index, item); // O(1)
                _index++;
            }
            else if (Type == "singly")
                singlyPLayer.AddLast(item); // O(n)

            else if (Type == "doubly")
                doublyPLayer.AddLast(item); // O(1)
        }

        public Music RemoveMusic()
        {
            if (Type == "array")
            {
                var removedMusic = arrayPlayer.GetItem(_index - 1); // O(1)
                arrayPlayer.SetItem(_index - 1, default); // O(1)
                _index--;
                return removedMusic;
            }
            else if (Type == "singly")
            {
                var removedMusic = singlyPLayer.RemoveLast(); // O(n)
                return removedMusic;
            }

            else if (Type == "doubly")
            {
                var removedMusic = doublyPLayer.RemoveLast(); // O(1)
                return removedMusic;
            }

            throw new Exception("Operation failed!");
        }

        public Music GetMusicById(int index)
        {
            if (Type == "array")
            {
                var music = arrayPlayer.GetItem(index); // O(1)
                return music;
            }
            else if (Type == "singly") // O(n)
            {
                var temp = singlyPLayer.Head;
                while (temp != null)
                {
                    if (temp.Value.Id.Equals(index))
                        return temp.Value;
                    temp = temp.Next;
                }
                throw new Exception("The music not found!");
            }

            else if (Type == "doubly") // O(n)
            {
                var temp = doublyPLayer.Head;
                while (temp != null)
                {
                    if (temp.Value.Id == index)
                        return temp.Value;
                    temp = temp.Next;
                }
                throw new Exception("The music not found!");
            }

            throw new Exception("Operation failed!");
        }

        public IEnumerator GetEnumerator()
        {
            if (Type == "array")
                return arrayPlayer.GetEnumerator();

            else if (Type == "singly")
                return singlyPLayer.GetEnumerator();

            else if (Type == "doubly")
                return doublyPLayer.GetEnumerator();

            throw new Exception("Wrong type data!");
        }
    }
}
