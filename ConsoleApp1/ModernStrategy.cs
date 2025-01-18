


using ConsoleApp1.IPayment;

public class PixPayment : IPayment
{
  public void Pay(int amount)
  {
    Console.WriteLine($"Processing Pix payment of {amount}.");
  }
}


public class BoletoPayment : IPayment
{
  public void Pay(int amount)
  {
    Console.WriteLine($"Processing boleto payment of {amount}.");
  }
}


public class CreditCardPayment : IPayment
{
  public void Pay(int amount)
  {
    Console.WriteLine($"Processing credit card payment of {amount}.");
  }
}