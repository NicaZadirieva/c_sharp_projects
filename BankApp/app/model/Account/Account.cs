class Account : IAccountActions
{
    private float amount;

    public Account(float amount)
    {
        this.amount = amount;
    }

    public void deposit(float amount)
    {
        this.amount += amount;
    }

    public void withdraw(float amount)
    {
        if (this.amount - amount < 0)
        {
            throw new AccountError("Недостаточно средств для списания платежа");
        }
        else
        {
            this.amount -= amount;
        }
    }
}
