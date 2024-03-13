using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.getFractionString());
        Console.WriteLine(fraction1.getDecimalValue().ToString("0.#############"));

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.getFractionString());
        Console.WriteLine(fraction2.getDecimalValue().ToString("0.#############"));

        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine(fraction3.getFractionString());
        Console.WriteLine(fraction3.getDecimalValue().ToString("0.#############"));

        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.getFractionString());
        Console.WriteLine(fraction4.getDecimalValue().ToString("0.#############"));
    }
}