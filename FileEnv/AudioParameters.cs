using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;

namespace FileEnv
{
    public abstract class AudioParameters : PlayTime, IAudioParameters
    {
        private int _bitRate; // bps
        private int _sampleRate; // Hz

        public AudioParameters(string type, string name, int size, string location,
            string length, int bitRate, int sampleRate) :
            base(type, name, size, location, length)
        {
            BitRate = bitRate;
            SampleRate = sampleRate;
        }

        public int BitRate { get => _bitRate; set => _bitRate = value; }
        public int SampleRate { get => _sampleRate; set => _sampleRate = value; }
    }
}
