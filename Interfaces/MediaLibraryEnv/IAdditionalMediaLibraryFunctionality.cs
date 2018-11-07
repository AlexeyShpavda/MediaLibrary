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
