public class BankApp
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
        
        bank.OpenAccount("Albert", "00001");
        bank.OpenAccount("Nicola", "00002");
        
        var albertAccount = bank.customers[0].Account;
        Console.Write("Enter deposit: ");
        int deposit=Convert.ToInt32(Console.ReadLine());
        albertAccount.Deposit(deposit);

        Console.Write("Enter withdrew: ");
        int withdrew=Convert.ToInt32(Console.ReadLine());
        albertAccount.Withdraw(withdrew);
        
        var nicolaAccount = bank.customers[1].Account;
        bank.Transfer("ACC123", "ACC456", 200);

        Console.WriteLine($"Albert's Balance: {albertAccount.GetBalance()}");
        Console.WriteLine($"Nicola's Balance: {nicolaAccount.GetBalance()}");

        bank.CloseAccount("ACC456");
    }
}