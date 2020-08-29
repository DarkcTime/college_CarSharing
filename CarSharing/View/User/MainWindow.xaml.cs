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
            try
            {
                InitializeComponent();
                //get functional for autorization user
                if (User.isAdmin()) getFuncForAdmin();
                else getFuncForClient();
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);    
            }
        }

        private void getFuncForAdmin()
        {
            try
            {
                this.AdminFunctional.Visibility = Visibility.Visible;
                this.ClientFunctional.Visibility = Visibility.Hidden;
                this.MainFrame.Content = new View.Admin.MainMenu();
            }
            catch(Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
           
        }

        private void getFuncForClient()
        {
            try
            {
                this.AdminFunctional.Visibility = Visibility.Hidden;
                this.ClientFunctional.Visibility = Visibility.Visible;
                this.MainFrame.Content = new View.Client.MainMenu();
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
          
        }


        #region Admin
        private void ListOfCars(object sender, RoutedEventArgs eventArgs)
        {
            try
            {
                this.MainFrame.Content = new View.Admin.ListOfCars();

            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
        }
        private void Statistick(object sender, RoutedEventArgs eventArgs)
        {
            try
            {
                this.MainFrame.Content = new View.Admin.Statistick();
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
            
        }
        #endregion

        #region Client
        private void AddNewRent(object sender, RoutedEventArgs eventArgs)
        {
            try
            {
                this.MainFrame.Content = new View.Client.AddNewRent();
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
            
        }

        #endregion

        #region User
        //edit data for account
        private void SettingsAccount(object sender, RoutedEventArgs e)
        {
            try
            {
                this.MainFrame.Content = new View.User.SettingsAccount();
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
            
        }

        //close this window and open auth
        private void Exit(object sender, RoutedEventArgs e)
        {
            SharedClass.OpenNewWindow(new Auth(), this);
        }

        #endregion



    }
}
