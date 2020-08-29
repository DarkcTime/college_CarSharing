
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarSharing.View.Client
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        private CarSharing.Controller.Client Client = new Controller.Client();

        private CarSharing.Model.RentCarForUser rentCarForUser = new CarSharing.Model.RentCarForUser();

        public MainMenu()
        {
            InitializeComponent();
            LoadPage();
        }

        private void LoadPage()
        {
            this.ListRentCarsForUser.ItemsSource = Client.getListRentForUser(CarSharing.Controller.User.AuthorizedUser);
        }

        private void UpdatePage()
        {
            this.ListRentCarsForUser.ItemsSource = null;
            rentCarForUser = new Model.RentCarForUser();
            LoadPage();
        }

        private void AddNewRent(object sender, RoutedEventArgs routedEventArgs)
        {
            try
            {
                SharedClass.OpenNewPage(this, new View.Client.AddNewRent());
            }
            catch(Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
        }

        private void EndRent(object sender, RoutedEventArgs routedEventArgs)
        {
            if(this.ListRentCarsForUser.SelectedItem != null)
            {
                Client.EditRent((CarSharing.Model.RentCarForUser)this.ListRentCarsForUser.SelectedItem);
                SharedClass.MessageBoxInformation("Success");
                UpdatePage();

            }
            else
            {
                SharedClass.MessageBoxWarning("Выберите запись в таблице");
            }
        }



    }
}
