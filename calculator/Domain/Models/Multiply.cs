using calculator.Domain.Interfaces;

namespace calculator.Domain.Models;

public class Multiply : IFunctions
{
    public decimal Calculate(decimal num1, decimal num2) => decimal.Multiply(num1, num2);
}