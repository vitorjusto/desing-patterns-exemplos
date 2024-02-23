using State.Domain.ViewModels;
using State.ExemploIdeal.EstadoVenda;
using System.Windows.Forms;

namespace State.ExemploIdeal
{
    public partial class VendaCliente : StateVenda
    {
        public VendaCliente()
        {
            InitializeComponent();
            cmdAvancarCliente.Click += Avancar;
            cmdVoltarCliente.Click += Voltar;
        }

        public override StateVenda ProximoState()
        {
            return new VendaFormaPagamento();
        }

        public override StateVenda StateAnterior()
        {
            return new VendaProduto();
        }

        public override bool Validar()
        {
            Contexto.ViewModel.Cliente = new ClienteViewModel(txtNomeCliente.Text, txtCpf.Text, txtEndereco.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text);
            if (!Contexto.ViewModel.Cliente.Validar())
            {
                MessageBox.Show(Contexto.ViewModel.Cliente.Mensagem);
                return false;
            }
            return true;
        }

        public override void Carregar()
        {
            if (Contexto.ViewModel.Cliente is null)
                return;

            txtNomeCliente.Text = Contexto.ViewModel.Cliente.NomeCliente;
            txtEndereco.Text = Contexto.ViewModel.Cliente.Endereco;
            txtCidade.Text = Contexto.ViewModel.Cliente.Cidade;
            txtBairro.Text = Contexto.ViewModel.Cliente.Bairro;
            txtCpf.Text = Contexto.ViewModel.Cliente.CPF;
            txtNumero.Text = Contexto.ViewModel.Cliente.Numero;
        }
    }
}
