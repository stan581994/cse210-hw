public class FileManager
{

    private List<Vehicle> vehiclesLists = new List<Vehicle>();

    public FileManager()
    {
        InitializeVehiclesData();
    }

    public List<Vehicle> getVehiclesList() { return vehiclesLists; }
    public void addVehicle(Vehicle vehicle) { vehiclesLists.Add(vehicle); }

    public void removeVehicle(Vehicle vehicle) { }


    public void InitializeVehiclesData()
    {
        string filenamePrompt = $"..\\..\\..\\data\\vehicles.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        string[] linesPrompt = System.IO.File.ReadAllLines(filePathPrompts);
        foreach (String prompt in linesPrompt)
        {
            string[] line = prompt.Split(",");
            switch(line[0]){
                case "CAR":
                    Vehicle carVehicle = new Car(line[1],line[2],double.Parse(line[3]),double.Parse(line[4])); 
                    vehiclesLists.Add(carVehicle);
                    break;
                case "MOTORCYCLE":
                    Vehicle motorVehicle = new Motorcycle(line[1],line[2],double.Parse(line[3]),double.Parse(line[4])); 
                    vehiclesLists.Add(motorVehicle);
                    break;
                case "BICYCLE":
                    Vehicle bicycleVehicle = new Bicycle(line[1],line[2],double.Parse(line[3])); 
                    vehiclesLists.Add(bicycleVehicle);
                    break;

            }
      

        }
    }


}