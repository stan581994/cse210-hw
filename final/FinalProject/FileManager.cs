public class FileManager
{

    private List<Vehicle> vehiclesLists = new List<Vehicle>();

    public FileManager()
    {
        InitializeVehiclesData();
    }

    public List<Vehicle> getVehiclesList() { return vehiclesLists; }
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

    public void saveVehicles(Vehicle newVehicle)
    {
        vehiclesLists.Add(newVehicle);

        string filenamePrompt = $"..\\..\\..\\data\\vehicles.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        using (StreamWriter outputFile = new StreamWriter(filePathPrompts))
        {
           foreach(Vehicle vehicle in vehiclesLists){
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

    public void removeVehicle(int index)
    {
        vehiclesLists.RemoveAt(index--);
        string filenamePrompt = $"..\\..\\..\\data\\vehicles.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        using (StreamWriter outputFile = new StreamWriter(filePathPrompts))
        {
           foreach(Vehicle vehicle in vehiclesLists){
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

        Console.WriteLine("Vehicle Removed Complete!");
        
        Console.WriteLine("Vehicle press ENTER to continue");
        Console.ReadLine();

    }

    


}