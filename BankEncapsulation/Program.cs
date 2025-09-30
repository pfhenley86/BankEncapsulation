namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create bankAccount and deposit money and return the amount
            BankAccount bankAccount = new BankAccount();
            
            //Ask for deposit amount and convert to double if not null
            Console.WriteLine("How much would you like to deposit?");
            var input = Console.ReadLine();
            var deposit = double.Parse(input ?? string.Empty);
            
            //Submit deposit
            bankAccount.Deposit(deposit);
            
            //Return deposit to console
            Console.WriteLine(bankAccount.GetBalance());
        }
    }
}
