
public class Car : Vehicle{
    private double _mileage;


    public Car(string model, string brand, double rentPrice, double Mileage,bool isAvailable,string uuid) : base(model,brand,rentPrice,isAvailable,uuid) {
        this._mileage = Mileage;
    }
    public double GetTotalPrice(double mileage, double discountRate)
    {
        double mileageConsumed = mileage - _mileage;
        double additionalFee = mileageConsumed * 0.084;
        double totalRpice = GetRentPrice() + additionalFee;
        double discountedPrice = totalRpice - (totalRpice * discountRate);
        return discountedPrice;
    }


    public double GetMileage(){
        return _mileage;
    }

    
    public override string DisplayVehicle(){
        return $"CAR - {GetBrand()}; {GetModel()}; Mileage = {_mileage}; Price = ${GetRentPrice()}";
    }

}