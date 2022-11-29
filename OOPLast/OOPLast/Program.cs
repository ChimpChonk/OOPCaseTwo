Mechanic UnNamed = new("Unkown", "Unkown", 00000000, "Unkown", new(VehiclesEnum.Unkown.ToString()));
Mechanic Martin = new("Martin", "Jensen", 11111111, "Car Mechanic", new(VehiclesEnum.Car.ToString()));
Mechanic Thomas = new("Thomas", "Hansen", 22222222, "Motorcycle Mechanic", new(VehiclesEnum.Motorcycle.ToString()));
Mechanic Henrik = new("Henrik", "Nielsen", 33333333, "Truck Mechanic", new(VehiclesEnum.Truck.ToString()));

//All mechanic Obj
//List<Mechanic> mechanicsList = new List<Mechanic>();
//mechanicsList.Add(UnNamed);
//mechanicsList.Add(Martin);
//mechanicsList.Add(Thomas);
//mechanicsList.Add(Henrik);

// dictionary that store course enum and its index
Dictionary<VehiclesEnum, int> vehicleEnumDic = new Dictionary<VehiclesEnum, int>()
{
    {VehiclesEnum.Unkown,(int)VehiclesEnum.Unkown },
    {VehiclesEnum.Car,(int)VehiclesEnum.Car },
    {VehiclesEnum.Motorcycle,(int)VehiclesEnum.Motorcycle },
    {VehiclesEnum.Truck,(int)VehiclesEnum.Truck }
};

List<Mechanic> mechList = new List<Mechanic>();
mechList.Add(UnNamed);
mechList.Add(Martin);
mechList.Add(Thomas);
mechList.Add(Henrik);

Customer Cus1 = new("Peter", "PerterSon", 11224455);
Customer Cus2 = new("Tom", "Tomson", 13422455);
Customer Cus3 = new("Cringe", "Cringeson", 11118888);
Customer Cus4 = new("gdgds", "Crinhdfggdgeson", 54445544);
Customer Cus5 = new("gdgd", "h4dgds", 78789898);
Customer Cus6 = new("4y43y", "gfdgfd", 54775544);

Vehicles V1 = new("Audi", "R8", "11-07-2019", "CV68999", "car", Cus1);
Vehicles V2 = new("Honda", "CB500x", "11-07-2019", "DM47000", "motorcycle", Cus2);
Vehicles V3 = new("Scania", "V8", "11-07-2019", "SC88228", "truck", Cus3);
Vehicles V4 = new("Volvo", "V1", "11-07-2019", "VL88228", "truck", Cus4);
Vehicles V5 = new("Renault", "R2", "11-07-2019", "RA22244", "truck", Cus5);
Vehicles V6 = new("Merc", "M1", "11-07-2019", "MR19595", "truck", Cus5);
Vehicles V7 = new("Honda", "CB500-F", "11-07-2019", "CM75333", "motorcycle", Cus5);

List<MechanicTask> mechanicTasks = new List<MechanicTask>();
mechanicTasks.Add(new MechanicTask(V1, Martin));
mechanicTasks.Add(new MechanicTask(V2, Thomas));
mechanicTasks.Add(new MechanicTask(V3, Henrik));
mechanicTasks.Add(new MechanicTask(V4, Henrik));
mechanicTasks.Add(new MechanicTask(V5, Henrik));
mechanicTasks.Add(new MechanicTask(V6, Henrik));
mechanicTasks.Add(new MechanicTask(V7, Thomas));

string custName = "fasfsa 543ewrsf";
string[] sub = custName.Split(' ');
string veh = "";
if (sub[0] == Henrik.FirstName && sub[1] == Henrik.LastName)
{
    veh = Henrik.VehicleType;
}
else if (sub[0] == Cus3.FirstName && sub[1] == Cus3.LastName)
{
    veh = V3.VehicleType;
}
VehiclesEnum _vehiclesEnum;
if (Enum.TryParse<VehiclesEnum>(veh, true, out _vehiclesEnum))
{
    int vehIndex = vehicleEnumDic.GetValueOrDefault(_vehiclesEnum);
    Mechanic mechanic = mechList[vehIndex];

    foreach (var item in mechanicTasks)
    {
        if (item.MechanicInfo.VehicleType == _vehiclesEnum.ToString())
        {
            foreach (var item2 in mechanicTasks)
            {
                if (item.VehicleInfo.Customers.FirstName == sub[0] && item.VehicleInfo.Customers.LastName == sub[1])
                {

                    Console.WriteLine($"{item.MechanicInfo.FirstName} {item.MechanicInfo.LastName} Vehicles: {item2.VehicleInfo.Brand} {item2.VehicleInfo.Model} {item2.VehicleInfo.NummerPlate}");
                }
            }
            if (item.MechanicInfo.FirstName == sub[0] && item.MechanicInfo.LastName == sub[1])
            {
                Console.WriteLine($"Vehicles: {item.VehicleInfo.Brand} {item.VehicleInfo.Model} {item.VehicleInfo.NummerPlate} Customer TelNr: {item.VehicleInfo.Customers.TeleNr}");
            }
        }
    }
}
else
{
    Console.WriteLine("Vehicle not found");
}