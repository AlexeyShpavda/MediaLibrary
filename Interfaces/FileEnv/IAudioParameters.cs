using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.FileEnv
{
    interface IAudioParameters : IPlayTime
    {
        ulong BitRate { get; set; }
        ulong SampleRate { get; set; }
    }
}
