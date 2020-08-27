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

namespace CarSharing.View.User
{
    /// <summary>
    /// Interaction logic for SettingsAccount.xaml
    /// </summary>
    public partial class SettingsAccount : Page
    {
        public SettingsAccount()
        {
            InitializeComponent();
            DataContext = Controller.User.AuthorizedUser;
            TblRole.Text = $"Your Role: {Controller.User.AuthorizedUser.Role.NameRole}"; 
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            try
            {
                if(!new Controller.User().CheckFields(Controller.User.AuthorizedUser.Email, Controller.User.AuthorizedUser.Password, 
                    Controller.User.AuthorizedUser.FirstName, Controller.User.AuthorizedUser.LastName)) return;
                
                Controller.Model.SaveChanges();
                
                SharedClass.MessageBoxInformation("Данные о пользователе успешно отредактированы");

                SharedClass.OpenNewPage(this, new View.Admin.MainMenu());
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
            
        }
    }
}
