using System;

class Program
{
     static List<Vehicle> vehicles = new List<Vehicle>();
    static void Main(string[] args)
    {
       
        string employeeName;
        int employeeId;

       
        Console.Write("Enter Employee Name : ");
        employeeName = Console.ReadLine()!;

      
        Console.Write("Enter Employee ID : ");
        employeeId = Convert.ToInt32(Console.ReadLine());

       
        Console.WriteLine();
        Console.WriteLine("Welcome " + employeeName);


          // Main Menu
        while (true)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("ABC MOTORS");
            Console.WriteLine("Vehicle Management System");
            Console.WriteLine("==============================");

            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. View All Vehicles");
            Console.WriteLine("3. Search Vehicle");
            Console.WriteLine("4. Update Vehicle Price");
            Console.WriteLine("5. Delete Vehicle");
            Console.WriteLine("6. Calculate Discount");
            Console.WriteLine("7. Show Vehicle Details");
            Console.WriteLine("8. Exit");

            Console.Write("\nEnter your choice : ");

            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Add Vehicle Selected");
                     AddVehicle();
                    break;

                case 2:
                    Console.WriteLine("View Vehicle Selected");
                      DisplayVehicles();
                    break;

                case 3:
                    Console.WriteLine("Search Vehicle Selected");
                     SearchVehicle();
                    break;

                case 4:
                    Console.WriteLine("Update Price Selected");
                    UpdateVehiclePrice();
                    break;

                case 5:
                    Console.WriteLine("Delete Vehicle Selected");
                     DeleteVehicle();
                    break;

                case 6:
                    Console.WriteLine("Calculate Discount Selected");
                    CalculateDiscount();
                    break;

                case 7:
                    Console.WriteLine("Show Vehicle Details Selected");
                    ShowVehicleDetails();
                    break;

                case 8:
                    Console.WriteLine("Thank you for using ABC Motors System.");
                    return;   // Ends the Main() method and exits the program

                default:
                    Console.WriteLine("Invalid Choice! Please try again.");
                    break;
            }
        }
            ///// add vehicle
            

             static void AddVehicle()
{
    Vehicle vehicle = new Vehicle();

    Console.Write("Enter Vehicle ID : ");
    vehicle.VehicleId = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Vehicle Name : ");
    vehicle.VehicleName = Console.ReadLine()!;

    Console.Write("Enter Vehicle Type : ");
    vehicle.VehicleType = Console.ReadLine()!;

    Console.Write("Enter Brand : ");
    vehicle.Brand = Console.ReadLine()!;

    Console.Write("Enter Price : ");
    vehicle.Price = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter Manufacturing Year : ");
    vehicle.ManufacturingYear = Convert.ToInt32(Console.ReadLine());

    vehicles.Add(vehicle);

    Console.WriteLine("\nVehicle Added Successfully.");
}
        /////// Display Vehicles
    

         static void DisplayVehicles()
{
    if (vehicles.Count == 0)
    {
        Console.WriteLine("No vehicles available.");
        return;
    }

    Console.WriteLine("\n---------------------------------------------------------------");
    Console.WriteLine("ID\tName\tBrand\tType\tPrice\t\tYear");
    Console.WriteLine("---------------------------------------------------------------");

    foreach (Vehicle vehicle in vehicles)
    {
        Console.WriteLine($"{vehicle.VehicleId}\t{vehicle.VehicleName}\t{vehicle.Brand}\t{vehicle.VehicleType}\t{vehicle.Price}\t{vehicle.ManufacturingYear}");
    }
}

    /// Search vehicles
    
     static void SearchVehicle()
{
    Console.Write("Enter Vehicle ID to Search : ");
    int searchId = Convert.ToInt32(Console.ReadLine());

    bool found = false;

    foreach (Vehicle vehicle in vehicles)
    {
        if (vehicle.VehicleId == searchId)
        {
            Console.WriteLine("\nVehicle Found");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"ID    : {vehicle.VehicleId}");
            Console.WriteLine($"Name  : {vehicle.VehicleName}");
            Console.WriteLine($"Type  : {vehicle.VehicleType}");
            Console.WriteLine($"Brand : {vehicle.Brand}");
            Console.WriteLine($"Price : {vehicle.Price}");
            Console.WriteLine($"Year  : {vehicle.ManufacturingYear}");

            found = true;
            break;
        }
    }

    if (!found)
    {
        Console.WriteLine("Vehicle not found.");
    }
}

    ///updated 
    
    static void UpdateVehiclePrice()
{
    Console.Write("Enter Vehicle ID : ");
    int updateId = Convert.ToInt32(Console.ReadLine());

    bool found = false;

    foreach (Vehicle vehicle in vehicles)
    {
        if (vehicle.VehicleId == updateId)
        {
            Console.Write("Enter New Price : ");
            vehicle.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vehicle price updated successfully.");

            found = true;
            break;
        }
    }

    if (!found)
    {
        Console.WriteLine("Vehicle ID does not exist.");
    }
}
    // delete vehicle



     static void DeleteVehicle()
{
    Console.Write("Enter Vehicle ID : ");
    int deleteId = Convert.ToInt32(Console.ReadLine());

    Vehicle vehicleToDelete = null!;

    foreach (Vehicle vehicle in vehicles)
    {
        if (vehicle.VehicleId == deleteId)
        {
            vehicleToDelete = vehicle;
            break;
        }
    }

    if (vehicleToDelete != null)
    {
        vehicles.Remove(vehicleToDelete);
        Console.WriteLine("Vehicle deleted successfully.");
    }
    else
    {
        Console.WriteLine("Vehicle not available.");
    }
}

     // discount
      
    static void CalculateDiscount()
{
    Console.Write("Enter Vehicle ID : ");
    int discountId = Convert.ToInt32(Console.ReadLine());

    bool found = false;

    foreach (Vehicle vehicle in vehicles)
    {
        if (vehicle.VehicleId == discountId)
        {
            double discount = 0;

            if (vehicle.VehicleType.Equals("Car", StringComparison.OrdinalIgnoreCase))
            {
                discount = vehicle.Price * 0.10;
            }
            else if (vehicle.VehicleType.Equals("Bike", StringComparison.OrdinalIgnoreCase))
            {
                discount = vehicle.Price * 0.05;
            }
            else if (vehicle.VehicleType.Equals("Truck", StringComparison.OrdinalIgnoreCase))
            {
                discount = vehicle.Price * 0.12;
            }

            double finalPrice = vehicle.Price - discount;

            Console.WriteLine("\nVehicle Price : " + vehicle.Price);
            Console.WriteLine("Discount : " + discount);
            Console.WriteLine("Final Price : " + finalPrice);

            found = true;
            break;
        }
    }

    if (!found)
    {
        Console.WriteLine("Vehicle not found.");
    }
}
     
    ///module 9

    static void ShowVehicleDetails()
{
    Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
    string vehicleType = Console.ReadLine()!;

    switch (vehicleType.ToLower())
    {
        case "car":
            Console.WriteLine("\nCar is a four wheeler.");
            Console.WriteLine("Suitable for family.");
            break;

        case "bike":
            Console.WriteLine("\nBike is fuel efficient.");
            Console.WriteLine("Suitable for city rides.");
            break;

        case "truck":
            Console.WriteLine("\nTruck is used for transportation.");
            Console.WriteLine("Heavy load vehicle.");
            break;

        default:
            Console.WriteLine("Invalid Vehicle Type.");
            break;
    }
} 



    }



}

