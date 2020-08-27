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

            if (User.isAdmin())
                getFuncForAdmin();
            else
                getFuncForClient();

        }

        private void getFuncForAdmin()
        {
            this.MainFrame.Content = new View.Admin.MainMenu(); 
        }

        private void getFuncForClient()
        {
            this.MainFrame.Content = new View.Client.MainMenu(); 
        }

        private void SettingsAccount(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Content = new View.User.SettingsAccount(); 
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            SharedClass.OpenNewWindow(new Auth(), this);
        }



    }
}
