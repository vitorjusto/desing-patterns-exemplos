using State.Domain.ViewModels;
using State.ExemploIdeal.EstadoVenda;
using System;
using System.Windows.Forms;

namespace State.ExemploIdeal
{
    public partial class VendaProduto : StateVenda
    {
        public VendaProduto()
        {
            InitializeComponent();
            cmdVendaAvancar.Click += Avancar; 
        }

        public override StateVenda ProximoState()
        {
            return new VendaCliente();
        }

        public override bool Validar()
        {
            if (Contexto.ViewModel.Produtos.Count == 0)
            {
                MessageBox.Show("É necessario informar um produto");
                return false;
            }

            return true;
        }

        private void cmdAdicionarProduto_Click(object sender, System.EventArgs e)
        {
            Contexto.ViewModel.Produtos.Add(new ProdutoViewModel(txtNomeProduto.Text, Convert.ToInt32(txtQuantidade.Text), Convert.ToDecimal(txtPreco.Text)));
            grdProdutos.Rows.Add(txtNomeProduto.Text, txtQuantidade.Text, txtPreco.Text);

            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
        }

        public override void Carregar()
        {

            foreach (var produto in Contexto.ViewModel.Produtos)
            {
                grdProdutos.Rows.Add(produto.NomeProduto, produto.Quantidade, produto.Preco);
            }

        }
    }
}
