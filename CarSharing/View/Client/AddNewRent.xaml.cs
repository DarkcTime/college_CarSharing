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
    /// Interaction logic for AddNewRent.xaml
    /// </summary>
    public partial class AddNewRent : Page
    {

        public static CarSharing.Model.Car SelectedCar { private get; set; }

        public static CarSharing.Model.City SelectedCity { private get; set; }

        public AddNewRent()
        {
            try
            {
                InitializeComponent();
                SetStartTextBlocks();
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
            
        }

        private void SetStartTextBlocks()
        {
            try
            {
                setTextAuto("");
                setTextCity("");
                setTextPrice("");

            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
                    }

        private void setTextAuto(string text)
        {
            this.TxtSelectedCar.Text = $"Car: {text}";
        }

        private void setTextCity(string text)
        {
            this.TxtSelectedCity.Text = $"City: {text}";
        }

        private void setTextPrice(string text)
        {
            this.TxtPriceInMinute.Text = $"Price in minute: {text}";
        }

        //change Price in window
        private void UpdatePrice()
        {
            try
            {
                int price = 0;
                if (SelectedCar != null) price += SelectedCar.TypeOfCar1.PriceInMinute;
                if (SelectedCity != null) price += SelectedCity.PriceInMinute;
                setTextPrice(price.ToString());
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
            
        }

        private void SelectCar(object sender, RoutedEventArgs routedEventArgs)
        {
            try
            {
                bool? dialogResult = new View.Client.SelectCar().ShowDialog();
                switch (dialogResult)
                {
                    case true:
                        setTextAuto(SelectedCar.CarMake1.NameMake);
                        UpdatePrice();
                    break;
                }
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
        }
        private void SelectCity(object sender, RoutedEventArgs routedEventArgs)
        {
            try
            {
                bool? dialogResult = new View.Client.SelectCity().ShowDialog();
                switch (dialogResult)
                {
                    case true:
                        setTextCity(SelectedCity.NameCity);
                        UpdatePrice();
                        break;
                }
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
        }

        private void Add(object sender, RoutedEventArgs routedEventArgs)
        {
            try
            {
                if (SelectedCar != null && SelectedCity != null)
                {
                    new Controller.Client().AddNewRent(SelectedCar, SelectedCity, Controller.User.AuthorizedUser);
                    SharedClass.MessageBoxInformation("Success");
                    SharedClass.OpenNewPage(this, new View.Client.MainMenu());
                }
                else
                    SharedClass.MessageBoxWarning("Выберите авто и город");

            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
        }
        private void Cancel(object sender, RoutedEventArgs routedEventArgs)
        {
            SharedClass.OpenNewPage(this, new View.Client.MainMenu());
        }

    }
}
