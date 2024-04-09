using System.Xml.Serialization;

public class RentalServiceManager
{
    private FileManager fileManager;

    public RentalServiceManager()
    {
        fileManager = new FileManager();
    }

    public void run()
    {
        int choice = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("======================== Rental Vehicle System ===========================");
            Console.WriteLine("");
            Console.WriteLine("1. Vehicle Dashboard");
            Console.WriteLine("2. Customer Dashboard");
            Console.WriteLine("3. Rent Dashboard");
            Console.WriteLine("4. Exit Program");
            Console.WriteLine("");
            Console.WriteLine("======================== Rental Vehicle System ===========================");
            Console.WriteLine("");

            Console.Write("Where do you want to go? ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    VehicleDashboard();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }

        } while (choice != 4);

    }


    public void VehicleDashboard()
    {
        int choice = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("======================== Rental Vehicle System ===========================");
            Console.WriteLine("=======================    Vehicle Dashboard     =========================");
            Console.WriteLine("");
            Console.WriteLine("1. View All Vehicles");
            Console.WriteLine("2. Add Vehicles");
            Console.WriteLine("3. Delete Vehicles");
            Console.WriteLine("4. Go back to Main menu");
            Console.WriteLine("");
            Console.WriteLine("======================== Rental Vehicle System ===========================");
            Console.WriteLine("");

            Console.Write("What do you want to do? ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayAllVehicles();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("");

                    Console.WriteLine("Goodbye and Have a Good Day!!");

                    break;
            }

        } while (choice != 4);


    }

    public void DisplayAllVehicles()
    {
        List<Vehicle> vehicles = fileManager.getVehiclesList();
        int count = 1;
        Console.Clear();
        Console.WriteLine("=======================    Vehicle Dashboard     =========================");
        Console.WriteLine("=======================   List of All Vehicles   =========================");
        Console.WriteLine("");
        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine($"{count++}. {vehicle.DisplayVehicle()} ");
            vehicle.DisplayVehicle();
        }
        Console.WriteLine("");
        Console.WriteLine("======================== Rental Vehicle System ===========================");
        Console.WriteLine("");
        Console.Write("press enter to go back to main Vehicle Dashboard....");
        Console.ReadLine();

    }
}