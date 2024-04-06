public abstract class Vehicle
{

    private string _brand;
    private string _model;

    private double _rentPrice;

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



}