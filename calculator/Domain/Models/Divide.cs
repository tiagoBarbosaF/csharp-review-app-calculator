using calculator.Domain.Interfaces;

namespace calculator.Domain.Models;

public class Divide : IFunctions
{
    public decimal Calculate(decimal num1, decimal num2)
    {
        try
        {
            return decimal.Divide(num1, num2);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            return decimal.Zero;
        }
    }
}