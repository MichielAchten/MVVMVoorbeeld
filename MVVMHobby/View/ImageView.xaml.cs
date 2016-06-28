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

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MVVMHobby.View
{
    /// <summary>
    /// Interaction logic for ImageView.xaml
    /// </summary>
    public partial class ImageView : Window
    {
        public ImageView()
        {
            InitializeComponent();
        }

        View.ImageView groteView;

        public RelayCommand<MouseEventArgs> MouseDownCommand
        {
            get
            {
                return new RelayCommand<MouseEventArgs>(MuisIn);
            }
        }

        private void MuisIn(MouseEventArgs e)
        {
            Image tg = (Image)e.OriginalSource;
            groteView = new View.ImageView();
            groteView.GroteImage.Source = tg.Source;
            groteView.Show();
        }

        public RelayCommand<MouseEventArgs> MouseUpCommand
        {
            get { return new RelayCommand<MouseEventArgs>(MuisUit); }
        }

        private void MuisUit(MouseEventArgs e)
        {
            if (groteView != null)
            {
                groteView.Close();
            }
            groteView = null;
        }
    }
}
