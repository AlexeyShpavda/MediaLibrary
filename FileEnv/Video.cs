using Interfaces.FileEnv;
using Interfaces.PlayerEnv;

namespace FileEnv
{
    public class Video : AudioParameters, IVideo
    {
        public int FrameWidth { get; set; }

        public int FrameHeight { get; set; }

        public int FrameRate { get; set; }

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

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitVideoFile(this);
        }
    }
}
