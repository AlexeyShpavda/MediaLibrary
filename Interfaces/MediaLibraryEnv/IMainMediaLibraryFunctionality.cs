using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;
using Interfaces.PlaylistEnv;

namespace Interfaces.MediaLibraryEnv
{
    public interface IMainMediaLibraryFunctionality
    {
        void AddFileToMediaLibrary(IFile file);
        void RemoveFileFromMediaLibrary(IFile file);
        void AddFileToPlaylist(IPlaylist<IFile> playlist, IFile file);
        void RemoveFileFromPlaylist(IPlaylist<IFile> playlist, IFile file);
        void CreatePlaylist(IPlaylist<IFile> playlist);
        void RemovePlaylist(IPlaylist<IFile> playlist);
        List<IFile> Search(string matchString);
        ICollection<IFile> GetAllFiles();
        ICollection<IPlaylist<IFile>> GetAllPlaylists();
        void ClearFileList();
        void ClearPlaylistList();
        void Play();
        void PlayFile(IFile file);
        void PlayPlaylist(IPlaylist<IFile> playlist);
    }
}
