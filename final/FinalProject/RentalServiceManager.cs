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
            Console.WriteLine("3. Remove Vehicles");
            Console.WriteLine("4. Go back to Main menu");
            Console.WriteLine("");
            Console.WriteLine("======================== Rental Vehicle System ===========================");
            Console.WriteLine("");

            Console.Write("What do you want to do? ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayAllVehicles(false);
                    break;
                case 2:
                    AddVehicles();
                    break;
                case 3:
                    RemoveVehicles();
                    break;
                case 4:
                    Console.WriteLine("");

                    Console.WriteLine("Goodbye and Have a Good Day!!");

                    break;
            }

        } while (choice != 4);


    }

    public void DisplayAllVehicles(Boolean skip)
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
        if (!skip)
        {
            Console.Write("press enter to go back to main Vehicle Dashboard....");
            Console.ReadLine();

        }


    }

    public void AddVehicles()
    {

        int choice = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("=======================    Vehicle Dashboard     =========================");
            Console.WriteLine("=======================   Add new Vehicles       =========================");
            Console.WriteLine("");
            Console.WriteLine("What type of Vehicles do you want to add?");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Motorcycle");
            Console.WriteLine("3. Bicycle");
            Console.WriteLine("4. Go back to Vehicle Dashboard...");
            Console.WriteLine("");
            Console.Write("What is your choice? ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Added a new Car in the record:");
                    Console.Write("What is the Brand of the Car? ");
                    string brand = Console.ReadLine();
                    Console.Write("What is the model of the Car? ");
                    string model = Console.ReadLine();
                    Console.Write("What is the current milleage of the Car? ");
                    double mileage = double.Parse(Console.ReadLine());
                    Console.Write("What is the rent price of the Car? ");
                    double rentPrice = double.Parse(Console.ReadLine());
                    Car car = new Car(model, brand, rentPrice, mileage);
                    fileManager.saveVehicles(car);

                    break;
                case 2:

                    Console.WriteLine("");
                    Console.WriteLine("Added a new Motorcycle in the record:");
                    Console.Write("What is the Brand of the Motorcycle? ");
                    string mbrand = Console.ReadLine();
                    Console.Write("What is the model of the Motorcycle? ");
                    string mModel = Console.ReadLine();
                    Console.Write("What is the current milleage of the Motorcycle? ");
                    double mMileage = double.Parse(Console.ReadLine());
                    Console.Write("What is the rent price of the Motorcycle? ");
                    double mrentPrice = double.Parse(Console.ReadLine());
                    Motorcycle motorcycle = new Motorcycle(mModel, mbrand, mrentPrice, mMileage);
                    fileManager.saveVehicles(motorcycle);
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Added a new Bicycle in the record:");
                    Console.Write("What is the Brand of the Bicycle? ");
                    string bbrand = Console.ReadLine();
                    Console.Write("What is the model of the Bicycle? ");
                    string bmodel = Console.ReadLine();
                    Console.Write("What is the rent price of the Bicycle? ");
                    double brentPrice = double.Parse(Console.ReadLine());
                    Bicycle bicycle = new Bicycle(bmodel, bbrand, brentPrice);
                    fileManager.saveVehicles(bicycle);
                    break;
                case 4:
                    break;
            }

        } while (choice != 4);


        Console.WriteLine("======================== Rental Vehicle System ===========================");
        Console.WriteLine("");


    }

    public void RemoveVehicles()
    {

        Console.Clear();
        Console.WriteLine("=======================    Vehicle Dashboard     =========================");
        Console.WriteLine("=======================   Remove new Vehicles    =========================");

        DisplayAllVehicles(true);

        int index = 0;
        Console.Write("Which Vehicles do you want to remove? [number only] ");
        index = int.Parse(Console.ReadLine());
        fileManager.removeVehicle(index);

    }
}