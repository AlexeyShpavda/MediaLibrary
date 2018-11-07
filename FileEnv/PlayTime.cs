using Interfaces.FileEnv;

namespace FileEnv
{
    public abstract class PlayTime : File, IPlayTime
    {
        public string Length { get; set; }

        protected PlayTime(string type, string name, int size, string location, string length) :
            base(type, name, size, location)
        {
            Length = length;
        }
    }
}
