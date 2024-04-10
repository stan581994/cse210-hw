public class FileManager
{

    private List<Vehicle> vehiclesLists = new List<Vehicle>();
    private List<Account> accountLists = new List<Account>();

    public FileManager()
    {
        InitializeVehiclesData();
        InitialzeAccountData();
    }

    public List<Vehicle> getVehiclesList() { return vehiclesLists; }

    public List<Vehicle> getAvailableVehiclesList()
    {
        List<Vehicle> availableVehicleLists = new List<Vehicle>();
        foreach (Vehicle vehicle in vehiclesLists)
        {
            if (vehicle.GetIsAvailable())
            {
                availableVehicleLists.Add(vehicle);
            }
        }

        return availableVehicleLists;
    }
    public List<Account> getAccountList() { return accountLists; }
    public List<Account> getAvailableAccountList()
    {
        List<Account> availableAccountLists = new List<Account>();
        foreach (Account account in accountLists)
        {
          
            if (account.GetVehiclesRented() == "none")
            {
                availableAccountLists.Add(account);
            }
        }
        return availableAccountLists;
    }

    public List<Account> getAccountWithRentList()
    {
        List<Account> availableAccountLists = new List<Account>();
        foreach (Account account in accountLists)
        {
            if (account.GetVehiclesRented() != "none")
            {
                availableAccountLists.Add(account);
            }
        }
        return availableAccountLists;
    }
    public void addVehicle(Vehicle vehicle) { vehiclesLists.Add(vehicle); }

    public void UpdateSpecificVehicle(int index)
    {
        int newIndex = index - 1;
        vehiclesLists[newIndex].SetIsAvailable(false);
    }
    public void UpdateSpecificRentedVehicle(string uuid)
    {
        foreach (Vehicle vehicle in vehiclesLists)
        {
            if (vehicle.Getuuid() == uuid)
            {
                vehicle.SetIsAvailable(true);
            }
        }

    }

    public void UpdateSpecificAccount(string accountName, string uuid, double balance)
    {
        foreach (Account account in accountLists)
        {
            if (account.GetName() == accountName)
            {
                account.SetBalance(balance);
                account.SetVehiclesRented(uuid);
            }
        }
    }

    public void UpdateSpecificRentedAccount(string name, double balance)
    {
        int counter = 1;
        foreach (Account account in accountLists)
        {
            if (account.GetName() == name)
            {
                account.SetVehiclesRented("none");

            }
            counter++;
        }

    }

    public Account GetSpecificAccount(int index)
    {
        int newIndex = index - 1;
        return accountLists[newIndex];
    }

    public Vehicle GetSpecificVehicle(string uuid)
    {
        foreach (Vehicle vehicles in vehiclesLists)
        {
            if (vehicles.Getuuid() == uuid)
            {
                return vehicles;
            }
        }
        return null;
    }


    public void InitializeVehiclesData()
    {
        string filenamePrompt = $"..\\..\\..\\data\\vehicles.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        string[] linesPrompt = System.IO.File.ReadAllLines(filePathPrompts);
        foreach (String prompt in linesPrompt)
        {
            string[] line = prompt.Split(",");
            switch (line[0])
            {
                case "CAR":
                    Vehicle carVehicle = new Car(line[1], line[2], double.Parse(line[3]), double.Parse(line[4]), bool.Parse(line[5]), line[6]);
                    vehiclesLists.Add(carVehicle);
                    break;
                case "MOTORCYCLE":
                    Vehicle motorVehicle = new Motorcycle(line[1], line[2], double.Parse(line[3]), double.Parse(line[4]), bool.Parse(line[5]), line[6]);
                    vehiclesLists.Add(motorVehicle);
                    break;
                case "BICYCLE":
                    Vehicle bicycleVehicle = new Bicycle(line[1], line[2], double.Parse(line[3]), bool.Parse(line[4]), line[5]);
                    vehiclesLists.Add(bicycleVehicle);
                    break;

            }


        }
    }

    public void InitialzeAccountData()
    {
        string filenamePrompt = $"..\\..\\..\\data\\account.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        string[] linesPrompt = System.IO.File.ReadAllLines(filePathPrompts);
        foreach (String prompt in linesPrompt)
        {
            string[] line = prompt.Split(",");
            switch (line[0])
            {
                case "NORMAL":
                    Account normalAcc = new NormalAccount(line[1], line[2], double.Parse(line[3]), line[4]);
                    accountLists.Add(normalAcc);
                    break;
                case "PWD":
                    PWDAccount pwdAcc = new PWDAccount(line[1], line[2], double.Parse(line[3]), double.Parse(line[4]), line[5]);
                    accountLists.Add(pwdAcc);
                    break;
                case "SENIOR":
                    SeniorAccount senAcc = new SeniorAccount(line[1], line[2], double.Parse(line[3]), double.Parse(line[4]), line[5]);
                    accountLists.Add(senAcc);
                    break;

            }


        }
    }

    public void saveVehicles(Vehicle newVehicle)
    {
        vehiclesLists.Add(newVehicle);

        string filenamePrompt = $"..\\..\\..\\data\\vehicles.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        using (StreamWriter outputFile = new StreamWriter(filePathPrompts))
        {
            foreach (Vehicle vehicle in vehiclesLists)
            {
                if (vehicle is Car)
                {
                    outputFile.WriteLine($"CAR,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()},{((Car)vehicle).GetMileage()},{vehicle.GetIsAvailable()},{vehicle.Getuuid()}");
                }
                else if (vehicle is Motorcycle)
                {
                    outputFile.WriteLine($"MOTORCYCLE,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()},{((Motorcycle)vehicle).GetMileage()},{vehicle.GetIsAvailable()},{vehicle.Getuuid()}");

                }
                else
                {
                    outputFile.WriteLine($"BICYCLE,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()},{vehicle.GetIsAvailable()},{vehicle.Getuuid()}");

                }

            }



        }

        Console.WriteLine("Vehicle Saved Complete!");
        Console.WriteLine("press ENTER to continue...");
        Console.ReadLine();

    }

    public void saveAccount(Account newAccount)
    {
        accountLists.Add(newAccount);

        string filenamePrompt = $"..\\..\\..\\data\\account.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        using (StreamWriter outputFile = new StreamWriter(filePathPrompts))
        {
            foreach (Account account in accountLists)
            {
                if (account is NormalAccount)
                {
                    outputFile.WriteLine($"NORMAL,{account.GetName()},{account.GetAddress()},{account.GetBalance()},none");
                }
                else if (account is PWDAccount)
                {
                    outputFile.WriteLine($"PWD,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((PWDAccount)account).GetDiscountRate()},none");

                }
                else
                {
                    outputFile.WriteLine($"SENIOR,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((SeniorAccount)account).GetDiscountRate()},none");

                }

            }



        }

        Console.WriteLine("Account Saved Complete!");
        Console.WriteLine("press ENTER to continue...");
        Console.ReadLine();

    }

    public void removeVehicle(int index)
    {
        int newIndex = index - 1;
        vehiclesLists.RemoveAt(newIndex);
        string filenamePrompt = $"..\\..\\..\\data\\vehicles.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        using (StreamWriter outputFile = new StreamWriter(filePathPrompts))
        {

            foreach (Vehicle vehicle in vehiclesLists)
            {
                if (vehicle is Car)
                {
                    outputFile.WriteLine($"CAR,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()},{((Car)vehicle).GetMileage()},{vehicle.GetIsAvailable()},{vehicle.Getuuid()}");
                }
                else if (vehicle is Motorcycle)
                {
                    outputFile.WriteLine($"MOTORCYCLE,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()},{((Motorcycle)vehicle).GetMileage()},{vehicle.GetIsAvailable()},{vehicle.Getuuid()}");

                }
                else
                {
                    outputFile.WriteLine($"BICYCLE,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()},{vehicle.GetIsAvailable()},{vehicle.Getuuid()}");

                }

            }


        }

        Console.WriteLine("Vehicle Removed Complete!");

        Console.WriteLine("press ENTER to continue...");
        Console.ReadLine();

    }

    public void removeAccount(int index)
    {
        int newIndex = index - 1;
        accountLists.RemoveAt(newIndex);
        string filenamePrompt = $"..\\..\\..\\data\\account.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        using (StreamWriter outputFile = new StreamWriter(filePathPrompts))
        {

            foreach (Account account in accountLists)
            {
                if (account is NormalAccount)
                {
                    outputFile.WriteLine($"NORMAL,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{account.GetVehiclesRented()}");
                }
                else if (account is PWDAccount)
                {
                    outputFile.WriteLine($"PWD,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((PWDAccount)account).GetDiscountRate()},{account.GetVehiclesRented()}");

                }
                else
                {
                    outputFile.WriteLine($"SENIOR,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((SeniorAccount)account).GetDiscountRate()},{account.GetVehiclesRented()}");

                }

            }




        }

        Console.WriteLine("Account Removed Complete!");

        Console.WriteLine("press ENTER to continue....");
        Console.ReadLine();

    }

    public void UpdateRentedVehicle()
    {

        string filenamePrompt = $"..\\..\\..\\data\\account.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        using (StreamWriter outputFile = new StreamWriter(filePathPrompts))
        {

            foreach (Account account in accountLists)
            {
                if (account is NormalAccount)
                {
                    outputFile.WriteLine($"NORMAL,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{account.GetVehiclesRented()}");
                }
                else if (account is PWDAccount)
                {
                    outputFile.WriteLine($"PWD,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((PWDAccount)account).GetDiscountRate()},{account.GetVehiclesRented()}");

                }
                else
                {
                    outputFile.WriteLine($"SENIOR,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((SeniorAccount)account).GetDiscountRate()},{account.GetVehiclesRented()}");

                }

            }

        }


        string filenamePromptVehicle = $"..\\..\\..\\data\\vehicles.txt";
        string filePathPromptsVehicle = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePromptVehicle);
        using (StreamWriter outputFile = new StreamWriter(filePathPromptsVehicle))
        {
            foreach (Vehicle vehicle in vehiclesLists)
            {
                if (vehicle is Car)
                {
                    outputFile.WriteLine($"CAR,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()},{((Car)vehicle).GetMileage()},{vehicle.GetIsAvailable()},{vehicle.Getuuid()}");
                }
                else if (vehicle is Motorcycle)
                {
                    outputFile.WriteLine($"MOTORCYCLE,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()},{((Motorcycle)vehicle).GetMileage()},{vehicle.GetIsAvailable()},{vehicle.Getuuid()}");

                }
                else
                {
                    outputFile.WriteLine($"BICYCLE,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()},{vehicle.GetIsAvailable()},{vehicle.Getuuid()}");

                }

            }



        }

        Console.WriteLine("Rented Vehicle Saved Complete!");
        Console.WriteLine("press ENTER to continue...");
        Console.ReadLine();
    }




}