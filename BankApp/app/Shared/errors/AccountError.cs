// Класс ошибки при недостатке средств
class AccountError : ApplicationException
{
    public AccountError(string? message)
        : base(message) { }
}
