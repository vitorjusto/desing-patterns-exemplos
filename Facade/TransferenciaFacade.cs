using Facade.BancoServices;
using Facade.ComprovanteServices;
using System;

namespace Facade
{
    public class TransferenciaFacade
    {
        public TransferenciaFacade(IBancoService bancoService, IEnviarComprovante enviarComprovante)
        {
            _enviarComprovante = enviarComprovante;
            _bancoService = bancoService;
        }

        private IEnviarComprovante _enviarComprovante { get; set; }
        private IBancoService _bancoService { get; set; }

        public void FazerTransferencia(decimal quantidade)
        {
            _bancoService.FazerTransferencia(quantidade);
            _enviarComprovante.EnviarComprovante();
            Console.WriteLine($"Transferencia concluida");

        }
    }
}
