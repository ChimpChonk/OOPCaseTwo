using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLast.Code
{
    internal class Vehicles
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? RegisterationDate { get; set; }
        public string? NummerPlate { get; set; }
        public string? VehicleType { get; set; }
        public Customer Customers { get; set; }

        public Vehicles(string _brand, string _model, string _registerationDate, string _nummerPlate, string _vehicleType, Customer _customers) 
        {
            Brand = _brand;
            Model= _model;
            RegisterationDate = DateFormat(_registerationDate);
            NummerPlate= _nummerPlate;
            VehicleType = _vehicleType;
            Customers = _customers;
        }

        public string DateFormat(string registerationDate)
        {
            RegisterationDate= registerationDate;
            DateTime _date = DateTime.Parse(registerationDate);
            return _date.ToString();
        }
    }
}
