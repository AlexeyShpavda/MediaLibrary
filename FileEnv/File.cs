using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;

namespace FileEnv
{
    abstract class File : IFile
    {
        private Guid _id;
        private string _name;
        private string _type;
        private ulong _size; // byte
        private string _location;

        public Guid Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public ulong Size { get => _size; set => _size = value; }
        public string Location { get => _location; set => _location = value; }

        public File(string type, string name, ulong size, string location)
        {
            Id = Guid.NewGuid();
            Name = name;
            Type = type;
            Size = size;
            Location = location;
        }

        abstract public void Accept(IVisitor visitor);
    }
}
