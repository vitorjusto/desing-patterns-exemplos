using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateMethod.NaoIdeal;

namespace TemplateMethod.Ideal
{
    public class ImpressaoNormal : ImprimirRelatorioBase
    {
        public ImpressaoNormal(string nomeEmpresa, List<Produto> produto) : base(nomeEmpresa, produto)
        {
        }

        protected override string ObterProdutos()
        {
            var builder = new StringBuilder();

            foreach (var produto in Produtos)
            {
                builder.AppendLine($"{produto.Id}       {produto.NomeProduto}                  {produto.Quantidade}           {produto.ValorBruto:n2}                {produto.ValorDesconto:n2}              {produto.ValorLiquido:n2}");
            }

            return builder.ToString();
        }

        protected override string ObterTitulo()
        {
            return "Relatório de Produtos";
        }

        protected override string ObterTotalizadores()
        {
            var texto = new StringBuilder();

            texto.AppendLine($"Quantidade Total: {Produtos.Sum((x) => x.Quantidade)}");
            texto.AppendLine($"Total Bruto: {Produtos.Sum((x) => x.ValorBruto)}");
            texto.AppendLine($"Total Desconto: {Produtos.Sum((x) => x.ValorDesconto)}");
            texto.AppendLine($"Total Liquido: {Produtos.Sum((x) => x.ValorLiquido)}");

            return texto.ToString();
        }

        protected override string ObterCabecalho()
        {
            return "ID    Nome Produto       Quantidade    Valor Bruto      Valor Desconto     Valor Liquido";
        }
    }
}
