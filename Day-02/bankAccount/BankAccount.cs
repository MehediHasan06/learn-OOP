public class BankAccount {
  public string accountName;
  public string accountNo;
  public double balance;

  public void Deposit(double amount){
    balance += amount;
    return balance + " deposited successfully";
  }
  public double Withdraw(double amount){
    if (balance >= amount){
      balance -= amount;
      return amount + " withdrawn successfully";
    }
    return 0;
  }


  public void Transfer(BankAccount account, double amount){
    double withdrawnAmount = Withdraw(amount);
    if (withdrawnAmount != 0){
      account.Deposit(withdrawnAmount);
      return withdrawnAmount + " transferred successfully";
    }
  }
}