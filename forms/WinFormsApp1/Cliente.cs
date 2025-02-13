using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1Matheus
{
    internal class Cliente
    {
        int codCliente;
        string nomeCliente;
        string sobrenomeCliente;
        string telefoneCliente;
        string emailCliente;
        string senhaCliente;
        string cpfCnpjCliente;
        string dataNascimento;
        string observacaoCliente;
        string generoCliente;
        string cepCliente;
        string logradouroCliente;
        string bairroCliente;
        int numCliente;
        int codCidade;

        public int CodCliente { get => codCliente; set => codCliente = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string SobrenomeCliente { get => sobrenomeCliente; set => sobrenomeCliente = value; }
        public string TelefoneCliente { get => telefoneCliente; set => telefoneCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string SenhaCliente { get => senhaCliente; set => senhaCliente = value; }
        public string CpfCnpjCliente { get => cpfCnpjCliente; set => cpfCnpjCliente = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string ObservacaoCliente { get => observacaoCliente; set => observacaoCliente = value; }
        public string GeneroCliente { get => generoCliente; set => generoCliente = value; }
        public string CepCliente { get => cepCliente; set => cepCliente = value; }
        public string LogradouroCliente { get => logradouroCliente; set => logradouroCliente = value; }
        public string BairroCliente { get => bairroCliente; set => bairroCliente = value; }
        public int NumCliente { get => numCliente; set => numCliente = value; }
        public int CodCidade { get => codCidade; set => codCidade = value; }
    }
}