using Music_Player.Models;
using Music_Player.Services;
using Music_Player.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Music_Player.ViewModels
{
    class MusicPlayerViewModel : ObservableObject
    {
        private IDataService _dataService;
        private IDialogService _dialogService;
        private IMediaService _mediaService;

        private Song _selectedSong;
        public Song SelectedSong
        {
            get { return _selectedSong; }
            set { OnPropertyChanged(ref _selectedSong, value); }
        }

        public ObservableCollection<Song> Songs { get; private set; }

        public ICommand PlayCommand { get; private set; }
        public ICommand PauseCommand { get; private set; }
        public ICommand StopCommand { get; private set; }
        public ICommand AddCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        public MusicPlayerViewModel(IDataService dataService, IDialogService dialogService, IMediaService mediaService)
        {
            _dataService = dataService;
            _dialogService = dialogService;
            _mediaService = mediaService;

            PlayCommand = new RelayCommand(Play, CanPlay);
            PauseCommand = new RelayCommand(Pause, CanPause);
            StopCommand = new RelayCommand(Stop, CanStop);
            AddCommand = new RelayCommand(Add);
            DeleteCommand = new RelayCommand(Delete, CanDelete);
            LoadSongs();
                       
        }

        private void Play()
        {
            _mediaService.Play(SelectedSong.Path);
        }

        private void Pause()
        {
            _mediaService.Pause();
        }

        private void Stop()
        {
            _mediaService.Stop();
        }

        private void Add()
        {
            var path = _dialogService.OpenFile("MP3 Music (*.mp3)|*mp3");
            if(path != null)
            {
                dynamic data = _dialogService.GetDetails();
                var newSong = new Song
                {
                    Name = data.Name,
                    Artist = data.Artist,
                    Genre = data.Genre,
                    Path = path
                };

                Songs.Add(newSong);
                SelectedSong = newSong;
                SaveSongs();
            }

            
        }

        private void Delete()
        {
            Songs.Remove(SelectedSong);
            SaveSongs();
        }

        private bool CanPlay()
        {
            return SelectedSong == null ? false : true; 
        }

        private bool CanPause()
        {
            return CanPlay();
        }

        private bool CanStop()
        {
            return CanPlay();
        }

        private bool CanDelete()
        {
            return CanPlay();
        }

        private void LoadSongs()
        {
            Songs = new ObservableCollection<Song>(_dataService.LoadSongs());
            OnPropertyChanged("Songs");
        }

        private void SaveSongs()
        {
            _dataService.SaveSongs(Songs);
        }
    }
}
