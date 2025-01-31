public class BankAccount {
  public string accountName;
  public string accountNo;
  public double balance;

  public double Withdraw(double amount){
    if (balance >= amount){
      balance -= amount;
      return amount;
    }
    return 0;
  }

  public void Deposit(double amount){
    balance += amount;
  }

  public void Transfer(BankAccount account, double amount){
    double withdrawnAmount = Withdraw(amount);
    if (withdrawnAmount != 0){
      account.Deposit(withdrawnAmount);
    }
  }
}