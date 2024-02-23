using System;

namespace Facade.ComprovanteServices
{
    public interface IEnviarComprovante
    {
        public void EnviarComprovante();
    }

    public class ImprimirComprovante : IEnviarComprovante
    {
        public void EnviarComprovante()
        {
            Console.WriteLine("Imprimindo Comprovante");
        }
    }

    public class EnviarSMSComprovante : IEnviarComprovante
    {
        public void EnviarComprovante()
        {
            Console.WriteLine("Enviando comprovante para SMS");
        }
    }

    public class EnviarEmailComprovante : IEnviarComprovante
    {
        public void EnviarComprovante()
        {
            Console.WriteLine("Enviando comprovante para Email");
        }
    }
}
