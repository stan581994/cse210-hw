using System.Runtime.CompilerServices;

public class Car : Vehicle{
    private double _mileage;


    public Car(string model, string brand, double rentPrice, double Mileage) : base(model,brand,rentPrice) {
        this._mileage = Mileage;
    }
    public override void ComputePrice()
    {
        throw new NotImplementedException();
    }

    public double GetMileage(){
        return _mileage;
    }

    
    public override string DisplayVehicle(){
        return $"CAR - {GetBrand()}; {GetModel()}; Mileage = {_mileage}; Price = ${GetRentPrice()}";
    }

}