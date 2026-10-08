public class Produto
{
    private string Nome;
    private decimal Preco;

    public Produto(string Nome, decimal Preco)
    {
        this.Nome = Nome;

        if(Preco < 0)
        {
            Console.WriteLine("O preço não pode ser negativo. O preço será definido como 0.");
            this.Preco = 0;
        }
        else
        {
            this.Preco = Preco;
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Produto: {Nome}");
        Console.WriteLine($"Preço do Produto: {Preco:C}");
    }

    public void AlterarPreco(decimal novoPreco)
    {
        if(novoPreco < 0)
        {
            Console.WriteLine("O preço não pode ser negativo. O preço será mantido como está.");
        }
        else
        {
            Preco = novoPreco;
            Console.WriteLine($"Preço do produto alterado para: {Preco:C}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Produto p = new Produto("Celular", 1500);
        p.ExibirDetalhes();
        p.AlterarPreco(-200);
        p.AlterarPreco(1200);
        p.ExibirDetalhes();
    }
}
