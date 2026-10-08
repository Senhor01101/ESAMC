class Conta
{
    public decimal Saldo { get; private set; }
    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do depósito deve ser positivo.");
        }
        Saldo += valor;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Conta conta = new Conta();
            //conta.Saldo = -999999
            conta.Depositar(500);
            Console.WriteLine(conta.Saldo);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
