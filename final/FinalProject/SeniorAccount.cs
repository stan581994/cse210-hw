public class SeniorAccount : Account
{
  private double _discountRate;

  public SeniorAccount(string name, string address, double balance, double discountRate,string vehiclesRented) : base(name, address, balance,vehiclesRented)
  {
    _discountRate = discountRate;
  }

  public override string displayAccount()
  {
    return $"{GetName()} - {GetAddress()}; Balance = {GetBalance()}";
  }
  public double GetDiscountRate()
  {
    return _discountRate;
  }

}