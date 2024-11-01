public enum GeneroLivro
    {
        Ficcao = 1,
        NaoFiccao = 2, 
        Romance = 3,   
        Ciencia = 4,   
        Historia = 5, 
    };
public class PedidoLivro
{
    
    public GeneroLivro GeneroEscolhido{get; set;}

    public PedidoLivro(GeneroLivro generoEscolhido)
    {
        GeneroEscolhido = generoEscolhido;
    }

    public void ExibirPedido()
    {
        Console.WriteLine($"Você escolheu o genero{GeneroEscolhido}");
    }
}