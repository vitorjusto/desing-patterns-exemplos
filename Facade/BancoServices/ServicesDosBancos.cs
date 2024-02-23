using System;

namespace Facade.BancoServices
{
    public interface IBancoService
    {
        public void FazerTransferencia(decimal quantidade);
    }

    public class BancoBradescoService : IBancoService
    {
        public void FazerTransferencia(decimal quantidade)
        {
            Console.WriteLine($"Transferindo {quantidade:n2} reais para o banco Bradesco");
        }
    }

    public class BancoItauService : IBancoService
    {
        public void FazerTransferencia(decimal quantidade)
        {
            Console.WriteLine($"Transferindo {quantidade:n2} reais para o banco Itau");
        }
    }

    public class BancoSantanderService : IBancoService
    {

        public void FazerTransferencia(decimal quantidade)
        {
            Console.WriteLine($"Transferindo {quantidade:n2} reais para o banco Santander");
        }
    }
}
