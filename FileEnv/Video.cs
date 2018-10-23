using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;

namespace FileEnv
{
    class Video : AudioParameters, IVideo
    {
        private ushort _frameWidth;
        private ushort _frameHeight;
        private ushort _frameRate;

        public Video(string type, string name, ulong size, string location, // File
            ulong bitRate, ulong sampleRate, // AudioParameters
            string length, // PlayTime
            ushort frameWidth, ushort frameHeight, ushort frameRate) : // Video
            base(type, name, size, location, length, bitRate, sampleRate)
        {
            FrameWidth = frameWidth;
            FrameHeight = frameHeight;
            FrameRate = frameRate;
        }

        public ushort FrameWidth { get => _frameWidth; set => _frameWidth = value; }
        public ushort FrameHeight { get => _frameHeight; set => _frameHeight = value; }
        public ushort FrameRate { get => _frameRate; set => _frameRate = value; }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitVideoFile(this);
        }
    }
}
