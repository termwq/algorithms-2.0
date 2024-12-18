using System;

public class Change
{
    public static void Main(string[] args)
    {
        Console.Write("a=");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b=");
        int b = Convert.ToInt32(Console.ReadLine());
        a = a+b;
        b = a-b;
        a = a-b;
        Console.WriteLine($"a={a}, b={b}");
    }
}