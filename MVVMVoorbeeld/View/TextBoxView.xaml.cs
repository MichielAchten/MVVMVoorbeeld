﻿using System;
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

namespace MVVMVoorbeeld.View
{
    /// <summary>
    /// Interaction logic for TextBoxView.xaml
    /// </summary>
    public partial class TextBoxView : Window
    {
        public TextBoxView()
        {
            InitializeComponent();
            Uri iconUri = new Uri("pack://application:,,,/Images/font.ico", UriKind.RelativeOrAbsolute);

            this.Icon = BitmapFrame.Create(iconUri);
        }
    }
}
