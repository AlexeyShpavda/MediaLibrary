using Interfaces.FileEnv;
using Interfaces.PlayerEnv;


namespace FileEnv
{
    public class Music : AudioParameters, IMusic
    {
        public string Genre { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }

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

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitMusicFile(this);
        }
    }
}
