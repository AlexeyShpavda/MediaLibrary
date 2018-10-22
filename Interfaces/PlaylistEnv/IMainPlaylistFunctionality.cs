using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.PlaylistEnv
{
    interface IMainPlaylistFunctionality<TFile>
    {
        void AddFile(TFile mediaFiles);
        void RemoveFile(Guid id);
        ICollection<TFile> GetAllFiles();
        void Clear();
    }
}
