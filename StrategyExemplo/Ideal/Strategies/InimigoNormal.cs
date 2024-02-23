using System;

namespace StrategyExemplo.Ideal.Strategies
{
    public class InimigoNormal : InimigoStrategy
    {
        public override void Processar()
        {
            Console.WriteLine("Processa inimigo Normal");
        }
    }
}
