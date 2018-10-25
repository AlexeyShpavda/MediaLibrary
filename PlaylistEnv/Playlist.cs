using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces.PlaylistEnv;
using Interfaces.FileEnv;

namespace PlaylistEnv
{
    public class Playlist<TFile> : IPlaylist<TFile> where TFile : IFile 
    {
        private Guid _id;
        private string _name;
        private ICollection<TFile> _mediaFiles;

        public Guid Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        private ICollection<TFile> MediaFiles { get => _mediaFiles; set => _mediaFiles = value; }
    }
}
