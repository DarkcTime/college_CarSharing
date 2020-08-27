using CarSharing.Controller;
using CarSharing.View.Admin;
using CarSharing.View.Client;
using CarSharing.View.User;
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

namespace CarSharing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private User User = new User();  

        public MainWindow()
        {
            InitializeComponent();

            if (User.isAdmin()) getFuncForAdmin();
            else getFuncForClient();

        }

        private void getFuncForAdmin()
        {
            this.AdminFunctional.Visibility = Visibility.Visible;
            this.ClientFunctional.Visibility = Visibility.Hidden;
            this.MainFrame.Content = new View.Admin.MainMenu(); 
        }

        private void getFuncForClient()
        {
            this.AdminFunctional.Visibility = Visibility.Hidden;
            this.ClientFunctional.Visibility = Visibility.Visible; 
            this.MainFrame.Content = new View.Client.MainMenu(); 
        }


        #region Admin
        private void ListOfCars(object sender, RoutedEventArgs eventArgs)
        {

        }
        private void Statistick(object sender, RoutedEventArgs eventArgs)
        {

        }
        private void CurrentCars(object sender, RoutedEventArgs eventArgs)
        {

        }
        #endregion

        #region Client
        private void AddNewRent(object sender, RoutedEventArgs eventArgs)
        {

        }
        private void EndRent(object sender, RoutedEventArgs eventArgs)
        {

        }
        #endregion

        #region User
        private void SettingsAccount(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Content = new View.User.SettingsAccount();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            SharedClass.OpenNewWindow(new Auth(), this);
        }

        #endregion



    }
}
