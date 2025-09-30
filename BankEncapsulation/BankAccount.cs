namespace BankEncapsulation;

public class BankAccount
{
    //Fields
    private double _balance = 0;

    //Method to make a deposit
    public void Deposit(double amount)
    {
       _balance += amount;
    }
    
    //Method to get balance
    public double GetBalance()
    {
       return _balance;
    }
    
    //Constructor
    public BankAccount()
    {
    }
}