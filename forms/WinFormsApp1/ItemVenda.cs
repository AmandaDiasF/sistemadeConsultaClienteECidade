using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1Matheus
{
    internal class ItemVenda
    {
        int codItemVenda;
        int codProduto;
        decimal valor;
        int quantVenda;
        int codVenda;
        public int CodItemVenda { get => codItemVenda; set => codItemVenda = value; }
        public int CodProduto { get => codProduto; set => codProduto = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public int QuantVenda { get => quantVenda; set => quantVenda = value; }
        public int CodVenda { get => codVenda; set => codVenda = value; }

    }
}
