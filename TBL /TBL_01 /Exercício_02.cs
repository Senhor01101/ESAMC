using System;

class Pessoa
{
    public string Nome;
}

class Program
{
    static void Main()
    {
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "João";

        Pessoa pessoa2 = pessoa1;

        pessoa2.Nome = "Carlos";

        Console.WriteLine("Nome da pessoa1: " + pessoa1.Nome);
    }
}
