using Music_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Music_Player.Dialogs
{
    /// <summary>
    /// Interaction logic for DetailsDialog.xaml
    /// </summary>
    public partial class DetailsDialog : Window
    {
        public DetailsDialog(string name="", string artist="", Genre genre=Genre.Metal)
        {
            InitializeComponent();
            cmbGenre.ItemsSource = Enum.GetValues(typeof(Genre)).Cast<Genre>();
            txtName.Text = name;
            txtArtist.Text = artist;
            cmbGenre.SelectedIndex = (int)genre;
        }

        public string SongName
        {
            get { return txtName.Text;  }
        }

        public string SongArtist
        {
            get { return txtArtist.Text; }
        }

        public Genre SongGenre
        {
            get { return (Genre)Enum.Parse(typeof(Genre), cmbGenre.SelectedValue.ToString()); }
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
