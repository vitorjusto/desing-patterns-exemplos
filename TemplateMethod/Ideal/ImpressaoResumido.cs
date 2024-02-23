using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateMethod.NaoIdeal;

namespace TemplateMethod.Ideal
{
    public class ImpressaoResumido : ImprimirRelatorioBase
    {
        public ImpressaoResumido(string nomeEmpresa, List<Produto> produto) : base(nomeEmpresa, produto)
        {
        }

        protected override string ObterCabecalho()
        {
            return "ID    Nome Produto         Quantidade         Valor Liquido";
        }

        protected override string ObterProdutos()
        {
            var builder = new StringBuilder();

            foreach (var produto in Produtos)
            {
                builder.AppendLine($"{produto.Id}       {produto.NomeProduto}                    {produto.Quantidade}                 {produto.ValorLiquido:n2}");
            }

            return builder.ToString();
        }

        protected override string ObterTitulo()
        {
            return "Relatório de Produtos Resumido";
        }

        protected override string ObterTotalizadores()
        {
            return $"\nTotal: {Produtos.Sum((x) => x.ValorLiquido)}";
        }
    }
}
