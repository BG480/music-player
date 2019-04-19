using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Services
{
    public interface IDialogService
    {
        string OpenFile(string filter);
        void ShowMessageBox(string title, string message);
        object GetDetails();
    }
}
