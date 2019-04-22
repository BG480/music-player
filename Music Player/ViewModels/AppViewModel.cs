using Music_Player.Services;
using Music_Player.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.ViewModels
{
    class AppViewModel : ObservableObject
    {
        private MusicPlayerViewModel _musicPlayerVM;
        public MusicPlayerViewModel MusicPlayerVM
        {
            get { return _musicPlayerVM; }
            set { OnPropertyChanged(ref _musicPlayerVM, value); }
        }

        public AppViewModel()
        {
            var dataService = new JsonDataService();
            var dialogService = new WindowDialogService();
            var mediaService = new MusicService();

            _musicPlayerVM = new MusicPlayerViewModel(dataService, dialogService, mediaService);

        }
    }
}
