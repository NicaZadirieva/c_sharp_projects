class SavingsAccount : IAccountActions
{
    private float amount;
    private DateOnly expiredAt;

    public SavingsAccount(float amount, DateOnly expiredAt)
    {
        this.amount = amount;
        this.expiredAt = expiredAt;
    }

    public void deposit(float amount)
    {
        this.amount += amount;
    }

    public void withdraw(float amount)
    {
        if (new DateOnly().CompareTo(expiredAt) < 0)
        {
            throw new AccountError(
                "Запрещено снимать деньги до установленной даты: " + expiredAt.ToString()
            );
        }
        else if (this.amount - amount < 0)
        {
            throw new AccountError("Недостаточно средств для списания платежа");
        }
        else
        {
            this.amount -= amount;
        }
    }
}
