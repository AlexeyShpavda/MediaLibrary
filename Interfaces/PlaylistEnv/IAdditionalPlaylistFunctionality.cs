﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.PlaylistEnv
{
    interface IAdditionalPlaylistFunctionality<TFile>
    {
        ulong GetFilesNumber();
    }
}
