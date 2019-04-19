using Music_Player.Services;
using Music_Player.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.ViewModels
{
    class MusicPlayerViewModel : ObservableObject
    {
        private SongsViewModel _songsVM;
        public SongsViewModel SongsVM
        {
            get { return _songsVM; }
            set { OnPropertyChanged(ref _songsVM, value); }
        }

        public MusicPlayerViewModel()
        {
            var dataService = new JsonDataService();
            var dialogService = new WindowDialogService();
            var mediaService = new MusicService();

            _songsVM = new SongsViewModel(dataService, dialogService, mediaService);

        }
    }
}
