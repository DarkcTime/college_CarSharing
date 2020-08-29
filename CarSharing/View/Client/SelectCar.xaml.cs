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
        private CarSharing.Model.Car car;

        public SelectCar()
        {
            InitializeComponent();
            this.ListCars.ItemsSource = new CarSharing.Controller.Client().getListCars();
        }

        private void SelectCarInDataGrid(object sender, RoutedEventArgs routedEventArgs)
        {
            CarSharing.View.Client.AddNewRent.SelectedCar = (CarSharing.Model.Car)this.ListCars.SelectedItem;
            this.DialogResult = true;
        }
    }
}
