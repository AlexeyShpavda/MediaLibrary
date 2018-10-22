using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.FileEnv
{
    interface IPhoto : IFile
    {
        string Dimensions { get; set; }
        ushort Width { get; set; }
        ushort Height { get; set; }
    }
}
