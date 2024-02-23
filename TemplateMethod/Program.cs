using System;
using System.Collections.Generic;
using System.Threading;
using TemplateMethod.Ideal;
using TemplateMethod.NaoIdeal;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExemploNaoIdeal();
            ExemploIdeal();
        }

        private static void ExemploNaoIdeal()
        {
            var produtos = new List<Produto>();
            produtos.Add(new Produto(id: 1, nomeProduto: "Produto1", quantidade: 2, valorBruto: 5, valorDesconto: 1, valorLiquido: 4, nomeFuncionario: "Funcionario Foda"));
            produtos.Add(new Produto(id: 2, nomeProduto: "Produto2", quantidade: 1, valorBruto: 7, valorDesconto: 2, valorLiquido: 5, nomeFuncionario: "Funcionario Bao "));
            produtos.Add(new Produto(id: 3, nomeProduto: "Produto3", quantidade: 6, valorBruto: 5, valorDesconto: 2, valorLiquido: 3, nomeFuncionario: "Funcionario Foda"));
            produtos.Add(new Produto(id: 4, nomeProduto: "Produto4", quantidade: 2, valorBruto: 5, valorDesconto: 1, valorLiquido: 4, nomeFuncionario: "Funcionario Foda"));

            var impressao = new ImprimirRelatorio(nomeEmpresa: "EMPRESA Ltda",
                                                  dataInicial: DateTime.Now,
                                                  dataFinal: DateTime.Now.AddMonths(1),
                                                  produtos);

            Console.WriteLine($"{impressao.ObterImpressao(TipoImpressao.Normal)}{Environment.NewLine}{Environment.NewLine}");
            Thread.Sleep(3000);
            Console.WriteLine($"{impressao.ObterImpressao(TipoImpressao.Resumido)}{Environment.NewLine}{Environment.NewLine}");
            Thread.Sleep(3000);
            Console.WriteLine($"{impressao.ObterImpressao(TipoImpressao.Detalhado)}{Environment.NewLine}{Environment.NewLine}");
            Thread.Sleep(3000);


        }

        private static void ExemploIdeal()
        {
            var produtos = new List<Produto>();
            produtos.Add(new Produto(id: 1, nomeProduto: "Produto1", quantidade: 2, valorBruto: 5, valorDesconto: 1, valorLiquido: 4, nomeFuncionario: "Funcionario Foda"));
            produtos.Add(new Produto(id: 2, nomeProduto: "Produto2", quantidade: 1, valorBruto: 7, valorDesconto: 2, valorLiquido: 5, nomeFuncionario: "Funcionario Bao "));
            produtos.Add(new Produto(id: 3, nomeProduto: "Produto3", quantidade: 6, valorBruto: 5, valorDesconto: 2, valorLiquido: 3, nomeFuncionario: "Funcionario Foda"));
            produtos.Add(new Produto(id: 4, nomeProduto: "Produto4", quantidade: 2, valorBruto: 5, valorDesconto: 1, valorLiquido: 4, nomeFuncionario: "Funcionario Foda"));

            ImprimirRelatorioBase impressao = new ImpressaoNormal("EMPRESA Ltda", produtos);
            Console.WriteLine(impressao.Imprimir() + Environment.NewLine + Environment.NewLine);
            Thread.Sleep(3000);

            impressao = new ImpressaoResumido("EMPRESA Ltda", produtos);
            Console.WriteLine(impressao.Imprimir() +  Environment.NewLine + Environment.NewLine);
            Thread.Sleep(3000);

            impressao = new ImpressaoDetalhado("EMPRESA Ltda", produtos, DateTime.Now, DateTime.Now.AddMonths(1));
            Console.WriteLine(impressao.Imprimir() + Environment.NewLine + Environment.NewLine);
            Thread.Sleep(3000);
        }
    }
}
