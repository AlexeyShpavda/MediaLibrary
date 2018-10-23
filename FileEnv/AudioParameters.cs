using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;

namespace FileEnv
{
    abstract class AudioParameters : PlayTime, IAudioParameters
    {
        private ulong _bitRate; // bps
        private ulong _sampleRate; // Hz

        public AudioParameters(string type, string name, ulong size, string location,
            string length, ulong bitRate, ulong sampleRate) :
            base(type, name, size, location, length)
        {
            BitRate = bitRate;
            SampleRate = sampleRate;
        }

        public ulong BitRate { get => _bitRate; set => _bitRate = value; }
        public ulong SampleRate { get => _sampleRate; set => _sampleRate = value; }
    }
}
