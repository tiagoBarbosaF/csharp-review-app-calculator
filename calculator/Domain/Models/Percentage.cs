using calculator.Domain.Interfaces;

namespace calculator.Domain.Models;

public class Percentage : IFunctions
{
    public decimal Calculate(decimal num1, decimal num2)
    {
        // return num1 * (num2 / 100);
        return decimal.Multiply(num2, decimal.Divide(num1, 100));
    }
}