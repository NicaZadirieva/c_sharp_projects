using System.Reflection;

class CreditAccount : IAccountActions
{
    // денег на счету
    private float amount;

    // максимум за одно снятие
    private float maxValueAtWithdraw;

    public CreditAccount(float amount, float maxValueAtWithdraw)
    {
        this.amount = amount;
        this.maxValueAtWithdraw = maxValueAtWithdraw;
    }

    public void withdraw(float amount)
    {
        if (amount > this.maxValueAtWithdraw)
        {
            throw new AccountError("Превышено значение для списания");
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

    public void deposit(float amount)
    {
        this.amount += amount;
    }
}
