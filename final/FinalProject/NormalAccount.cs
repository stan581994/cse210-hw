public class NormalAccount:Account{
    public NormalAccount(string name,string address, double balance, string vehiclesRented) : base(name,address,balance,vehiclesRented) { }
    
     public override string displayAccount(){
        return $"{GetName()} - {GetAddress()}; Balance = {GetBalance()}";
     }
}