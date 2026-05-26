using System;

namespace CalculateProj;

class Program
{
    static void Main()
    {
        Console.WriteLine($"Add(3, 5) = {Calculate.Add(3, 5)}");
        Console.WriteLine($"Subtract(10, 4) = {Calculate.Subtract(10, 4)}");
        Console.WriteLine($"Multiply(6, 7) = {Calculate.Multiply(6, 7)}");
    }
}
