using calculator.Domain.Interfaces;
using calculator.Domain.Models;

namespace calculator.Domain.Main;

public class Main
{
    private static IFunctions _functions;

    public static void Start()
    {
        var menuBorder = new string('*', 20);

        while (true)
        {
            Menu(menuBorder);
            Console.Write("\nEnter the function: ");
            var option = Console.ReadLine();

            if (option!.Equals("0"))
                break;


            switch (option)
            {
                case "1":
                    var num1 = Values(out var num2);
                    Console.WriteLine("\n" + Sum(num1, num2));
                    break;
                case "2":
                    num1 = Values(out num2);
                    Console.WriteLine("\n" + Subtract(num1, num2));
                    break;
                case "3":
                    num1 = Values(out num2);
                    Console.WriteLine("\n" + Multiply(num1, num2));
                    break;
                case "4":
                    num1 = Values(out num2);
                    Console.WriteLine("\n" + Divide(num1, num2));
                    break;
                case "5":
                    num1 = Values(out num2);
                    Console.WriteLine("\n" + Percentage(num1, num2));
                    break;
                default:
                    Console.WriteLine("Invalid option...");
                    break;
            }
        }
    }


    private static decimal Sum(decimal num1, decimal num2)
    {
        _functions = new Sum();
        return _functions.Calculate(num1, num2);
    }

    private static decimal Subtract(decimal num1, decimal num2)
    {
        _functions = new Subtract();
        return _functions.Calculate(num1, num2);
    }

    private static decimal Multiply(decimal num1, decimal num2)
    {
        _functions = new Multiply();
        return _functions.Calculate(num1, num2);
    }

    private static decimal Divide(decimal num1, decimal num2)
    {
        _functions = new Divide();
        return _functions.Calculate(num1, num2);
    }

    private static decimal Percentage(decimal num1, decimal num2)
    {
        _functions = new Percentage();
        return _functions.Calculate(num1, num2);
    }

    private static void Menu(string menuBorder)
    {
        Console.WriteLine();
        Console.WriteLine(menuBorder);
        Console.WriteLine("== Calculator ==");
        Console.WriteLine(" 1 - Sum");
        Console.WriteLine(" 2 - Subtract");
        Console.WriteLine(" 3 - Multiply");
        Console.WriteLine(" 4 - Divide");
        Console.WriteLine(" 5 - Percentage");
        Console.WriteLine(" 0 - Exit");
        Console.WriteLine(menuBorder);
    }

    private static decimal Values(out decimal num2)
    {
        Console.Write("\nEnter the first number: ");
        var num1 = decimal.Parse(Console.ReadLine()!);
        Console.Write("Enter the second number: ");
        num2 = decimal.Parse(Console.ReadLine()!);
        return num1;
    }
}