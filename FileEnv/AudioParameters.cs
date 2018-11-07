using Interfaces.FileEnv;

namespace FileEnv
{
    public abstract class AudioParameters : PlayTime, IAudioParameters
    {
        public int BitRate { get; set; }

        public int SampleRate { get; set; }

        public AudioParameters(string type, string name, int size, string location,
            string length, int bitRate, int sampleRate) :
            base(type, name, size, location, length)
        {
            BitRate = bitRate;
            SampleRate = sampleRate;
        }
    }
}
