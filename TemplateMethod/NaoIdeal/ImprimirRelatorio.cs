using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod.NaoIdeal
{
    public class ImprimirRelatorio
    {
        public ImprimirRelatorio(string nomeEmpresa, DateTime dataInicial, DateTime dataFinal, List<Produto> produtos)
        {
            NomeEmpresa = nomeEmpresa;
            DataInicial = dataInicial;
            DataFinal = dataFinal;
            Produtos = produtos;
        }

        public string NomeEmpresa { get; private set; }
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }
        public List<Produto> Produtos { get; set; }

        //Todas as impressão são feitas no mesmo metodo, fazendo um codigom muito bagunçado
        public string ObterImpressao(TipoImpressao tipoImpressao)
            {
                var texto = new StringBuilder();

                if (tipoImpressao == TipoImpressao.Normal)
                    texto.AppendLine("Relatório de Produtos");
                else if (tipoImpressao == TipoImpressao.Resumido)
                    texto.AppendLine("Relatório de Produtos Resumido");
                else if (tipoImpressao == TipoImpressao.Detalhado)
                    texto.AppendLine("Relatório de Produtos Detalhado");

                texto.AppendLine($"\nEmpresa: {NomeEmpresa}");

                if (tipoImpressao == TipoImpressao.Detalhado)
                    texto.AppendLine($"Periodo: {DataInicial:dd/MM/yyyy} - {DataFinal:dd/MM/yyyy}");

                //Alguns textos são padrão da impressão, portanto o idela não é separar o codigo para não ter o codigo duplicado
                texto.AppendLine("-----------------------------------------------------------------------------------------");

                if (tipoImpressao == TipoImpressao.Normal)
                    texto.AppendLine("ID    Nome Produto       Quantidade    Valor Bruto      Valor Desconto     Valor Liquido");
                else if (tipoImpressao == TipoImpressao.Resumido)
                    texto.AppendLine("ID    Nome Produto         Quantidade         Valor Liquido");
                else if (tipoImpressao == TipoImpressao.Detalhado)
                    texto.AppendLine("ID    Nome Funcionario      Nome Produto       Quantidade    Valor Bruto      Valor Desconto     Valor Liquido");

                texto.AppendLine("-----------------------------------------------------------------------------------------");

                texto.AppendLine(ObterProdutos(tipoImpressao));

                texto.AppendLine("-----------------------------------------------------------------------------------------");

                if (tipoImpressao == TipoImpressao.Normal)
                {
                    texto.AppendLine($"Quantidade Total: {Produtos.Sum((x) => x.Quantidade)}");
                    texto.AppendLine($"Total Bruto: {Produtos.Sum((x) => x.ValorBruto)}");
                    texto.AppendLine($"Total Desconto: {Produtos.Sum((x) => x.ValorDesconto)}");
                    texto.AppendLine($"Total Liquido: {Produtos.Sum((x) => x.ValorLiquido)}");
                }
                else if (tipoImpressao == TipoImpressao.Resumido)
                {
                    texto.AppendLine($"Total: {Produtos.Sum((x) => x.ValorLiquido)}");
                }
                else if (tipoImpressao == TipoImpressao.Detalhado)
                {
                    texto.AppendLine($"Quantidade Vendidos: {Produtos.Count()}");
                    texto.AppendLine($"Quantidade Total: {Produtos.Sum((x) => x.Quantidade)}");
                    texto.AppendLine($"Total Bruto: {Produtos.Sum((x) => x.ValorBruto)}");
                    texto.AppendLine($"Total Desconto: {Produtos.Sum((x) => x.ValorDesconto)}");
                    texto.AppendLine($"Total Liquido: {Produtos.Sum((x) => x.ValorLiquido)}");
                }

                texto.AppendLine("-----------------------------------------------------------------------------------------");
                texto.AppendLine($"Empresa: {NomeEmpresa}");
                texto.AppendLine($"Data: {DateTime.Now:dd/MM/yyyy}");

                return texto.ToString();
        }

        private string ObterProdutos(TipoImpressao tipoImpressao)
        {
            var builder = new StringBuilder();

            foreach (var produto in Produtos)
            {
                if (tipoImpressao == TipoImpressao.Normal)
                    builder.AppendLine($"{produto.Id}       {produto.NomeProduto}                  {produto.Quantidade}           {produto.ValorBruto:n2}                {produto.ValorDesconto:n2}              {produto.ValorLiquido:n2}");
                else if (tipoImpressao == TipoImpressao.Resumido)
                    builder.AppendLine($"{produto.Id}       {produto.NomeProduto}                    {produto.Quantidade}                 {produto.ValorLiquido:n2}");
                else if (tipoImpressao == TipoImpressao.Detalhado)
                    builder.AppendLine($"{produto.Id}       {produto.NomeFuncionario}        {produto.NomeProduto}                {produto.Quantidade}           {produto.ValorBruto:n2}                {produto.ValorDesconto:n2}              {produto.ValorLiquido:n2}");
            }

            return builder.ToString();

        }
    }
}
