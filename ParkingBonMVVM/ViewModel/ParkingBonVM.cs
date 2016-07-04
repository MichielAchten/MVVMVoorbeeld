using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.ComponentModel;

namespace ParkingBonMVVM.ViewModel
{
    public class ParkingBonVM: ViewModelBase
    {
        private Model.ParkingBon parkingbon;

        public ParkingBonVM(Model.ParkingBon deParkingbon)
        {
            parkingbon = deParkingbon;
        }

        public DateTime Datum
        {
            get
            {
                return parkingbon.Datum;
            }
            set
            {
                parkingbon.Datum = value;
                RaisePropertyChanged("Datum");
            }
        }

        public DateTime Aankomst
        {
            get
            {
                return parkingbon.Aankomst;
            }
            set
            {
                parkingbon.Aankomst = value;
                RaisePropertyChanged("Aankomst");
            }
        }

        public DateTime Vertrek
        {
            get
            {
                return parkingbon.Vertrek;
            }
            set
            {
                parkingbon.Vertrek = value;
                RaisePropertyChanged("Vertrek");
            }
        }

        public int Bedrag
        {
            get 
            {
                return parkingbon.Bedrag;
            }
            set
            {
                parkingbon.Bedrag = value;
                RaisePropertyChanged("Bedrag");
            }
        }

        public RelayCommand MeerCommand
        {
            get
            {
                return new RelayCommand(MeerBetalen);
            }
        }
        private void MeerBetalen()
        {
            if (Vertrek.Hour < 22)
            {
                Bedrag++;
            }
            Vertrek = Aankomst.AddHours(0.5 * Bedrag);
        }

        public RelayCommand MinderCommand
        {
            get
            {
                return new RelayCommand(MinderBetalen);
            }
        }
        private void MinderBetalen()
        {
            if (Bedrag > 0)
            {
                Bedrag--;
            }
            Vertrek = Aankomst.AddHours(0.5 * Bedrag);
        }

        public RelayCommand NieuwCommand
        {
            get
            {
                return new RelayCommand(NieuweBon);
            }
        }
        public void NieuweBon()
        {
            Bedrag = 0;
            Datum = DateTime.Today;
            Aankomst = DateTime.Now;
            Vertrek = DateTime.Now;
        }

        public RelayCommand OpenenCommand
        {
            get
            {
                return new RelayCommand(OpenenBon);
            }
        }
        private void OpenenBon()
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.FileName = "";
                dlg.DefaultExt = ".bon";
                dlg.Filter = "parkeerbonnen |*.bon";

                if (dlg.ShowDialog() == true)
                {
                    using (StreamReader invoer = new StreamReader(dlg.FileName))
                    {
                        Datum = Convert.ToDateTime(invoer.ReadLine());
                        Aankomst = Convert.ToDateTime(invoer.ReadLine());
                        Bedrag = Convert.ToInt32(invoer.ReadLine());
                        Vertrek = Convert.ToDateTime(invoer.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Openen mislukt : " + ex.Message);
            }
        }

        public RelayCommand OpslaanCommand
        {
            get
            {
                return new RelayCommand(OpslaanBon);
            }
        }
        private void OpslaanBon()
        {
            try
            {
                string bestandsnaam;
                bestandsnaam = Datum.Day + "-" + Datum.Month + "-" + Datum.Year +
                    "om" + Aankomst.Hour + "-" + Aankomst.Minute + ".bon";
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.FileName = bestandsnaam;
                dlg.DefaultExt = ".bon";
                dlg.Filter = "Parkeerbonnen |*.bon";
                if (dlg.ShowDialog() == true)
                {
                    using (StreamWriter uitvoer = new StreamWriter(dlg.FileName))
                    {
                        uitvoer.WriteLine(Datum.ToShortDateString());
                        uitvoer.WriteLine(Aankomst.ToShortTimeString());
                        uitvoer.WriteLine(Bedrag);
                        uitvoer.WriteLine(Vertrek.ToShortTimeString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oplsaan mislukt : ", ex.Message);
            }
        }

        public RelayCommand AfsluitenCommand
        {
            get
            {
                return new RelayCommand(AfsluitenApp);
            }
        }
        private void AfsluitenApp()
        {
            Application.Current.MainWindow.Close();
        }

        public RelayCommand<CancelEventArgs> AfsluitenEvent
        {
            get
            {
                return new RelayCommand<CancelEventArgs>(OnWindowClosing);
            }
        }
        private void OnWindowClosing(CancelEventArgs e)
        {
            if (MessageBox.Show("Afsluiten", "Wilt u het programma sluiten?", MessageBoxButton.YesNo, MessageBoxImage.Question, 
                MessageBoxResult.No) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
