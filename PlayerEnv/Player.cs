using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.FileEnv;
using Interfaces.PlayerEnv;

namespace PlayerEnv
{
    public class Player : IPlayer, IVisitor
    {
        public void VisitMusicFile(IMusic music)
        {
        }

        public void VisitPhotoFile(IPhoto photo)
        {
        }

        public void VisitVideoFile(IVideo video)
        {
        }
    }
}
