using System.Globalization;
using calculator.Domain.Interfaces;
using calculator.Domain.Models;
using Xunit.Abstractions;

namespace testCalculator;

public class CalculatorApplicationTests
{
    private ITestOutputHelper _outputHelper;

    private static IFunctions _functions;

    public CalculatorApplicationTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact(DisplayName = "Test - sum calculate")]
    [Trait("Category", "Unit")]
    public void TestSum()
    {
        _functions = new Sum();
        var sum = _functions.Calculate(10, 10);

        _outputHelper.WriteLine(sum.ToString(CultureInfo.InvariantCulture));
        Assert.Equal(20, sum);
    }

    [Fact(DisplayName = "Test - subtract calculate")]
    [Trait("Category", "Unit")]
    public void TestSubtract()
    {
        _functions = new Subtract();
        var subtract = _functions.Calculate(15, 10);

        Assert.Equal(5, subtract);
    }

    [Fact(DisplayName = "Test - multiply calculate")]
    [Trait("Category", "Unit")]
    public void TestMultiply()
    {
        _functions = new Multiply();
        var multiply = _functions.Calculate(3, 5);

        Assert.Equal(15, multiply);
    }

    [Fact(DisplayName = "Test - divide calculate")]
    [Trait("Category", "Unit")]
    public void TestDivide()
    {
        _functions = new Divide();
        var divide = _functions.Calculate(12, 4);

        Assert.Equal(3, divide);
    }

    [Fact(DisplayName = "Test - divide by zero calculate")]
    [Trait("Category", "Unit")]
    public void TestDivideByZero()
    {
        _functions = new Divide();
        var exception = _functions.Calculate(4, 0);

        Assert.Equal(0, exception);
    }

    [Fact(DisplayName = "Test - percentage calculate")]
    public void TestPercentage()
    {
        _functions = new Percentage();
        var percentage = _functions.Calculate(60, 20);

        Assert.Equal(12, percentage);
    }
}