using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1Matheus
{
    internal class Produto
    {
        int codProduto;
        string nomeProduto;
        int quantidadeProduto;
        int estoqueProduto;
        double precoProduto;
        int codMarca;

        public int CodProduto { get => codProduto; set => codProduto = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public int QuantidadeProduto { get => quantidadeProduto; set => quantidadeProduto = value; }
        public int EstoqueProduto { get => estoqueProduto; set => estoqueProduto = value; }
        public double PrecoProduto { get => precoProduto; set => precoProduto = value; }
        public int CodMarca { get => codMarca; set => codMarca = value; }
    }
}
