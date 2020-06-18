namespace Fixacao
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }
        public Cliente(string _nome){
            this.Nome = _nome;
        }
        public string MostrarDados(){

            string dados = $"Nome: {Nome}\nEndereço de entrega: {EnderecoAtual}";

            return dados;
        }
    }
}