using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;
using Interfaces.PlaylistEnv;

namespace Interfaces.MediaLibraryEnv
{
    interface IMainMediaLibraryFunctionality
    {
        void AddFileToMediaLibrary(IFile file);
        void RemoveFileFromMediaLibrary(Guid fileId);
        void AddFileToPlaylist(Guid playlistID, IFile file);
        void RemoveFileFromPlaylist(Guid playlistId, Guid fileId);
        void CreatePlaylist(IPlaylist<IFile> playlist);
        void RemovePlaylist(Guid id);
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
