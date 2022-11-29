using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLast.Code
{
    internal class MechanicTask
    {
        public Vehicles VehicleInfo { get; set; }
        public Mechanic MechanicInfo { get; set; }
        public List<MechanicTask> MechanicTaskList { get; set; }

        public MechanicTask(Vehicles _vehicleInfo, Mechanic _mechanicInfo) 
        {
            VehicleInfo = _vehicleInfo;
            MechanicInfo = _mechanicInfo;
        }

        public MechanicTask()
        {
            MechanicTask mechanicTask = new();
        }
    }
}
