namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(100);
            bankAccount.GetBalance();
        }
    }
}
