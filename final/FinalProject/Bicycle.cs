public class Bicycle : Vehicle
{
    public Bicycle(string model, string brand, double rentPrice,bool isAvailable) : base(brand, model, rentPrice,isAvailable)
    {
    }

    public override void ComputePrice()
    {
        throw new NotImplementedException();
    }

    public override string DisplayVehicle()
    {
        return $"BICYCLE - {GetBrand()}; {GetModel()}; Price = ${GetRentPrice()}";
    }
}
