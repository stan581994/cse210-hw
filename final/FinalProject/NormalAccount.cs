public class NormalAccount:Account{
    public NormalAccount(string name,string address, double balance) : base(name,address,balance) { }
    
     public override string displayAccount(){
        return $"{GetName()} - {GetAddress()}; Balance = {GetBalance()}";
     }
}