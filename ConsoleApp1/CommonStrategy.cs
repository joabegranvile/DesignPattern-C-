
namespace ConsoleApp1.CommonStrategy;

public static class CommonStrategy
{

  public interface IStrategy
  {
    void Pay(int amount);
  }
  public class PaymentProcessor
  {
    private readonly IStrategy _strategy;

    public PaymentProcessor(IStrategy strategy)
    {
      _strategy = strategy ?? throw new InvalidOperationException("Strategy cannot be null");
    }
    
    public void ProcessPayment(int amount)
    {
      _strategy.Pay(amount);
    }

    public class CreditCard : IStrategy
    {
      public void Pay(int amount)
      {
        Console.WriteLine($"Processing credit card payment of {amount}.");
      }
    }

    public class Pix : IStrategy
    {
      public void Pay(int amount)
      {
        Console.WriteLine($"Processing Pix payment of {amount}.");
      }
    }

    public class Boleto : IStrategy
    {
      public void Pay(int amount)
      {
        Console.WriteLine($"Processing boleto payment of {amount}.");
      }
    }
  }
}