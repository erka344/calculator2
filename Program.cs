// See https://aka.ms/new-console-template for more information
//Console.WriteLine("first change");
using memory;
using calculator;
using operation;
using basicCalculator;

class Program
{
    static void Main()
    {
        BasicCalculator calculator = new BasicCalculator();
        Memory memory = new Memory();

        calculator.add(10);
        Console.WriteLine($"Result after adding 10: {calculator.result}");

        calculator.minus(5);
        Console.WriteLine($"Result after subtracting 5: {calculator.result}");

        memory.Store(calculator.result);
        Console.WriteLine($"Stored in memory: {memory.RecallLast()}");
    }
}
