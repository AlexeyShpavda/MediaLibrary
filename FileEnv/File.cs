using System;
using Interfaces.FileEnv;
using Interfaces.PlayerEnv;

namespace FileEnv
{
    public abstract class File : IFile
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Size { get; set; }

        public string Location { get; set; }

        public File(string type, string name, int size, string location)
        {
            Id = Guid.NewGuid();
            Name = name;
            Type = type;
            Size = size;
            Location = location;
        }

        public abstract void Accept(IVisitor visitor);
    }
}
