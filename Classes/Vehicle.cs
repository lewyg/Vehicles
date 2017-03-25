using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Classes
{
    public enum VehicleType
    {
        Car = 0,
        Truck = 1,
        Motorbike = 2
    }
    public class Vehicle
    {
        public String Brand { get; set; }

        public DateTime ProductionDate { get; set; }

        public Int32 MaxSpeed { get; set; }

        public Int32 Type { get; set; }

        public Vehicle(String brand = "None", DateTime production_date = new DateTime(), Int32 max_speed = 0, Int32 type = (int)VehicleType.Car)
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
