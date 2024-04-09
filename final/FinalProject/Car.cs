using System.Runtime.CompilerServices;

public class Car : Vehicle{
    private double Mileage;


    public Car(string model, string brand, double rentPrice, double Mileage) : base(model,brand,rentPrice) {
        this.Mileage = Mileage;
    }
    public override void ComputePrice()
    {
        throw new NotImplementedException();
    }

    
    public override string DisplayVehicle(){
        return $"CAR - {GetBrand()}; {GetModel()}; Mileage = {Mileage}; Price = ${GetRentPrice()}";
    }

}