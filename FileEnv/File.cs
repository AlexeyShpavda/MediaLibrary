using System;
using Interfaces.FileEnv;
using Interfaces.PlayerEnv;

namespace FileEnv
{
    public abstract class File : IFile
    {
        private Guid _id;
        private string _name;
        private string _type;
        private int _size; // byte
        private string _location;

        public Guid Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public int Size { get => _size; set => _size = value; }
        public string Location { get => _location; set => _location = value; }

        public File(string type, string name, int size, string location)
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
