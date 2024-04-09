public abstract class Vehicle
{
    private string _brand;
    private string _model;
    private double _rentPrice;

    public Vehicle(string brand, string model, double rentPrice)
    {
        _brand = brand;
        _model = model;
        _rentPrice = rentPrice;
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

    public abstract void ComputePrice();

    public virtual string DisplayVehicle()
    {
        return $"Vehicle - {_brand}; {_model}; Price = {_rentPrice}";
    }

    
}
