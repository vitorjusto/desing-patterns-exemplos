using System;

namespace StrategyExemplo.Ideal.Strategies
{
    public class InimigoBomba : InimigoStrategy
    {
        public override void Processar()
        {
            Console.WriteLine("Processa inimigo Bomba");
        }
    }
}
