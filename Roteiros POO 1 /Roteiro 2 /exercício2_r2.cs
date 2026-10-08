public class Carro
{
    private string Modelo;
    private int VelocidadeAtual;

    public Carro(string Modelo)
    {
        this.Modelo = Modelo;
        VelocidadeAtual = 0;
    }

    public void Acelerar(int valor)
    {
        if (valor < 0)
        {
            Console.WriteLine("Erro: Valor de aceleração não pode ser negativo.");
        }
        else
        {
            VelocidadeAtual += valor;
            Console.WriteLine($"O carro {Modelo} acelerou para {VelocidadeAtual} km/h.");
        }
    }

    public void Frear(int valor)
    {
        if (valor < 0)
        {
            Console.WriteLine("Erro: Valor de frenagem não pode ser negativo.");
            
        }
        else
        {
            VelocidadeAtual -= valor;
            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
            Console.WriteLine($"O carro {Modelo} desacelerou para {VelocidadeAtual} km/h.");
        }
    }

    public void ExibirVelocidade()
    {
        Console.WriteLine($"A velocidade atual é {VelocidadeAtual} km/h.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Carro c = new Carro("Ferrari");
        c.Acelerar(50);
        c.ExibirVelocidade();
        c.Frear(30);
        c.ExibirVelocidade();
        c.Frear(50);
        c.ExibirVelocidade();
    }
}
