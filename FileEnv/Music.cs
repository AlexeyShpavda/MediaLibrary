using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;
using Interfaces.PlayerEnv;


namespace FileEnv
{
    public class Music : AudioParameters, IMusic
    {
        private string _genre;
        private string _artist;
        private string _album;
        private string _title;
        private string _year;

        public Music(string type, string name, int size, string location, // File
            int bitRate, int sampleRate, // AudioParameters
            string length, // PlayTime
            string genre, string artist, string album, string title, string year) : // Music
            base(type, name, size, location, length, bitRate, sampleRate)
        {
            Genre = genre;
            Artist = artist;
            Album = album;
            Title = title;
            Year = year;
        }

        public string Genre { get => _genre; set => _genre = value; }
        public string Artist { get => _artist; set => _artist = value; }
        public string Album { get => _album; set => _album = value; }
        public string Title { get => _title; set => _title = value; }
        public string Year { get => _year; set => _year = value; }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitMusicFile(this);
        }
    }
}
