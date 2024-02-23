using System.Collections.Generic;

namespace State.Domain.ViewModels
{
    public class VendaViewModel
    {
        public List<ProdutoViewModel> Produtos { get; set; }
        public ClienteViewModel Cliente { get; set; }

        public VendaViewModel()
        {
            Produtos = new List<ProdutoViewModel>();
        }
    }
}
