using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharing.Model
{
    class RentForStatistick
    {
        public CarSharing.Model.CarRental CarRental { get; set; }   

        public TimeSpan? Time { get; set; }

        public int Price { get; set; }

    }
}
