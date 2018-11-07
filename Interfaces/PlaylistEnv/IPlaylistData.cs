using System;

namespace Interfaces.PlaylistEnv
{
    public interface IPlaylistData<TFile>
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
