using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1Matheus
{
    internal class Log
    {
        int codLog;
        string acao;
        string tabela;
        string observacao;
        string usuario;
        //string data;

        public int CodLog { get => codLog; set => codLog = value; }
        public string acaoLog { get => acao; set => acao = value; }
        public string tabelaLog { get => tabela; set => tabela = value; }
        public string observacaoLog { get => observacao; set => observacao = value; }
        public string usuarioLog { get => usuario; set => usuario = value; }
    }
}
