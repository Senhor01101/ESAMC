public class Fantasmas
{
    public string Habilidade;
    public string Nick;
    public string Cor;

    public void GerarFantasma()
    {
        Console.WriteLine($"Nick: {Nick}, Habilidade: {Habilidade}, Cor: {Cor}");
    }

    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para {direcao}");
    }
}

public class Program
{
    public static void Main()
    {
        Fantasmas fantasma1 = new Fantasmas();
        fantasma1.Nick = "Sombra";
        fantasma1.Habilidade = "Invisibilidade";
        fantasma1.Cor = "Cinza";
        fantasma1.GerarFantasma();
        fantasma1.Mover("direita");

        Fantasmas fantasma2 = new Fantasmas();
        fantasma2.Nick = "Fantasminha";
        fantasma2.Habilidade = "Passar através de paredes";
        fantasma2.Cor = "Branco";
        fantasma2.GerarFantasma();
        fantasma2.Mover("esquerda");
    }
}
