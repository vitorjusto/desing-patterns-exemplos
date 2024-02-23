using State.ExemploIdeal.EstadoVenda;
using System.Windows.Forms;

namespace State.ExemploIdeal
{
    public partial class frmExemploIdeal : Form
    {
        public frmExemploIdeal()
        {
            InitializeComponent();
            new Context(this);
        }
    }
}
