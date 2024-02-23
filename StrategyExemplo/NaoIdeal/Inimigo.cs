using System;

namespace StrategyExemplo.NaoIdeal
{
    public class Inimigo
    {
        public Inimigo(TipoDeInimigo tipo)
        {
            _tipo = tipo;
        }

        private TipoDeInimigo _tipo { get; set; }

        //Todos os comportamentos dos inimigos estão na mesma classe
        public void ProcessarInimigo()
        {
            switch (_tipo)
            {
                case TipoDeInimigo.Normal:
                    Console.WriteLine("Processa inimigo Normal");
                    break;
                case TipoDeInimigo.Atirador:
                    Console.WriteLine("Processa inimigo Atirador");
                    break;
                case TipoDeInimigo.Bomba:
                    Console.WriteLine("Processa inimigo Bomba");
                    break;
                default:
                    break;
            }   
        }
    }
}
