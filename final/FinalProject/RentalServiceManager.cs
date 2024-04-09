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
                    AccountDashboard();
                    break;
                case 3:
                    RentVehicleDashboard();
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
                    DisplayAllInfo(false, "VEHICLES");
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

    public void AccountDashboard()
    {
        int choice = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("======================== Rental Vehicle System ===========================");
            Console.WriteLine("=======================    Account Dashboard     =========================");
            Console.WriteLine("");
            Console.WriteLine("1. View All Accounts");
            Console.WriteLine("2. Add Account");
            Console.WriteLine("3. Remove Account");
            Console.WriteLine("4. Go back to Main menu");
            Console.WriteLine("");
            Console.WriteLine("======================== Rental Vehicle System ===========================");
            Console.WriteLine("");

            Console.Write("What do you want to do? ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayAllInfo(false, "ACCOUNT");
                    break;
                case 2:
                    AddAccount();
                    break;
                case 3:
                    RemoveAccount();
                    break;
                case 4:
                    Console.WriteLine("");

                    Console.WriteLine("Goodbye and Have a Good Day!!");

                    break;
            }

        } while (choice != 4);


    }

    public void RentVehicleDashboard()
    {
        int choice = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("======================== Rental Vehicle System ===========================");
            Console.WriteLine("=======================    Rent Vehicle Dashboard     =========================");
            Console.WriteLine("");
            Console.WriteLine("1. Rent Available Vehicles");
            Console.WriteLine("2. Return Rented Vehicles");
            Console.WriteLine("3. Go back to Main menu");
            Console.WriteLine("");
            Console.WriteLine("======================== Rental Vehicle System ===========================");
            Console.WriteLine("");

            Console.Write("What do you want to do? ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RentAvailableVehicle();
                    break;
                case 2:
                    ReturnRentedVehicle();
                    break;
                case 3:
                    break;


            }

        } while (choice != 4);


    }

    public void DisplayAllInfo(Boolean skip, string category)
    {

        Console.Clear();
        Console.WriteLine($"=======================    {category} Dashboard     =========================");
        Console.WriteLine($"=======================   List of All {category}   =========================");
        Console.WriteLine("");

        if (category == "VEHICLES")
        {
            List<Vehicle> vehicles = fileManager.getVehiclesList();
            int count = 1;
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"{count++}. {vehicle.DisplayVehicle()} ");
            }
        }
        else if (category == "ACCOUNT")
        {
            List<Account> accounts = fileManager.getAccountList();
            int count = 1;
            foreach (Account account in accounts)
            {
                Console.WriteLine($"{count++}. {account.displayAccount()}");

            }

        }
        else
        {
            List<Vehicle> vehicles = fileManager.getVehiclesList();
            List<Vehicle> availVehicles = new List<Vehicle>();
            int count = 1;

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.GetIsAvailable())
                {
                    availVehicles.Add(vehicle);
                }
            }

            foreach (Vehicle vehicle in availVehicles)
            {
                Console.WriteLine($"{count++}. {vehicle.DisplayVehicle()} ");
            }
        }


        if (!skip)
        {
            Console.WriteLine("");
            Console.WriteLine("======================== Rental Vehicle System ===========================");
            Console.WriteLine("");
            Console.Write($"press enter to go back to main Vehicle {category}....");
            Console.ReadLine();

        }
        else
        {
            Console.WriteLine($"0. Go back to {category} Dashboard....");
            Console.WriteLine("");
            Console.WriteLine("======================== Rental Vehicle System ===========================");
            Console.WriteLine("");

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
                    Car car = new Car(model, brand, rentPrice, mileage, true);
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
                    Motorcycle motorcycle = new Motorcycle(mModel, mbrand, mrentPrice, mMileage, true);
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
                    Bicycle bicycle = new Bicycle(bmodel, bbrand, brentPrice, true);
                    fileManager.saveVehicles(bicycle);
                    break;
                case 4:
                    break;
            }

        } while (choice != 4);


        Console.WriteLine("======================== Rental Vehicle System ===========================");
        Console.WriteLine("");


    }

    public void AddAccount()
    {

        int choice = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("=======================    Customer Dashboard     =========================");
            Console.WriteLine("=======================   Add new Account       =========================");
            Console.WriteLine("");
            Console.WriteLine("What type of Account do you want to add?");
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. PWD");
            Console.WriteLine("3. Senior");
            Console.WriteLine("4. Go back to Account Dashboard...");
            Console.WriteLine("");
            Console.Write("What is your choice? ");

            choice = int.Parse(Console.ReadLine());

            if (choice != 4)
            {
                Console.WriteLine("");
                Console.WriteLine("Added a new Account in the record:");
                Console.Write("What is the name of the Account? ");
                string name = Console.ReadLine();
                Console.Write("What is the address?  ");
                string address = Console.ReadLine();

                Account account;

                switch (choice)
                {
                    case 1:
                        account = new NormalAccount(name, address, 0, 0);
                        break;
                    case 2:
                        account = new PWDAccount(name, address, 0, 0.15, 0);
                        break;
                    default:
                        account = new SeniorAccount(name, address, 0, 0.20, 0);
                        break;
                }


                fileManager.saveAccount(account);
            }



        } while (choice != 4);


        Console.WriteLine("======================== Rental Vehicle System ===========================");
        Console.WriteLine("");


    }

    public void RemoveVehicles()
    {

        Console.Clear();
        Console.WriteLine("=======================    Vehicle Dashboard     =========================");
        Console.WriteLine("=======================     Remove Vehicles      =========================");

        DisplayAllInfo(true, "VEHICLES");
        Console.WriteLine("0. Go back to Customer Dashboard....");

        int index = 0;
        Console.Write("Which Vehicles do you want to remove? [number only] ");
        index = int.Parse(Console.ReadLine());
        if (index != 0)
        {
            fileManager.removeVehicle(index);
        }


    }

    public void RemoveAccount()
    {

        Console.Clear();
        Console.WriteLine("=======================    Customer Dashboard     =========================");
        Console.WriteLine("=======================     Remove Account        =========================");

        DisplayAllInfo(true, "ACOUNT");

        int index;
        Console.Write("Which Account do you want to remove? [number only] ");
        index = int.Parse(Console.ReadLine());
        if (index != 0)
        {
            fileManager.removeAccount(index);
        }


    }

    public void RentAvailableVehicle()
    {
        Console.Clear();
        Console.WriteLine("=======================    Customer Dashboard     =========================");
        Console.WriteLine("=======================     Rent Vehicles          =========================");

        DisplayAllInfo(true, "RENTED_VEHICLES");

        int index;
        Console.Write("Which Vehicles do you want to rent? [number only] ");
        index = int.Parse(Console.ReadLine());

        if (index != 0)
        {
            List<Account> accounts = fileManager.getAccountList();

            int num = 0;
            foreach (Account account in accounts)
            {
                if (account.GetVehiclesRented() == 0)
                {
                    num++;
                    Console.WriteLine($"{num}. {account.GetName()}");

                }

            }

            Console.Write("Who will be renting this vehicle? [number only] ");
            Vehicle vehicleChose = fileManager.GetSpecificVehicle(index);
            int ChoiceAccount = int.Parse(Console.ReadLine());
            fileManager.UpdateSpecificVehicle(index);
            fileManager.UpdateSpecificAccount(ChoiceAccount, vehicleChose.GetRentPrice());
            fileManager.UpdateRentedVehicle();

        }

    }

    public void ReturnRentedVehicle()
    {
        Console.Clear();
        Console.WriteLine("=======================    Return Vehicles Dashboard     =========================");
        Console.WriteLine("=======================     Return Vehicles          =========================");
        List<Account> accounts = fileManager.getAccountList();
        List<Account> accountsWithRent = new List<Account>();
        foreach (Account account in accounts)
        {
            if (account.GetVehiclesRented() != 0)
            {
                accountsWithRent.Add(account);
            }
        }

        int count = 0;
        foreach (Account account in accountsWithRent)
        {
            count++;
            Console.WriteLine($"{count}.  {account.GetName()}");
        }

        Console.WriteLine("");
        Console.WriteLine("Which Account who will return the vehicle? ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        int newChoice = choice -1;
        Account returnAccount = accountsWithRent[choice];
        Console.WriteLine("This account")


    }
}