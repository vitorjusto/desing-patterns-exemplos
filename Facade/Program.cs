using Facade.BancoServices;
using Facade.ComprovanteServices;
using System;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            var facade = new TransferenciaFacade(new BancoBradescoService(), new EnviarSMSComprovante());
            facade.FazerTransferencia(2);
            Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}");

            var facade2 = new TransferenciaFacade(new BancoItauService(), new ImprimirComprovante());
            facade2.FazerTransferencia(3);
            Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}");

            var facade3 = new TransferenciaFacade(new BancoItauService(), new EnviarEmailComprovante());
            facade3.FazerTransferencia(1);
            Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}");

            var facade4 = new TransferenciaFacade(new BancoSantanderService(), new EnviarEmailComprovante());
            facade4.FazerTransferencia(4);
            Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}");
        }
    }
}
