public abstract class Vehicle
{
    private string _brand;
    private string _model;
    private double _rentPrice;
    private bool _isAvailable;

    public Vehicle(string brand, string model, double rentPrice, bool isAvailable)
    {
        _brand = brand;
        _model = model;
        _rentPrice = rentPrice;
        _isAvailable = isAvailable;
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

    public abstract void ComputePrice();

    public virtual string DisplayVehicle()
    {
        return $"Vehicle - {_brand}; {_model}; Price = {_rentPrice}";
    }

    
}
