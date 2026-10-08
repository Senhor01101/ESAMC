public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e trabalho como {Cargo}.");
    }

    public void Apresentar_Salario()
    {
        if(Cargo == "Estagiário")
        {
            Console.WriteLine($"O salário do {Cargo} é de R$ 100,00.");
        }else if(Cargo == "Gerente")
        {
            Console.WriteLine($"O salário do {Cargo} é de R$ 10.000,00.");
        }else if(Cargo == "Desenvolvedor")
        {
            Console.WriteLine($"O salário do {Cargo} é de R$ 5.000,00.");
        }
    }
}

public class Program {
    public static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "João";
        p1.Idade = 30;
        p1.Cargo = "Estagiário";
        p1.Apresentar();
        p1.Apresentar_Salario();

        Pessoa p2 = new Pessoa();
        p2.Nome = "Ingrid";
        p2.Idade = 25;
        p2.Cargo = "Gerente";
        p2.Apresentar();
        p2.Apresentar_Salario();

        Pessoa p3 = new Pessoa();
        p3.Nome = "Tatiana";
        p3.Idade = 20;
        p3.Cargo = "Estagiário";
        p3.Apresentar();
        p3.Apresentar_Salario();

        Pessoa p4 = new Pessoa();
        p4.Nome = "Lucas";
        p4.Idade = 28;
        p4.Cargo = "Desenvolvedor";
        p4.Apresentar();
        p4.Apresentar_Salario();

    }

}
