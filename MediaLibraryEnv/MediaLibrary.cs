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

        public void AddFileToMediaLibrary(IFile file)
        {
            MediaFiles.Add(file);
        }

        public void RemoveFileFromMediaLibrary(Guid fileId)
        {
            MediaFiles.Remove(SearchMediaFileById(fileId));
        }

        public void AddFileToPlaylist(Guid playlistId, IFile file)
        {
            SearchPlaylistById(playlistId).AddFile(file);
        }

        public void RemoveFileFromPlaylist(Guid playlistId, Guid fileId)
        {
            SearchPlaylistById(playlistId).RemoveFile(fileId);
        }

        public void CreatePlaylist(IPlaylist<IFile> playlist)
        {
            Playlists.Add(playlist);
        }

        public void RemovePlaylist(Guid id)
        {
            Playlists.Remove(SearchPlaylistById(id));
        }

        public List<IFile> Search(string matchString)
        {
            List<IFile> matchedFiles = new List<IFile>();

            foreach (var file in MediaFiles)
            {
                if (file.Name.Contains(matchString))
                {
                    matchedFiles.Add(file);
                }
            }
            return matchedFiles;
        }

        public ICollection<IFile> GetAllFiles()
        {
            return MediaFiles;
        }

        public ICollection<IPlaylist<IFile>> GetAllPlaylists()
        {
            return Playlists;
        }

        public void ClearFileList()
        {
            MediaFiles.Clear();
        }

        public void ClearPlaylistList()
        {
            Playlists.Clear();
        }

        public void Play()
        {
            Player.Play(MediaFiles);
        }

        public void PlayFile(IFile file)
        {
            Player.PlayFile(file);
        }

        public void PlayPlaylist(IPlaylist<IFile> playlist)
        {
            Player.PlayPlaylist(playlist);
        }

        private IFile SearchMediaFileById(Guid id)
        {
            foreach (var mediaFile in MediaFiles)
            {
                if (mediaFile.Id == id)
                {
                    return mediaFile;
                }
            }
            return null;
        }

        private IPlaylist<IFile> SearchPlaylistById(Guid id)
        {
            foreach (var playlist in Playlists)
            {
                if (playlist.Id == id)
                {
                    return playlist;
                }
            }
            return null;
        }
    }
}
