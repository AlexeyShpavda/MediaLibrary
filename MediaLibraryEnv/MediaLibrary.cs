﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Interfaces.MediaLibraryEnv;
using Interfaces.FileEnv;
using Interfaces.PlaylistEnv;
using Interfaces.PlayerEnv;

namespace MediaLibraryEnv
{
    public class MediaLibrary : IMediaLibrary
    {
        private ICollection<IFile> MediaFiles { get; set; }

        private ICollection<IPlaylist<IFile>> Playlists { get; set; }

        private IPlayer Player { get; set; }

        public MediaLibrary(IPlayer player)
        {
            MediaFiles = new Collection<IFile>();
            Playlists = new Collection<IPlaylist<IFile>>();
            Player = player;
        }

        public void AddFileToMediaLibrary(IFile file)
        {
            MediaFiles.Add(file);
        }

        public void RemoveFileFromMediaLibrary(IFile file)
        {
            MediaFiles.Remove(file);
        }

        public void AddFileToPlaylist(IPlaylist<IFile> playlist, IFile file)
        {
            playlist.AddFile(file);
        }

        public void RemoveFileFromPlaylist(IPlaylist<IFile> playlist, IFile file)
        {
            playlist.RemoveFile(file);
        }

        public void CreatePlaylist(IPlaylist<IFile> playlist)
        {
            Playlists.Add(playlist);
        }

        public void RemovePlaylist(IPlaylist<IFile> playlist)
        {
            Playlists.Remove(playlist);
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

        public int GetFilesNumberInMediaLibrary()
        {
            return MediaFiles.Count();
        }

        public int GetFilesNumberInPlaylist(IPlaylist<IFile> playlist)
        {
            return playlist.GetFilesNumber();
        }

        public int GetPlaylistsNumber()
        {
            return Playlists.Count();
        }
    }
}