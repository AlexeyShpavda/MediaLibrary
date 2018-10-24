using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.PlaylistEnv
{
    public interface IPlaylistData<TFile>
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
