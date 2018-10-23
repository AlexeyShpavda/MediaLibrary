using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.FileEnv
{
    public interface IVideo : IAudioParameters
    {
        ushort FrameWidth { get; set; }
        ushort FrameHeight { get; set; }
        ushort FrameRate { get; set; }
    }
}
