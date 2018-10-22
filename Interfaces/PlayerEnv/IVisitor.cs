﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;

namespace Interfaces.PlayerEnv
{
    interface IVisitor
    {
        void VisitPhotoFile(IPhoto photo);
        void VisitMusicFile(IMusic music);
        void VisitVideoFile(IVideo video);
    }
}