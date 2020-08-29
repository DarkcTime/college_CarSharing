using CarSharing.Controller;
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
    /// Interaction logic for SelectCar.xaml
    /// </summary>
    public partial class SelectCar : Window
    {

        public SelectCar()
        {
            try
            {
                InitializeComponent();
                this.ListCars.ItemsSource = new CarSharing.Controller.Client().getListCars();
            }
            catch(Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
            
        }

        private void SelectCarInDataGrid(object sender, RoutedEventArgs routedEventArgs)
        {
            try
            {
                CarSharing.View.Client.AddNewRent.SelectedCar = (CarSharing.Model.Car)this.ListCars.SelectedItem;
                this.DialogResult = true;
            }
            catch(Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }

        }
    }
}
