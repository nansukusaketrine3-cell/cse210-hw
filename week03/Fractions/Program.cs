using System;

class Program
{
    static void Main(string[] args)
    {
        // Using the default constructor
        Fraction fraction1 = new Fraction();

        // Using the one-parameter constructor
        Fraction fraction2 = new Fraction(6);

        // Using the two-parameter constructor
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine("Fractions created using constructors:");
        Console.WriteLine($"{fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
        Console.WriteLine($"{fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");
        Console.WriteLine($"{fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        Console.WriteLine();

        // Testing getters and setters
        fraction1.SetTop(3);
        fraction1.SetBottom(4);

        Console.WriteLine("After using setters:");
        Console.WriteLine($"Top: {fraction1.GetTop()}");
        Console.WriteLine($"Bottom: {fraction1.GetBottom()}");
        Console.WriteLine($"Fraction: {fraction1.GetFractionString()}");
        Console.WriteLine($"Decimal: {fraction1.GetDecimalValue()}");

        Console.WriteLine();

        // More examples
        Fraction fraction4 = new Fraction(1);
        Fraction fraction5 = new Fraction(5);
        Fraction fraction6 = new Fraction(3, 4);
        Fraction fraction7 = new Fraction(1, 3);

        Console.WriteLine("Additional Examples:");
        Console.WriteLine($"{fraction4.GetFractionString()} = {fraction4.GetDecimalValue()}");
        Console.WriteLine($"{fraction5.GetFractionString()} = {fraction5.GetDecimalValue()}");
        Console.WriteLine($"{fraction6.GetFractionString()} = {fraction6.GetDecimalValue()}");
        Console.WriteLine($"{fraction7.GetFractionString()} = {fraction7.GetDecimalValue()}");
    }
}