using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Classes
{
    public enum VehicleType
    {
        None = 0,
        Car = 1,
        Truck = 2,
        Motorbike = 3
    }
    public class Vehicle
    {
        public string Brand { get; set; }

        public DateTime ProductionDate { get; set; }

        public double MaxSpeed { get; set; }

        public int Type { get; set; }

        public Vehicle(string brand = "None", DateTime production_date = new DateTime(), double max_speed = 0, int type = (int)VehicleType.None)
        {
            Brand = brand;
            ProductionDate = production_date;
            MaxSpeed = max_speed;
            Type = type;
        }

        public Vehicle(Vehicle vehicle)
        {
            Brand = vehicle.Brand;
            ProductionDate = vehicle.ProductionDate;
            MaxSpeed = vehicle.MaxSpeed;
            Type = vehicle.Type;
        }
    }
}
