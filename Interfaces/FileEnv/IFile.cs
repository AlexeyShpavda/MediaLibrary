using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Interfaces.PlayerEnv;

namespace Interfaces.FileEnv
{
    public interface IFile : IAccept
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        int Size { get; set; }
        string Location { get; set; }
    }
}
