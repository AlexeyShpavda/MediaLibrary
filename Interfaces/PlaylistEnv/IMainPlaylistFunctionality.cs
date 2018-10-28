using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.PlaylistEnv
{
    public interface IMainPlaylistFunctionality<TFile>
    {
        void AddFile(TFile mediaFiles);
        void RemoveFile(TFile mediaFile);
        ICollection<TFile> GetAllFiles();
        void Clear();
    }
}
