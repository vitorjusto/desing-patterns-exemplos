using System.Collections.Generic;
using System.Threading;

namespace StrategyExemplo.Ideal
{
    public class GerenciadorInimigosStrategy
    {
        public GerenciadorInimigosStrategy()
        {
            _inimigos = new List<InimigoStrategy>();
        }
        private List<InimigoStrategy> _inimigos { get; set; }
        
        public void AdicionarInimigo(InimigoStrategy inimigo)
        {
            _inimigos.Add(inimigo);
        }

        //Para o gerenciador de inimigos, não importa o que inimigo faça, desde que ele processe
        public void ProcessarInimigos()
        {
            foreach (var inimigo in _inimigos)
            {
                inimigo.Processar();

                Thread.Sleep(1000);
            }
        }
    }
}
