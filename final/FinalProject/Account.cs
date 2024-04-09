public abstract class Account {
    private string _name;
    private string _address;
    private double _balance;
    private List<Vehicle> _vehiclesRented;

    public Account(string name, string address, double balance){
        _name = name;      
        _address = address;
        _balance = balance;
    }

    public string GetName(){
        return _name;
    }

    public string GetAddress(){
        return _address;
    }

    public double GetBalance(){
        return _balance;
    }

    public List<Vehicle> GetVehiclesRented(){
        return _vehiclesRented;
    }

    public void SetAddress(string address){
        _address=address;
    }

    public void SetName(string name){
        _name=name;
    }

    public void SetBalance(double balance){
        _balance=balance;
    }

    public void SetVehiclesRented(List<Vehicle> vehiclesList){
        _vehiclesRented = vehiclesList;
    }

    public abstract string displayAccount();
}