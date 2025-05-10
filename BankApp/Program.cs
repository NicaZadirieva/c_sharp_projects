new Account(150).withdraw(5);

// недостаточно средств
// new CreditAccount(0, 100).withdraw(5);
var currentTime = DateOnly.FromDateTime(DateTime.Now);

// AccountError: Запрещено снимать деньги до установленной даты: 11 мая 2025 г.
new SavingsAccount(100, currentTime.AddDays(1)).withdraw(5);
