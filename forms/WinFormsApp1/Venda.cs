using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1Matheus
{
    internal class Venda
    {
        int codVenda;
        int codCliente;
        string statusDaVenda;
        string dataVenda;
        int codTransporte;

        public int CodVenda { get => codVenda; set => codVenda = value; }
        public int CodCliente { get => codCliente; set => codCliente = value; }
        public string StatusDaVenda { get => statusDaVenda; set => statusDaVenda = value; }
        public string DataVenda { get => dataVenda; set => dataVenda = value; }
        public int CodTransporte { get => codTransporte; set => codTransporte = value; }
    }
}
