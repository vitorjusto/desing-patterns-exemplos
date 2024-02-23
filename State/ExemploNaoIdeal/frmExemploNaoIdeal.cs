using State.Domain.ViewModels;
using System;
using System.Windows.Forms;

namespace State.ExemploNaoIdeal
{
    public partial class frmExemploNaoIdeal : Form
    {
        public VendaViewModel Venda { get; set; }
        public frmExemploNaoIdeal()
        {
            InitializeComponent();
            Venda = new VendaViewModel();

            pnCliente.Visible = false;
            pnFormaPagamento.Visible = false;
        }

        //Regras da tela de venda
        private void cmdProdutoAvancar_Click(object sender, System.EventArgs e)
        {
            if(Venda.Produtos.Count == 0)
            {
                MessageBox.Show("É necessario informar um produto");
                return;
            }

            pnProdutos.Visible = false;
            pnCliente.Visible = true;

        }

        private void cmdAdicionarProduto_Click(object sender, System.EventArgs e)
        {
            Venda.Produtos.Add(new ProdutoViewModel(txtNomeProduto.Text, Convert.ToInt32(txtQuantidade.Text), Convert.ToDecimal(txtPreco.Text)));
            grdProdutos.Rows.Add(txtNomeProduto.Text, txtQuantidade.Text, txtPreco.Text);

            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";


        }

        //Regras da tela do cliente
        private void cmdVoltarCliente_Click(object sender, EventArgs e)
        {
            pnProdutos.Visible = true;
            pnCliente.Visible = false;
        }

        private void cmdAvancarCliente_Click(object sender, EventArgs e)
        {
            Venda.Cliente = new ClienteViewModel(txtNomeCliente.Text, txtCpf.Text, txtEndereco.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text);

            if(!Venda.Cliente.Validar())
            {
                MessageBox.Show(Venda.Cliente.Mensagem);
                return;
            }

            pnFormaPagamento.Visible = true;
            pnCliente.Visible = false;
        }

        //Regra forma de pagamento
        private void cmdPagamentoVoltar_Click(object sender, EventArgs e)
        {
            pnFormaPagamento.Visible = false;
            pnCliente.Visible = true;
        }

        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda finalisada!!!");
            pnProdutos.Visible = true;
            pnFormaPagamento.Visible = false;

            grdProdutos.Rows.Clear();
        }
    }
}
