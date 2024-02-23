using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateMethod.NaoIdeal;

namespace TemplateMethod.Ideal
{
    public class ImpressaoDetalhado : ImprimirRelatorioBase
    {
        public DateTime DataInicial { get; }
        public DateTime DataFinal { get; }

        public ImpressaoDetalhado(string nomeEmpresa, List<Produto> produto, DateTime dataInicial, DateTime dataFinal) : base(nomeEmpresa, produto)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }

        protected override string ObterCabecalho()
        {
            return "ID    Nome Funcionario      Nome Produto       Quantidade    Valor Bruto      Valor Desconto     Valor Liquido";
        }

        protected override string ObterProdutos()
        {
            var builder = new StringBuilder();

            foreach (var produto in Produtos)
            {
                    builder.AppendLine($"{produto.Id}       {produto.NomeFuncionario}        {produto.NomeProduto}                {produto.Quantidade}           {produto.ValorBruto:n2}                {produto.ValorDesconto:n2}              {produto.ValorLiquido:n2}");
            }

            return builder.ToString();
        }

        protected override string ObterTitulo()
        {
            return "Relatório de Produtos Detalhado";
        }

        protected override string ObterTotalizadores()
        {
            var texto = new StringBuilder();

            texto.AppendLine($"Quantidade Vendidos: {Produtos.Count()}");
            texto.AppendLine($"Quantidade Total: {Produtos.Sum((x) => x.Quantidade)}");
            texto.AppendLine($"Total Bruto: {Produtos.Sum((x) => x.ValorBruto)}");
            texto.AppendLine($"Total Desconto: {Produtos.Sum((x) => x.ValorDesconto)}");
            texto.AppendLine($"Total Liquido: {Produtos.Sum((x) => x.ValorLiquido)}");

            return texto.ToString();
        }

        //Metodo opcional implementada
        protected override string ObterTextoOpcional()
        {
            return $"Periodo: {DataInicial} - {DataFinal}\n";
        }
    }
}
