﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RetailPOS.Usercontrols
{
    /// <summary>
    /// Interaction logic for Categories.xaml
    /// </summary>
    public partial class Categories : UserControl
    {
       

        public delegate void CallWindow();
        public  event CallWindow OpenNewWin;

        public Categories()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (OpenNewWin != null)
                OpenNewWin();
        }
    }
}