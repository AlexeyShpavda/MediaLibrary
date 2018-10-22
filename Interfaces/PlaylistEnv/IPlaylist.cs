using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;

namespace Interfaces.PlaylistEnv
{
    interface IPlaylist<TFile> : IPlaylistData<TFile>, 
        IMainPlaylistFunctionality<TFile>, IAdditionalPlaylistFunctionality<TFile>
    {
    }
}
