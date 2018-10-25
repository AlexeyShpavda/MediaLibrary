using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.PlaylistEnv;
using Interfaces.FileEnv;

namespace PlaylistEnv
{
    public class Playlist<TFile> : IPlaylist<TFile> where TFile : class, IFile
    {
        private Guid _id;
        private string _name;
        private ICollection<TFile> _mediaFiles;

        public Playlist(ICollection<TFile> mediaFiles, string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            MediaFiles = mediaFiles;
        }

        public Guid Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        private ICollection<TFile> MediaFiles { get => _mediaFiles; set => _mediaFiles = value; }

        public void AddFile(TFile mediaFile)
        {
            MediaFiles.Add(mediaFile);
        }

        public void RemoveFile(Guid id)
        {
            MediaFiles.Remove(SearchMediaFileByID(id));
        }

        private TFile SearchMediaFileByID(Guid id)
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

        public ICollection<TFile> GetAllFiles()
        {
            return MediaFiles;
        }

        public void Clear()
        {
            MediaFiles.Clear();
        }

        public ulong GetFilesNumber()
        {
            return (ulong)MediaFiles.Count();
        }
    }
}
