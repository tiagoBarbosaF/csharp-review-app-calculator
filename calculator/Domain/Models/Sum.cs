using calculator.Domain.Interfaces;

namespace calculator.Domain.Models;

public class Sum : IFunctions
{
    public decimal Calculate(decimal num1, decimal num2) => decimal.Add(num1, num2);
}