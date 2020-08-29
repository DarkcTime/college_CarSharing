using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharing.Controller
{
    class Client : Model
    {
        public void AddNewRent(CarSharing.Model.Car car, CarSharing.Model.City city, CarSharing.Model.User user)
        {

                CarSharing.Model.CarRental carRental = new CarSharing.Model.CarRental()
                {
                    CarId = car.IdCar,
                    CityId = city.IdCity,
                    UserId = user.IdUsers,
                    DateTimeStart = DateTime.Now
                };
                carShaeringEntities.CarRentals.Add(carRental);
                Model.SaveChanges();

        }


        public List<CarSharing.Model.RentCarForUser> getListRentForUser(CarSharing.Model.User user)
        {

            List<CarSharing.Model.RentCarForUser> rentCarForUsers = carShaeringEntities.CarRentals.Select(i => new CarSharing.Model.RentCarForUser()
            {
                CarRental = i,
                PriceInMinuteDollar = i.Car.TypeOfCar1.PriceInMinute + i.City.PriceInMinute
            }).ToList();

            return rentCarForUsers; 
        }

    }
}
