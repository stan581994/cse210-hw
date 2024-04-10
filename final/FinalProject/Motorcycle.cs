public class Motorcycle : Vehicle
{
    private double _mileage;

    public Motorcycle(string model, string brand, double rentPrice, double mileage, bool isAvailable, string uuid) : base(brand, model, rentPrice, isAvailable, uuid)
    {
        _mileage = mileage;
    }

    public double GetTotalPrice(double mileage, double discountRate)
    {
        double mileageConsumed =  mileage - _mileage;
        double additionalFee = mileageConsumed * 0.084;
        double totalRpice =GetRentPrice() + additionalFee;
        double discountedPrice = totalRpice - (totalRpice * discountRate);
        return discountedPrice;
    }


    public override string DisplayVehicle()
    {
        return $"MOTORCYCLE - {GetBrand()}; {GetModel()}; Mileage = {_mileage}; Price = ${GetRentPrice()}";
    }

    public double GetMileage()
    {
        return _mileage;
    }


}
