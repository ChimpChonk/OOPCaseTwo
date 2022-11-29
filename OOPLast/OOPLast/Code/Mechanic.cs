using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLast.Code
{
    sealed class Mechanic : Person
    {
        public string Task { get; set; }
        public string VehicleType { get; set; }

        public Mechanic(string firstName , string lastName, int teleNr, string task, string vehicleType) : base(firstName, lastName, teleNr)
        {
            Task = task;
            VehicleType = vehicleType;
        }
    }
}
