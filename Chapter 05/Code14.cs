public class BankAccount
{
    private double balance;
    public double Balance
    {
        get
        {
            return balance;
        }

        private set
        {
            if (value >= 0)
                balance = value;
        }
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
            Balance -= amount;
        else
            throw new InvalidOperationException("Insufficient funds.");
    }
}