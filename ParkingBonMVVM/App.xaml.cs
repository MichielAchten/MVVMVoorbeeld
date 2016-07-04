﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ParkingBonMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Model.ParkingBon mijnParkingBon = new Model.ParkingBon();
            ViewModel.ParkingBonVM vm = new ViewModel.ParkingBonVM(mijnParkingBon);
            View.ParkingBonView mijnParkingBonView = new View.ParkingBonView();
            mijnParkingBonView.DataContext = vm;
            mijnParkingBonView.Show();
        }
    }
}
