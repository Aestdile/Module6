public class Bank
{
    public List<Customer> customers = new List<Customer>();

    public void OpenAccount(string customerName, string accountNumber)
    {
        var account = new BankAccount(accountNumber);
        var customer = new Customer(customerName, account);
        customers.Add(customer);
        Console.WriteLine($"Account opened for {customerName} with account number: {accountNumber}");
    }

    public void CloseAccount(string accountNumber)
    {
        var customer = customers.Find(c => c.Account.AccountNumber == accountNumber);
        if (customer != null)
        {
            customers.Remove(customer);
            Console.WriteLine($"Account {accountNumber} closed.");
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    public void Transfer(string fromAccountNumber, string toAccountNumber, decimal amount)
    {
        var fromAccount = customers.Find(c => c.Account.AccountNumber == fromAccountNumber)?.Account;
        var toAccount = customers.Find(c => c.Account.AccountNumber == toAccountNumber)?.Account;

        if (fromAccount != null && toAccount != null)
        {
            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);
            Console.WriteLine($"Transfered {amount} from {fromAccountNumber} to {toAccountNumber}");
        }
        else
        {
            Console.WriteLine("Transfer failed. One or both accounts not found.");
        }
    }

    
}