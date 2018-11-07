using Interfaces.FileEnv;
using Interfaces.PlayerEnv;

namespace FileEnv
{
    public class Photo : File, IPhoto
    {
        public string Dimensions { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Photo(string type, string name, int size, string location, // File
            string dimensions, int width, int height) : // Photo
            base(type, name, size, location)
        {
            Dimensions = dimensions;
            Width = width;
            Height = height;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitPhotoFile(this);
        }
    }
}
