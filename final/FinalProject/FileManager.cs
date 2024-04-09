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
    public List<Account> getAccountList() { return accountLists; }
    public void addVehicle(Vehicle vehicle) { vehiclesLists.Add(vehicle); }


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
                    Vehicle carVehicle = new Car(line[1], line[2], double.Parse(line[3]), double.Parse(line[4]));
                    vehiclesLists.Add(carVehicle);
                    break;
                case "MOTORCYCLE":
                    Vehicle motorVehicle = new Motorcycle(line[1], line[2], double.Parse(line[3]), double.Parse(line[4]));
                    vehiclesLists.Add(motorVehicle);
                    break;
                case "BICYCLE":
                    Vehicle bicycleVehicle = new Bicycle(line[1], line[2], double.Parse(line[3]));
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
                    Account normalAcc = new NormalAccount(line[1], line[2], double.Parse(line[3]));
                    accountLists.Add(normalAcc);
                    break;
                case "PWD":
                    PWDAccount pwdAcc = new PWDAccount(line[1], line[2], double.Parse(line[3]), double.Parse(line[4]));
                    accountLists.Add(pwdAcc);
                    break;
                case "SENIOR":
                    SeniorAccount senAcc = new SeniorAccount(line[1], line[2], double.Parse(line[3]), double.Parse(line[4]));
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
                    outputFile.WriteLine($"CAR,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()},{((Car)vehicle).GetMileage()}");
                }
                else if (vehicle is Motorcycle)
                {
                    outputFile.WriteLine($"MOTORCYCLE,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()},{((Motorcycle)vehicle).GetMileage()}");

                }
                else
                {
                    outputFile.WriteLine($"BICYCLE,{vehicle.GetBrand()},{vehicle.GetModel()},{vehicle.GetRentPrice()}");

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
                    outputFile.WriteLine($"NORMAL,{account.GetName()},{account.GetAddress()},{account.GetBalance()}");
                }
                else if (account is PWDAccount)
                {
                    outputFile.WriteLine($"PWD,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((PWDAccount)account).GetDiscountRate()}");

                }
                else
                {
                    outputFile.WriteLine($"NORMAL,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((SeniorAccount)account).GetDiscountRate()}");

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
        accountLists.RemoveAt(newIndex);
        string filenamePrompt = $"..\\..\\..\\data\\account.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        using (StreamWriter outputFile = new StreamWriter(filePathPrompts))
        {
            foreach (Account account in accountLists)
            {
                if (account is NormalAccount)
                {
                    outputFile.WriteLine($"NORMAL,{account.GetName()},{account.GetAddress()},{account.GetBalance()}");
                }
                else if (account is PWDAccount)
                {
                    outputFile.WriteLine($"PWD,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((PWDAccount)account).GetDiscountRate()}");

                }
                else
                {
                    outputFile.WriteLine($"NORMAL,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((SeniorAccount)account).GetDiscountRate()}");

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
                    outputFile.WriteLine($"NORMAL,{account.GetName()},{account.GetAddress()},{account.GetBalance()}");
                }
                else if (account is PWDAccount)
                {
                    outputFile.WriteLine($"PWD,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((PWDAccount)account).GetDiscountRate()}");

                }
                else
                {
                    outputFile.WriteLine($"NORMAL,{account.GetName()},{account.GetAddress()},{account.GetBalance()},{((SeniorAccount)account).GetDiscountRate()}");

                }

            }




        }

        Console.WriteLine("Account Removed Complete!");

        Console.WriteLine("press ENTER to continue....");
        Console.ReadLine();

    }




}