class PaymentCard
{
    public double balance { get; private set; }

    public PaymentCard(double balance)
    {
        this.balance = balance;
    }

    public void AddMoney(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public bool TakeMoney(double amount)
    {
        if (amount > balance)
        {
            return false;
        }

        balance -= amount;
        return true;
    }
}