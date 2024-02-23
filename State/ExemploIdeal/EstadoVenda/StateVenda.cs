using System.Windows.Forms;

namespace State.ExemploIdeal.EstadoVenda
{
    public class StateVenda : UserControl
    {
        public Context Contexto { get; set; }
        public void AtribuirContexto(Context contexto)
        {
            Contexto = contexto;
        }

        public virtual bool Validar() => false;

        public virtual StateVenda ProximoState() { return null; }
        public virtual StateVenda StateAnterior() { return null; }
        public virtual void Carregar() { }

        public void Avancar(object sender, System.EventArgs e)
        {
           Contexto.MudarEstado();
        }

        public void Voltar(object sender, System.EventArgs e)
        {
            Contexto.AtribuirEstadoAtual(StateAnterior());
        }
    }
}
