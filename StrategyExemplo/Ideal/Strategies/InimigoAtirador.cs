using System;

namespace StrategyExemplo.Ideal.Strategies
{
    public class InimigoAtirador : InimigoStrategy
    {
        public override void Processar()
        {
            Console.WriteLine("Processa inimigo Atirador");
        }
    }
}
