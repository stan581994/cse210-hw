public abstract class Vehicle
{
    private string _brand;
    private string _model;
    private double _rentPrice;
    private bool _isAvailable;

    private string _uuid;

    public Vehicle(string brand, string model, double rentPrice, bool isAvailable, string uuid)
    {
        _brand = brand;
        _model = model;
        _rentPrice = rentPrice;
        _isAvailable = isAvailable;
        _uuid = uuid;
    }

    public string Getuuid(){
        return _uuid;
    }

    public void Setuuid(string uuid){
        _uuid = uuid;
    }

    public string GetBrand()
    {
        return _brand;
    }

    public string GetModel()
    {
        return _model;
    }

    public double GetRentPrice()
    {
        return _rentPrice;
    }

    public bool GetIsAvailable(){
        return _isAvailable;
    }

    public void SetIsAvailable(bool isAvailable){
        _isAvailable = isAvailable;
    }

     public  double ComputePrice(){
        return _rentPrice;
     }

    public virtual string DisplayVehicle()
    {
        return $"Vehicle - {_brand}; {_model}; Price = {_rentPrice}";
    }

    
}
