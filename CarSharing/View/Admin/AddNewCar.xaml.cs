using CarSharing.Controller;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
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



namespace CarSharing.View.Admin
{
    /// <summary>
    /// Interaction logic for AddNewCar.xaml
    /// </summary>
    public partial class AddNewCar : Window
    {
        private readonly ILogger logger; 

        private Controller.Admin Admin = new Controller.Admin();

        private CarSharing.Model.Car NewCar = new CarSharing.Model.Car();

        public AddNewCar()
        {
            InitializeComponent();
            this.DataContext = NewCar;
            this.LoadDataAddCar();
        }

        private void LoadDataAddCar()
        {
            this.CmbCarColor.ItemsSource = Admin.getListColors();
            this.CmbTypeOfCar.ItemsSource = Admin.getListTypeOfCar();
            this.CmbCarMake.ItemsSource = Admin.getListCarMakes();
            this.CmbTypeEngine.ItemsSource = Admin.getListTypeEngines();
        }


        private void AddCar(object sender, RoutedEventArgs routedEventArgs)
        {

            
            try
            { 
  
                if (Admin.checkVIN(NewCar)) SharedClass.MessageBoxWarning("Все поля должны быть заполнены");
                else {
                    Admin.AddCar(NewCar);
                    SharedClass.MessageBoxInformation("Автомобиль успешно добавлен в базу данных");
                    this.Close();
                }
                
            }
            catch (DbEntityValidationException)
            {
                SharedClass.MessageBoxWarning("Заполните все поля");
            }
            catch (NullReferenceException)
            {
                SharedClass.MessageBoxWarning("Все поля должны быть заполнены");
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
            
        }

        private void Cancel(object sender, RoutedEventArgs routedEventArgs)
        {
            this.Close();
        }

    }
}
