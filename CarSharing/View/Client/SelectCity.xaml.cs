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
using System.Windows.Shapes;

namespace CarSharing.View.Client
{
    /// <summary>
    /// Interaction logic for SelectCity.xaml
    /// </summary>
    public partial class SelectCity : Window
    {
        public SelectCity()
        {
            try
            {
                InitializeComponent();
                this.ListCities.ItemsSource = new Controller.Client().getListCities();
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
            
        }


        private void SelectCityInDataGrid(object sender, RoutedEventArgs routedEventArgs)
        {
            try
            {
                Client.AddNewRent.SelectedCity = (CarSharing.Model.City)this.ListCities.SelectedItem;
                this.DialogResult = true;
            }
            catch(Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }

        }


    }
}
