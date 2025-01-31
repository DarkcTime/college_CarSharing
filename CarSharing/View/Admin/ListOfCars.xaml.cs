﻿using CarSharing.Controller;
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
    /// Interaction logic for ListOfCars.xaml
    /// </summary>
    public partial class ListOfCars : Page
    {

        private Controller.Admin Admin = new Controller.Admin();

        private CarSharing.Model.Car SelectedCar; 

        public ListOfCars()
        {
            try
            {
                InitializeComponent();
                LoadDataAboutCars();
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
             
        }

        //load data in DataGrid and ComboBoxs
        private void LoadDataAboutCars()
        {
            try
            {
                this.ListCars.ItemsSource = Admin.getListCars();
                this.CmbCarColor.ItemsSource = Admin.getListColors();
                this.CmbTypeOfCar.ItemsSource = Admin.getListTypeOfCar();
                this.CmbCarMake.ItemsSource = Admin.getListCarMakes();
                this.CmbTypeEngine.ItemsSource = Admin.getListTypeEngines();

            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
        }

        //update data in DataGrid
        private void UpdateDataGrid()
        {
            try
            {
                this.ListCars.ItemsSource = null;
                this.ListCars.ItemsSource = Admin.getListCars();
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }

        }

        //set DataContext from Selected Row
        private void SelectCar(object sender, RoutedEventArgs routedEventArgs)
        {
            try
            {
                if (this.ListCars.SelectedItem != null)
                {
                    this.SelectedCar = (Model.Car)this.ListCars.SelectedItem;
                    this.DataContext = this.SelectedCar;
                }
            }
            catch (Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
                 
        }

        private void SaveEditAboutCar(object sender, RoutedEventArgs routedEventArgs)
        {
            try
            {
                if(!Admin.isSelected(SelectedCar))
                {
                    SharedClass.MessageBoxWarning("Выберите автомобиль в таблице");
                    return;
                }
                if (Admin.checkVIN(SelectedCar)) SharedClass.MessageBoxWarning("Все поля должны быть заполнены");
                else
                {
                    Controller.Model.SaveChanges();
                    SharedClass.MessageBoxInformation("Data Success Edit for selected car");
                    UpdateDataGrid();
                }
                
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
        private void DeleteSelectedCar(object sender, RoutedEventArgs routedEventArgs)
        {
            try
            {
                if (!Admin.isSelected(SelectedCar))
                {
                    SharedClass.MessageBoxWarning("Выберите автомобиль в таблице");
                    return;
                }
                Admin.RemoveCar(SelectedCar);
                SharedClass.MessageBoxInformation("Автомобиль успешно удален из таблицы");
                UpdateDataGrid();
                this.DataContext = null; 
            }
            catch(Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
        }

        //open window for add Car and Update data in DataGrid
        private void AddNewCar(object sender, RoutedEventArgs routedEventArgs)
        {
            try
            {
                new View.Admin.AddNewCar().ShowDialog();
                UpdateDataGrid(); 
                
            }
            catch(Exception ex)
            {
                SharedClass.MessageBoxError(ex);
            }
        }

    }
}
