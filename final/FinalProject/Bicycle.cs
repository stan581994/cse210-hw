public class Bicycle : Vehicle
{
    public Bicycle(string model, string brand, double rentPrice,bool isAvailable,string uuid) : base(brand, model, rentPrice,isAvailable,uuid)
    {
    }


    public override string DisplayVehicle()
    {
        return $"BICYCLE - {GetBrand()}; {GetModel()}; Price = ${GetRentPrice()}";
    }
}
