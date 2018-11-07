using System.Collections.Generic;

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
