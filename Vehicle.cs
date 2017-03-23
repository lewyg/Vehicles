using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
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

        public double MaxSpeed { get
            {
                return MaxSpeed;
            }
            set
            {
                MaxSpeed = value >= 0 ? value : 0;
            }
        }

        public VehicleType Type { get; set; }

        public Vehicle(string brand = "None", DateTime production_date = new DateTime(), double max_speed = 0, VehicleType type = VehicleType.None)
        {
            Brand = brand;
            ProductionDate = production_date;
            MaxSpeed = max_speed;
            Type = type;
        }
    }
}
