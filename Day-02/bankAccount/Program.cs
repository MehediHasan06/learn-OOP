Console.WriteLine("Hello, World!");

BankAccount account1 = new BankAccount();
account1.accountName = "John";
account1.accountNo = "123";
account1.balance = 40000;

BankAccount account2 = new BankAccount();
account2.accountName = "Jane";
account2.accountNo = "456";
account2.balance = 50000;

account1.Transfer(account2, 10000);

Console.WriteLine(account1.accountName + " balance: " + account1.balance);
Console.WriteLine(account2.accountName + " balance: " + account2.balance);
