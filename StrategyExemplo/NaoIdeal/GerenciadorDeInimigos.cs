using System.Collections.Generic;
using System.Threading;

namespace StrategyExemplo.NaoIdeal
{
    public class GerenciadorDeInimigos
    {
        public GerenciadorDeInimigos()
        {
            _inimigos = new List<Inimigo>();
        }

        private List<Inimigo> _inimigos { get; set; }

        public void AdicionarInimigo(Inimigo inimigo)
        {
            _inimigos.Add(inimigo);
        }

        public void ProcessarInimigos()
        {
            foreach (var inimigo in _inimigos)
            {
                inimigo.ProcessarInimigo();

                Thread.Sleep(1000);
            }
        }
    }
}
