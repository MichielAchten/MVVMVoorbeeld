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

namespace ParkingBonMVVM.View
{
    /// <summary>
    /// Interaction logic for ParkingBonView.xaml
    /// </summary>
    public partial class ParkingBonView : RibbonWindow
    {
        public ParkingBonView()
        {
            InitializeComponent();
            //Nieuw();
        }

        //public void Nieuw()
        //{
        //    DatumBon.SelectedDate = DateTime.Now;
        //    AankomstTextBlock.Text = DateTime.Now.ToLongTimeString();
        //    TeBetalenTextBlock.Text = "€ 0";
        //    VertrekTextBlock.Text = AankomstTextBlock.Text;
        //    SaveEnabled(false);
        //}

        //public void SaveEnabled(bool enabled)
        //{
        //    RibbonSaveButton.IsEnabled = enabled;
        //    QatSaveButton.IsEnabled = enabled;
        //    RibbonButtonSave.IsEnabled = enabled;
        //}

        //private void minder_Click(object sender, RoutedEventArgs e)
        //{
        //    int bedrag = Convert.ToInt32(TeBetalenTextBlock.Text.ToString().Replace("€ ", ""));
        //    if (bedrag > 0)
        //    {
        //        bedrag -= 1;
        //    }
        //    TeBetalenTextBlock.Text = "€ " + bedrag.ToString();
        //    VertrekTextBlock.Text = Convert.ToDateTime(AankomstTextBlock.Text).AddHours(0.5 * bedrag).ToLongTimeString();
        //    SaveEnabled(!(bedrag == 0));
        //}

        //private void meer_Click(object sender, RoutedEventArgs e)
        //{
        //    int bedrag = Convert.ToInt32(TeBetalenTextBlock.Text.ToString().Replace("€ ", ""));
        //    if (bedrag < 10)
        //    {
        //        bedrag += 1;
        //    }
        //    TeBetalenTextBlock.Text = "€ " + bedrag.ToString();
        //    VertrekTextBlock.Text = Convert.ToDateTime(AankomstTextBlock.Text).AddHours(0.5 * bedrag).ToLongTimeString();
        //    SaveEnabled(!(bedrag == 0));
        //}

        //private void NewExecuted(object sender, ExecutedRoutedEventArgs e)
        //{
        //    Nieuw();
        //}

        //private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        //{
        //    try
        //    {
        //        OpenFileDialog dlg = new OpenFileDialog();
        //        dlg.Filter = "parkeerbonnen |*.bon";

        //        if (dlg.ShowDialog() == true)
        //        {
        //            using (StreamReader invoer = new StreamReader(dlg.FileName))
        //            {
        //                DatumBon.SelectedDate = Convert.ToDateTime(invoer.ReadLine());
        //                AankomstTextBlock.Text = invoer.ReadLine();
        //                TeBetalenTextBlock.Text = invoer.ReadLine();
        //                VertrekTextBlock.Text = invoer.ReadLine();
        //            }
        //            SaveEnabled(true);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Openen mislukt : " + ex.Message);
        //    }
        //}

        //private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        //{
        //    try
        //    {
        //        SaveFileDialog dlg = new SaveFileDialog();
        //        DateTime tijd = (DateTime)DatumBon.SelectedDate;
        //        dlg.FileName = tijd.Day.ToString() + "-" + tijd.Month.ToString() + "-" + tijd.Year.ToString() +
        //            "om" + AankomstTextBlock.Text.ToString().Replace(":", "-");
        //        dlg.DefaultExt = ".bon";
        //        dlg.Filter = "Parkeerbonnen |*.bon";
        //        if (dlg.ShowDialog() == true)
        //        {
        //            using (StreamWriter uitvoer = new StreamWriter(dlg.FileName))
        //            {
        //                uitvoer.WriteLine(tijd.ToShortTimeString());
        //                uitvoer.WriteLine(AankomstTextBlock.Text);
        //                uitvoer.WriteLine(TeBetalenTextBlock.Text);
        //                uitvoer.WriteLine(VertrekTextBlock.Text);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Oplsaan mislukt : ", ex.Message);
        //    }
        //}

        //private void RibbonWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (MessageBox.Show("Programma afsluiten?", "Afsluiten", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}
    }
}
