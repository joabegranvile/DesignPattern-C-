// See https://aka.ms/new-console-template for more information
using System;
using ConsoleApp1.PaymentMethotType;
using static ConsoleApp1.CommonStrategy.CommonStrategy;
using static ConsoleApp1.CommonStrategy.CommonStrategy.PaymentProcessor;
public class Program
{
  static void Main(string[] args)
  {
    var paymentMethod = PaymentMethodType.Boleto;
    var amount = 100;

    var strategy = PaymentFactory.GetPayment(paymentMethod);

    strategy.Pay(amount);
  }
}

