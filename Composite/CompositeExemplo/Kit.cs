using System.Collections.Generic;
using System.Linq;

namespace Composite.CompositeExemplo
{
    public class Kit : ProdutoKit
    {
        private List<ProdutoKit> _produtos { get; set; }
        private decimal _desconto { get; set; }
        public Kit(decimal desconto)
        {
            _produtos = new List<ProdutoKit>();
            _desconto = desconto;
        }

        public void AdicionarProdutoKit(ProdutoKit produtoKit)
        {
            _produtos.Add(produtoKit);
        }

        public override decimal ObterPreco()
        {
            return _produtos.Sum((x) => x.ObterPreco()) - _desconto;
        }
    }
}
