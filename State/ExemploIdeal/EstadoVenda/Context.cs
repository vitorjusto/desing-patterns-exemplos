using State.Domain.ViewModels;
using System.Windows.Forms;

namespace State.ExemploIdeal.EstadoVenda
{
    public class Context
    {
        //guarda o estado atual da venda
        private StateVenda _estado { get; set; }

        //No context, é possivel ter toda a informação da venda que seja acessivel em todas as telas de venda

        public VendaViewModel ViewModel { get; set; }
        private Control _controle { get; set; }

        public Context(Control controle)
        {
            _controle = controle;
            ViewModel = new VendaViewModel();
            //Atribui o primeiro estado da venda
            AtribuirEstadoAtual(new VendaProduto());

        }

        //Altera para o estado desejado, que é passado por parametro
        public void AtribuirEstadoAtual(StateVenda estado)
        {
            _estado = estado;
            _estado.AtribuirContexto(this);
            _estado.Carregar();

            _controle.Controls.Clear();
            _controle.Controls.Add(estado);
        }

        //Muda o estado atual para o proximo quando o usuario avançar a tela
        public void MudarEstado()
        {
            if (_estado.Validar())
                AtribuirEstadoAtual(_estado.ProximoState());
        }
    }
}