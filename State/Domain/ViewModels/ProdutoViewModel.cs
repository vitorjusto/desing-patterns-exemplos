namespace State.Domain.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel(string nomeProduto, int quantidade, decimal preco)
        {
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            Preco = preco;
        }

        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
