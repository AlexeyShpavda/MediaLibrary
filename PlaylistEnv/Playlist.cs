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
    }
}
