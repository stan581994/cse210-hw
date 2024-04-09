public class Motorcycle : Vehicle
{
    private double _mileage;

    public Motorcycle(string model, string brand, double rentPrice, double mileage) : base(brand, model, rentPrice)
    {
        _mileage = mileage;
    }

    public override void ComputePrice()
    {
        throw new NotImplementedException();
    }

        public override string DisplayVehicle(){
        return $"MOTORCYCLE - {GetBrand()}; {GetModel()}; Mileage = {_mileage}; Price = ${GetRentPrice()}";
    }

}
