Console.WriteLine("Hello, World!");

CreditCard creditCard1 = new CreditCard();
creditCard1.cardHolderName = "Mehedi Hasan";

creditCard1.BillPayment(50000);
Console.WriteLine(creditCard1.GetCardAvailableLimit());
