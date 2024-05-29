using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Playlist
    {
        private string Name;
        List<Song> Songs = new List<Song>();


        public Playlist(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void AddSong(Song s) 
        {
            //Song Song_ = new Song(name);
            Songs.Add(s);
        }
        public List<Song> GetList()
        {
            return this.Songs;
        }




    }
}
