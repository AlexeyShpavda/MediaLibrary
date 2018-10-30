using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.FileEnv
{
    public interface IPhoto : IFile
    {
        string Dimensions { get; set; }
        int Width { get; set; }
        int Height { get; set; }
    }
}
