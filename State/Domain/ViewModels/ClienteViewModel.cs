namespace State.Domain.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel(string nomeCliente, string cPF, string endereco, string numero, string bairro, string cidade)
        {
            NomeCliente = nomeCliente;
            CPF = cPF;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }

        public string NomeCliente { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Mensagem { get; set; } = "";

        public bool Validar()
        {
            if(NomeCliente == "")
            {
                Mensagem = "Informe o nome do cliente.";
                return false;
            }

            if (CPF == "")
            {
                Mensagem = "Informe o CPF.";
                return false;
            }

            if (Endereco == "")
            {
                Mensagem = "Informe o Endereco.";
                return false;
            }

            if (Numero == "")
            {
                Mensagem = "Informe o Numero.";
                return false;
            }

            if (Bairro == "")
            {
                Mensagem = "Informe o Bairro.";
                return false;
            }

            if (Cidade == "")
            {
                Mensagem = "Informe o Cidade.";
                return false;
            }

            return true;
        }
    }
}
