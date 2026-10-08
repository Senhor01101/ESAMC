public class ContaBancaria
{
    public string Titular;
    public int NumeroConta;
    public decimal Saldo;

    public void Depositar(decimal valor)
    {
        if(valor <= 0)
        {
            Console.WriteLine("Não é possível realizar o depósito. O valor deve ser maior que zero.");
        }
        else
        {
            Saldo += valor;
            Console.WriteLine($"Depósito realizado com sucesso. Novo saldo: {Saldo:C}");
        }
    }

    public void Sacar(decimal valor)
    {
        if(Saldo == 0)
        {
            Console.WriteLine("Não é possível realizar o saque. A conta está sem Saldo.");
        }else if(Saldo < valor)
        {
            Console.WriteLine("Não é possível realizar o saque. Saldo insuficiente.");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {Saldo:C}");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: {Saldo:C}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria();
        conta1.Titular = "João Silva";
        conta1.NumeroConta = 12345;
        conta1.Saldo = 0m;
        conta1.Depositar(-90);
        conta1.Sacar(200m);
        conta1.Depositar(1500m);
        conta1.Sacar(500m);
        conta1.ExibirSaldo();

        ContaBancaria conta2 = new ContaBancaria();
        conta2.Titular = "Maria Souza";
        conta2.NumeroConta = 67890;
        conta2.Saldo = 2000.00m;
        conta2.Depositar(0);
        conta2.Depositar(200m);
        conta2.Sacar(3000m);
        conta2.ExibirSaldo();
        conta2.Sacar(1000m);
        conta2.ExibirSaldo();
    }
}
