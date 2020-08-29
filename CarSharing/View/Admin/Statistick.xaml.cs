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
    /// Interaction logic for Statistick.xaml
    /// </summary>
    public partial class Statistick : Page
    {
        private CarSharing.Controller.Admin Admin = new Controller.Admin();

        private CarSharing.Model.RentForStatistick RentForStatistick = new Model.RentForStatistick();

        private List<CarSharing.Model.RentForStatistick> rentForStatisticksList = new List<Model.RentForStatistick>();

        public Statistick()
        {
            InitializeComponent();
            rentForStatisticksList = Admin.getListRentForStatistick();
            this.ListRentForStatistick.ItemsSource = rentForStatisticksList;
            this.SetCountRents();
            this.SetSumMonth();
            //this.RentForStatistick.CarRental.
        }

        private void SetCountRents()
        {
            this.TxtNumberRent.Text = $"Number rents: {rentForStatisticksList.Count.ToString()}";            
        }

        private void SetSumMonth()
        {
            int sum = 0;
            foreach (CarSharing.Model.RentForStatistick rent in rentForStatisticksList)
            {
                sum += rent.Price; 
            }
            this.TxtSumMonth.Text = $"Sum all rents: {sum.ToString()}";
        }

        private void SetSum()
        {
            this.TxtSum.Text = $"Sum all rent: {RentForStatistick.Price.ToString()}";
        }

        private void SelectRentForStatistick(object sender, RoutedEventArgs routedEventArgs)
        {
            RentForStatistick = (CarSharing.Model.RentForStatistick)this.ListRentForStatistick.SelectedItem;
            this.DataContext = RentForStatistick;
            SetSum(); 
        }



    }
}
