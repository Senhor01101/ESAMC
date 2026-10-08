using System;

class Program
{
    static void Main()
    {
        int primeira = 10;
        int segunda = primeira;

        segunda = 20;

        Console.WriteLine("Valor da primeira variável: " + primeira);
        Console.WriteLine("Valor da segunda variável: " + segunda);
    }
}
