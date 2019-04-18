using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Services
{
    public interface IMediaService
    {
        void Play(string mediaPath);
        void Pause();
        void Stop();
    }
}
