namespace BankEncapsulation;

public class BankAccount
{
    //Fields
    private double _balance = 0;

    //Method to make a deposit
    public double Deposit(double amount)
    {
       return _balance += amount;
    }
    
    //Method to get balance
    public void GetBalance()
    {
        Console.WriteLine($"Your Balance Is: {_balance}");
    }
    
    //Constructor
    public BankAccount()
    {
    }
}