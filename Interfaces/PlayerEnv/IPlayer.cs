using System.Collections.Generic;
using Interfaces.FileEnv;
using Interfaces.PlaylistEnv;

namespace Interfaces.PlayerEnv
{
    public interface IPlayer
    {
        void Play(ICollection<IFile> files);
        void PlayFile(IFile file);
        void PlayPlaylist(IPlaylist<IFile> playlist);
    }
}
