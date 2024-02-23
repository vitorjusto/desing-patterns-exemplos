using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.NaoIdeal;

namespace TemplateMethod.Ideal
{
    public abstract class ImprimirRelatorioBase
    {
        public string NomeEmpresa { get; set; }
        public List<Produto> Produtos { get; set; }

        protected ImprimirRelatorioBase(string nomeEmpresa, List<Produto> produto)
        {
            NomeEmpresa = nomeEmpresa;
            Produtos = produto;
        }

        //O relatorio base apenas tem os texto que todos os relatorios tenham
        public string Imprimir()
        {
            var texto = new StringBuilder();

            texto.AppendLine(ObterTitulo());

            texto.AppendLine($"\nEmpresa: {NomeEmpresa}");

            texto.Append(ObterTextoOpcional());

            texto.AppendLine("-----------------------------------------------------------------------------------------");

            texto.AppendLine(ObterCabecalho());

            texto.AppendLine("-----------------------------------------------------------------------------------------");

            texto.AppendLine(ObterProdutos());

            texto.AppendLine("-----------------------------------------------------------------------------------------");

            texto.AppendLine(ObterTotalizadores());

            texto.AppendLine("-----------------------------------------------------------------------------------------");
            texto.AppendLine($"Empresa: {NomeEmpresa}");
            texto.AppendLine($"Data: {DateTime.Now:dd/MM/yyyy}");

            return texto.ToString();

        }

        //Metodos que serão herdadas a partir dessa classe, assim cada classe herdada tera o seu texto customizado
        protected abstract string ObterTitulo();
        protected abstract string ObterCabecalho();
        protected abstract string ObterProdutos();
        protected abstract string ObterTotalizadores();

        //Metodo com texto opcional na impressao, podem ser usados com virtual
        protected virtual string ObterTextoOpcional() { return ""; }
    }
}
