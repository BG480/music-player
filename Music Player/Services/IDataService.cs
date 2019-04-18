using Music_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Services
{
    public interface IDataService
    {
        IEnumerable<Song> LoadSongs();
        void SaveSongs(IEnumerable<Song> songs);
    }
}
