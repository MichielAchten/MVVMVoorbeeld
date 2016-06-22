using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using System.ComponentModel;
using System.Windows;

namespace MVVMHobby.ViewModel
{
    public class HobbyLijstVM: ViewModelBase
    {
        public HobbyLijstVM()
        {
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("sport", "voetbal", new BitmapImage(new Uri("pack://application:,,,/images/voetbal.jpg", UriKind.Absolute)))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("sport", "atletiek", new BitmapImage(new Uri("pack://application:,,,/images/atletiek.jpg", UriKind.Absolute)))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("sport", "basketbal", new BitmapImage(new Uri("pack://application:,,,/images/basketbal.jpg", UriKind.Absolute)))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("sport", "tennis", new BitmapImage(new Uri("pack://application:,,,/images/tennis.jpg", UriKind.Absolute)))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("sport", "turnen", new BitmapImage(new Uri("pack://application:,,,/images/turnen.jpg", UriKind.Absolute)))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("muziek", "trompet", new BitmapImage(new Uri("pack://application:,,,/images/trompet.jpg", UriKind.Absolute)))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("muziek", "drum", new BitmapImage(new Uri("pack://application:,,,/images/drum.jpg", UriKind.Absolute)))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("muziek", "gitaat", new BitmapImage(new Uri("pack://application:,,,/images/gitaat.jpg", UriKind.Absolute)))));
            HobbyLijst.Add(new HobbyVM(new Model.Hobby("muziek", "piano", new BitmapImage(new Uri("pack://application:,,,/images/piano.jpg", UriKind.Absolute)))));
        }

        private ObservableCollection<HobbyVM> hobbyLijstValue = new ObservableCollection<HobbyVM>();
        public ObservableCollection<HobbyVM> HobbyLijst
        {
            get
            {
                return hobbyLijstValue;
            }
            set
            {
                hobbyLijstValue = value;
                RaisePropertyChanged("HobbyLijst");
            }
        }

        private HobbyVM selectedHobbyValue;
        public HobbyVM SelectedHobby
        {
            get
            {
                return selectedHobbyValue;
            }
            set
            {
                selectedHobbyValue = value;
                RaisePropertyChanged("SelectedHobby");
            }
        }

        public RelayCommand<RoutedEventArgs> VerwijderCommand
        {
            get
            {
                return new RelayCommand<RoutedEventArgs>(Verwijder);
            }
        }

        private void Verwijder(RoutedEventArgs e)
        {
            HobbyLijst.Remove(SelectedHobby);
        }
    }
}
