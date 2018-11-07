using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.FileEnv
{
    public interface IAudioParameters : IPlayTime
    {
        int BitRate { get; set; }
        int SampleRate { get; set; }
    }
}
