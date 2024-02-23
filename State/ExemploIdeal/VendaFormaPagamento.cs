using State.Domain.ViewModels;
using State.ExemploIdeal.EstadoVenda;
using System.Windows.Forms;

namespace State.ExemploIdeal
{
    public partial class VendaFormaPagamento : StateVenda
    {
        public VendaFormaPagamento()
        {
            InitializeComponent();
            cmdFinalizar.Click += Avancar;
            cmdPagamentoVoltar.Click += Voltar;
        }

        public override StateVenda ProximoState()
        {
            return new VendaProduto();
        }

        public override StateVenda StateAnterior()
        {
            return new VendaCliente();
        }

        public override bool Validar()
        {
            MessageBox.Show("Venda finalizada!!!");
            Contexto.ViewModel = new VendaViewModel();
            return true;
        }
    }
}
