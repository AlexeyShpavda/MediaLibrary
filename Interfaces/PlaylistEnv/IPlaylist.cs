namespace Interfaces.PlaylistEnv
{
    public interface IPlaylist<TFile> : IPlaylistData<TFile>, 
        IMainPlaylistFunctionality<TFile>, IAdditionalPlaylistFunctionality<TFile>
    {
    }
}
