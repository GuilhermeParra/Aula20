using System;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente parra = new Cliente("Guilherme Parra"); 
            parra.EnderecoAtual = "Casa do Kralho";
            Console.WriteLine( parra.MostrarDados());

            Restaurante PapaPizza = new Restaurante("PapaPizza");
            PapaPizza.Endereco = "Favela do Muçuru, 223";
            Console.WriteLine(PapaPizza.MostrarDados());


            Pedido pedido = new Pedido();
            pedido.Cliente = parra.Nome;
            pedido.Restaurante = PapaPizza.Nome;
            Console.WriteLine(pedido.EntregarPedido());

            
            
            
        }
    }
}
// mas vai terminar ou nao