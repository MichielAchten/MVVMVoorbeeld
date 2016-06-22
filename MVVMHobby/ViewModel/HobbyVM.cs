using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

//using System.Windows;
using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

namespace MVVMHobby.ViewModel
{
    public class HobbyVM: ViewModelBase
    {
        private Model.Hobby hobby;
        public HobbyVM(Model.Hobby nHobby)
        {
            this.hobby = nHobby;
        }

        public string Categorie
        {
            get
            {
                return hobby.Categorie;
            }
            set
            {
                hobby.Categorie = value;
                RaisePropertyChanged("Categorie");
            }
        }

        public string Activiteit
        {
            get 
            { 
                return hobby.Activiteit; 
            }
            set 
            { 
                hobby.Activiteit = value;
                RaisePropertyChanged("Activiteit");
            }
        }

        public BitmapImage Symbool
        {
            get
            {
                return hobby.Symbool;
            }
            set
            {
                hobby.Symbool = value;
                RaisePropertyChanged("Symbool");
            }
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
            //groteView.GroteImage.source
            //nog niet klaar
        }
    }
}
