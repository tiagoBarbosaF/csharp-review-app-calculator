using calculator.Domain.Interfaces;

namespace calculator.Domain.Models;

public class Subtract : IFunctions
{
    public decimal Calculate(decimal num1, decimal num2) => decimal.Subtract(num1, num2);
}