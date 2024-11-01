class Program
{
    public static void Main()
    {
        Console.WriteLine("Escolha um dos generos abaixo de livro que deseja");
        Console.WriteLine("");
        Console.WriteLine("Ficcao");
        Console.WriteLine("NaoFiccao");
        Console.WriteLine("Romance");
        Console.WriteLine("Cieancia");
        Console.WriteLine("Historia");
        
        string escolhaDoUsuario = Console.ReadLine();

        if (Enum.TryParse(escolhaDoUsuario, true, out GeneroLivro generoEscolhido))
        {
            PedidoLivro pedido = new PedidoLivro(generoEscolhido);
            pedido.ExibirPedido();
        }
        else
        {
            throw new GeneroInvalidoException("O gênero digitado não está disponivel");
        }
        
    }
}
