using System;

namespace Composite.CompositeExemplo
{
    public class Produto : ProdutoKit
    {
        public decimal Preco { get; set; }

        public Produto(decimal preco)
        {
            Preco = preco;
        }

        public override decimal ObterPreco()
        {
            return Preco;
        }
    }
}
