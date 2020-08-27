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

namespace CarSharing.View.User
{
    /// <summary>
    /// Interaction logic for Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void ClickBtnSing(object sender, RoutedEventArgs e)
        {
            try
            {
                Controller.User user = new Controller.User();

                string login = this.TxbLogin.Text;

                string password = this.PsbPassword.Password; 

                if (!user.CheckFields(login, password)) return;
                
                //authorization user
                if(!user.AuthUser(login, password)) return;

                //open MainPage if User has 
                SharedClass.OpenNewWindow(new MainWindow(), this);
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex.Message);
            }

        }

        private void ClickBtnExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
