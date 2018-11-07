using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.FileEnv
{
    public interface IMusic : IAudioParameters
    {
        string Genre { get; set; }
        string Artist { get; set; }
        string Album { get; set; }
        string Title { get; set; }
        string Year { get; set; }
    }
}
