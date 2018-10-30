using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.PlaylistEnv;
using Interfaces.FileEnv;

namespace Interfaces.MediaLibraryEnv
{
    public interface IAdditionalMediaLibraryFunctionality
    {
        int GetFilesNumberInMediaLibrary();
        int GetFilesNumberInPlaylist(IPlaylist<IFile> playlist);
        int GetPlaylistsNumber();
    }
}
