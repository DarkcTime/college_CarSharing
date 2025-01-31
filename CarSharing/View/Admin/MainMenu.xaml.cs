﻿using CarSharing.Controller;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarSharing.View.Admin
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
            Timer timer = new Timer(this.TxtTime, this.TxtDate);
        }


        private void ListOfCars(object sender, RoutedEventArgs routedEventArgs)
        {
            SharedClass.OpenNewPage(this, new View.Admin.ListOfCars()); 
        }
    }
}
