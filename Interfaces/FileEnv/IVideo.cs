using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.FileEnv
{
    public interface IVideo : IAudioParameters
    {
        int FrameWidth { get; set; }
        int FrameHeight { get; set; }
        int FrameRate { get; set; }
    }
}
