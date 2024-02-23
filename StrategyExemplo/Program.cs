using StrategyExemplo.Ideal;
using StrategyExemplo.Ideal.Strategies;
using StrategyExemplo.NaoIdeal;
using System;
using System.Threading;

namespace StrategyExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploDeCodigoNaoIdeal();

            Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}");

            ExemploDeCodigoIdeal();
        }

        public static void ExemploDeCodigoNaoIdeal()
        {
            var gerenciadorInimigo = new GerenciadorDeInimigos();

            gerenciadorInimigo.AdicionarInimigo(new Inimigo(TipoDeInimigo.Normal));
            gerenciadorInimigo.AdicionarInimigo(new Inimigo(TipoDeInimigo.Atirador));
            gerenciadorInimigo.AdicionarInimigo(new Inimigo(TipoDeInimigo.Bomba));
            gerenciadorInimigo.AdicionarInimigo(new Inimigo(TipoDeInimigo.Bomba));
            gerenciadorInimigo.AdicionarInimigo(new Inimigo(TipoDeInimigo.Normal));

            gerenciadorInimigo.ProcessarInimigos();
        }

        public static void ExemploDeCodigoIdeal()
        {
            var gerenciadorInimigo = new GerenciadorInimigosStrategy();

            gerenciadorInimigo.AdicionarInimigo(new InimigoNormal());
            gerenciadorInimigo.AdicionarInimigo(new InimigoAtirador());
            gerenciadorInimigo.AdicionarInimigo(new InimigoBomba());
            gerenciadorInimigo.AdicionarInimigo(new InimigoBomba());
            gerenciadorInimigo.AdicionarInimigo(new InimigoNormal());

            gerenciadorInimigo.ProcessarInimigos();
        }
    }
}
