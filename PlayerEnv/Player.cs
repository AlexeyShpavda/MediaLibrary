using System.Collections.Generic;
using Interfaces.FileEnv;
using Interfaces.PlayerEnv;
using Interfaces.PlaylistEnv;

namespace PlayerEnv
{
    public class Player : IPlayer, IVisitor
    {
        public void Play(ICollection<IFile> files)
        {
            foreach(var file in files)
            {
                file.Accept(this);
            }
        }

        public void PlayFile(IFile file)
        {
            file.Accept(this);
        }

        public void PlayPlaylist(IPlaylist<IFile> playlist)
        {
            foreach (var file in playlist.GetAllFiles())
            {
                file.Accept(this);
            }
        }

        public void VisitMusicFile(IMusic music)
        {
        }

        public void VisitPhotoFile(IPhoto photo)
        {
        }

        public void VisitVideoFile(IVideo video)
        {
        }
    }
}
