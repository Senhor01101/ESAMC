public class Produto
{
    public string Nome;
    public decimal Preco;
    public int Quantidade;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome do produto: {Nome}");
        Console.WriteLine($"Preço do produto: {Preco:C}");
        Console.WriteLine($"Quantidade em estoque: {Quantidade}");
    }

    public decimal CalcularValorTotal()
    {
        decimal valor_total = Preco * Quantidade;
        return valor_total;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Produto produto1 = new Produto();
        produto1.Nome = "Camiseta";
        produto1.Preco = 29.99m;
        produto1.Quantidade = 10;
        produto1.ExibirDados();
        decimal valor_total1 = produto1.CalcularValorTotal();
        Console.WriteLine($"O valor total do produto {produto1.Nome} é: {valor_total1:C}");

        Produto produto2 = new Produto();
        produto2.Nome = "Calça";
        produto2.Preco = 79.99m;
        produto2.Quantidade = 5;
        produto2.ExibirDados();
        decimal valor_total2 = produto2.CalcularValorTotal();
        Console.WriteLine($"O valor total do produto {produto2.Nome} é: {valor_total2:C}");

        Produto produto3 = new Produto();
        produto3.Nome = "Tênis";
        produto3.Preco = 149.99m;
        produto3.Quantidade = 3;
        produto3.ExibirDados();
        decimal valor_total3 = produto3.CalcularValorTotal();
        Console.WriteLine($"O valor total do produto {produto3.Nome} é: {valor_total3:C}");
    
    }
}
