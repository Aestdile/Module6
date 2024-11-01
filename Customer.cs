public class Customer
{
    public string Name { get; private set; }
    public BankAccount Account { get; private set; }

    public Customer(string name, BankAccount account)
    {
        Name = name;
        Account = account;
    }
}