using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Music_Player.Services
{
    public class MusicService : IMediaService
    {
        private MediaPlayer mediaPlayer;

        public MusicService()
        {
            mediaPlayer = new MediaPlayer();
        }

        
        public void Play(string mediaPath)
        {
            if(mediaPlayer.Source != null)
            {
                mediaPlayer.Close();
            }
            mediaPlayer.Open(new Uri(mediaPath));
            mediaPlayer.Play();
              
        }


        public void Pause()
        {
            mediaPlayer.Pause();
        }

        public void Stop()
        {
            mediaPlayer.Stop();
        }
    }
}
