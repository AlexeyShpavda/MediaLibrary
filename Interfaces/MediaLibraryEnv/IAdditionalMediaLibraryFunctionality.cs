﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.MediaLibraryEnv
{
    interface IAdditionalMediaLibraryFunctionality
    {
        ulong GetFilesNumberInMediaLibrary();
        ulong GetFilesNumberInPlaylist(Guid id);
    }
}
