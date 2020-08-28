using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CarSharing.Controller
{
    class Admin : Model
    {

        public List<CarSharing.Model.Car> getListCars()
        {
           //carShaeringEntities.Cars.First().

            return carShaeringEntities.Cars.ToList();

        }

        public void RemoveCar(CarSharing.Model.Car car)
        {
            carShaeringEntities.Cars.Remove(car);
            Model.SaveChanges();
        }

        public void AddCar(CarSharing.Model.Car car)
        {
            car.CarMake = car.CarMake1.IdMake;
            car.TypeOfCar = car.TypeOfCar1.IdTypeOfCar;
            car.TypeEngine = car.TypeEngine1.IdEngine;
            car.CarColor = car.CarColor1.IdColor;
            carShaeringEntities.Cars.Add(car);
            Model.SaveChanges();
        }

        public List<CarSharing.Model.CarMake> getListCarMakes()
        {
            return carShaeringEntities.CarMakes.ToList();
        }
        public List<CarSharing.Model.TypeOfCar> getListTypeOfCar()
        {
            return carShaeringEntities.TypeOfCars.ToList();
        }
        public List<CarSharing.Model.CarColor> getListColors()
        {
            return carShaeringEntities.CarColors.ToList();
        }
        public List<CarSharing.Model.TypeEngine> getListTypeEngines()
        {
            return carShaeringEntities.TypeEngines.ToList();
        }

        public bool checkVIN(CarSharing.Model.Car car)
        {
            return String.IsNullOrWhiteSpace(car.VIN); 
        }

        
        public bool isSelected(CarSharing.Model.Car car)
        {
            return car != null; 
         
        }
        
    }
}
