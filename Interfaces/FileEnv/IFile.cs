using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.FileEnv
{
    public interface IFile
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        ulong Size { get; set; }
        string Location { get; set; }
    }
}
