using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music_Player.Models;
using Newtonsoft.Json;

namespace Music_Player.Services
{
    public class JsonDataService : IDataService
    {
        private readonly string _dataPath = "data.json";
        public IEnumerable<Song> LoadSongs()
        {
            if (!File.Exists(_dataPath))
            {
                File.Create(_dataPath).Close();
            }

            var serializedSongs = File.ReadAllText(_dataPath);
            var contacts = JsonConvert.DeserializeObject<IEnumerable<Song>>(serializedSongs);

            if (contacts == null)
                return new List<Song>();

            return contacts;
        }

        public void SaveSongs(IEnumerable<Song> songs)
        {
            var serializedSongs = JsonConvert.SerializeObject(songs);
            File.WriteAllText(_dataPath, serializedSongs);
        }
    }
}
