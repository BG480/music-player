using Music_Player.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Models
{
    public class Song : ObservableObject
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { OnPropertyChanged(ref _name, value); }
        }

        private string _artist;
        public string Artist
        {
            get { return _artist; }
            set { OnPropertyChanged(ref _artist, value); }
        }

        private Genre _genre;
        public Genre Genre
        {
            get { return _genre; }
            set { OnPropertyChanged(ref _genre, value); }
        }

        private string _path;
        public string Path
        {
            get { return _path; }
            set { OnPropertyChanged(ref _path, value); }
        }
    }
}
