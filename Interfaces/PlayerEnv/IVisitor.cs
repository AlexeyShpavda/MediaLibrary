using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;

namespace Interfaces.PlayerEnv
{
    public interface IVisitor
    {
        void VisitPhotoFile(IPhoto photo);
        void VisitMusicFile(IMusic music);
        void VisitVideoFile(IVideo video);
    }
}
