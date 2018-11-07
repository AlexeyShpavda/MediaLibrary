using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.PlaylistEnv
{
    public interface IAdditionalPlaylistFunctionality<TFile>
    {
        int GetFilesNumber();
    }
}
