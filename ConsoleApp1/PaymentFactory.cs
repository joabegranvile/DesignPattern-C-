using ConsoleApp1.IPayment;
using ConsoleApp1.PaymentMethotType;

public static class PaymentFactory
{
  private static readonly Dictionary<PaymentMethodType, IPayment> Payments = new()
  {
    { PaymentMethodType.Boleto, new BoletoPayment() },
    { PaymentMethodType.CreditCard, new CreditCardPayment() },
    { PaymentMethodType.Pix, new PixPayment() }
  };

  public static IPayment GetPayment(PaymentMethodType paymentMethodType)
  {
    if (!Payments.TryGetValue(paymentMethodType, out IPayment? value))
    {
      throw new InvalidOperationException("Invalid payment method type");
    }
    return value;
  }
}