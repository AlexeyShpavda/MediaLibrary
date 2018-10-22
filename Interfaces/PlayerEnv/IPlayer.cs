using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;
using Interfaces.PlaylistEnv;

namespace Interfaces.PlayerEnv
{
    interface IPlayer
    {
        void Play(ICollection<IFile> files);
        void PlayFile(IFile file);
        void PlayPlaylist(IPlaylist<IFile> playlist);
    }
}
