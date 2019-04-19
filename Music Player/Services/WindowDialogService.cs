using Microsoft.Win32;
using Music_Player.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Music_Player.Services
{
    public class WindowDialogService : IDialogService
    {
        public string OpenFile(string filter)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == true)
            {
                return dialog.FileName;
            }

            return null;
        }

        public object GetDetails()
        {
            var dialog = new DetailsDialog();
            if(dialog.ShowDialog() == true)
            {
                return new { Name = dialog.SongName, Artist = dialog.SongArtist, Genre = dialog.SongGenre };
            }
            return null;
        }

        public void ShowMessageBox(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButton.OK);
        }
    }
}
