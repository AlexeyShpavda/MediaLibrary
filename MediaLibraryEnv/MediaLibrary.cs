using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.MediaLibraryEnv;
using Interfaces.FileEnv;
using Interfaces.PlaylistEnv;
using Interfaces.PlayerEnv;

namespace MediaLibraryEnv
{
    public class MediaLibrary : IMediaLibrary
    {
        private ICollection<IFile> _mediaFiles;
        private ICollection<IPlaylist<IFile>> _playlists;
        private IPlayer _player;

        public MediaLibrary(ICollection<IFile> mediaFiles, ICollection<IPlaylist<IFile>> playlists, IPlayer player)
        {
            MediaFiles = mediaFiles;
            Playlists = playlists;
            Player = player;
        }

        private ICollection<IFile> MediaFiles { get => _mediaFiles; set => _mediaFiles = value; }
        private ICollection<IPlaylist<IFile>> Playlists { get => _playlists; set => _playlists = value; }
        private IPlayer Player { get => _player; set => _player = value; }
    }
}
