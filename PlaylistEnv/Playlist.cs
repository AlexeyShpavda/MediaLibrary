﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Interfaces.PlaylistEnv;
using Interfaces.FileEnv;

namespace PlaylistEnv
{
    public class Playlist<TFile> : IPlaylist<TFile> where TFile : IFile
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        private ICollection<TFile> MediaFiles { get; set; }

        public Playlist(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            MediaFiles = new Collection<TFile>();
        }

        public void AddFile(TFile mediaFile)
        {
            MediaFiles.Add(mediaFile);
        }

        public void RemoveFile(TFile mediaFile)
        {
            MediaFiles.Remove(mediaFile);
        }

        public ICollection<TFile> GetAllFiles()
        {
            return MediaFiles;
        }

        public void Clear()
        {
            MediaFiles.Clear();
        }

        public int GetFilesNumber()
        {
            return MediaFiles.Count();
        }
    }
}
