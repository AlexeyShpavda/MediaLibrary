using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;
using Interfaces.PlayerEnv;

namespace FileEnv
{
    class Photo : File, IPhoto
    {
        private string _dimensions;
        private ushort _width;
        private ushort _height;

        public Photo(string type, string name, ulong size, string location, // File
            string dimensions, ushort width, ushort height) : // Photo
            base(type, name, size, location)
        {
            Dimensions = dimensions;
            Width = width;
            Height = height;
        }

        public string Dimensions { get => _dimensions; set => _dimensions = value; }
        public ushort Width { get => _width; set => _width = value; }
        public ushort Height { get => _height; set => _height = value; }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitPhotoFile(this);
        }
    }
}
