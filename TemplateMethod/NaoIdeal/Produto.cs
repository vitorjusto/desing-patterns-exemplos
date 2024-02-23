namespace TemplateMethod.NaoIdeal
{
    public class Produto
    {
        public Produto(int id, string nomeProduto, int quantidade, int valorBruto, int valorDesconto, int valorLiquido, string nomeFuncionario)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            ValorBruto = valorBruto;
            ValorDesconto = valorDesconto;
            ValorLiquido = valorLiquido;
            NomeFuncionario = nomeFuncionario;
        }

        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public int ValorBruto { get; set; }
        public int ValorDesconto { get; set; }
        public int ValorLiquido { get; set; }
        public string NomeFuncionario { get; set; }
    }
}
