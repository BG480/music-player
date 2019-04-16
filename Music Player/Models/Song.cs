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
    }
}
