public class CreditCard {
  public const double maxLimit = 500000;
  public const double DailyLimit = 100000;
  public const double perTransactionLimit = 20000;

  public string cardHolderName;
  public double totalWithdrawn = 0;
  public double dailyTotalTransaction = 0;
  public DateTime lastTransactionTime = DateTime.Today;

  // Need to call this method before every transaction
  public void ResetDailyLimitIfNeeded(){
    if (lastTransactionTime.Date < DateTime.Today){
      dailyTotalTransaction = 0;
      lastTransactionTime = DateTime.Today;
    }
  }

  // Withdraw method where we are checking for the daily limit, per transaction limit and max limit
  public double Withdraw(double amount){
    ResetDailyLimitIfNeeded();

    if(amount > perTransactionLimit){
      Console.WriteLine("Transaction failed: Amount exceeds per transaction limit. Try again with amount less than " + perTransactionLimit);
      return 0;
    }

    if(amount+dailyTotalTransaction > DailyLimit){
      Console.WriteLine("Transaction failed: Daily limit exceeded. Try again tomorrow.");
      return 0;
    }

    if(amount+totalWithdrawn > maxLimit){
      Console.WriteLine("Transaction failed: Maximum Card limit exceeded.");
      return 0;
    }
    dailyTotalTransaction += amount;
    totalWithdrawn += amount;
    return amount;
  }

  public double BillPayment(double amount){
    if(amount+totalWithdrawn > maxLimit){
      Console.WriteLine("Maximum Limit of the card is exceeded. You can spend " + (maxLimit-totalWithdrawn) + " only before you pay your bill");
      return 0;
    }

    totalWithdrawn += amount;
    return amount;
  }

  public double GetCardAvailableLimit(){
    return maxLimit - totalWithdrawn;
  }
}