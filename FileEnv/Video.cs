using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;
using Interfaces.PlayerEnv;

namespace FileEnv
{
    public class Video : AudioParameters, IVideo
    {
        private int _frameWidth;
        private int _frameHeight;
        private int _frameRate;

        public Video(string type, string name, int size, string location, // File
            int bitRate, int sampleRate, // AudioParameters
            string length, // PlayTime
            int frameWidth, int frameHeight, int frameRate) : // Video
            base(type, name, size, location, length, bitRate, sampleRate)
        {
            FrameWidth = frameWidth;
            FrameHeight = frameHeight;
            FrameRate = frameRate;
        }

        public int FrameWidth { get => _frameWidth; set => _frameWidth = value; }
        public int FrameHeight { get => _frameHeight; set => _frameHeight = value; }
        public int FrameRate { get => _frameRate; set => _frameRate = value; }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitVideoFile(this);
        }
    }
}
