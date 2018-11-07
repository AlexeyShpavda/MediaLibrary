using Interfaces.FileEnv;
using Interfaces.PlayerEnv;

namespace FileEnv
{
    public class Photo : File, IPhoto
    {
        private string _dimensions;
        private int _width;
        private int _height;

        public Photo(string type, string name, int size, string location, // File
            string dimensions, int width, int height) : // Photo
            base(type, name, size, location)
        {
            Dimensions = dimensions;
            Width = width;
            Height = height;
        }

        public string Dimensions { get => _dimensions; set => _dimensions = value; }
        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitPhotoFile(this);
        }
    }
}
