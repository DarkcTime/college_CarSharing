using CarSharing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharing.Controller
{
    class Model
    {
        protected static CarSharing.Model.CarSharingEntities carShaeringEntities = new CarSharing.Model.CarSharingEntities();

        public static void SaveChanges()
        {
            carShaeringEntities.SaveChanges();
        }

    }
}
