using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1Matheus
{
    internal class Cidade
    {
        int codCidade;
        string cid;
        int uf;
        public int CodCidade { get => codCidade; set => codCidade = value; }
        public string Cid { get => cid; set => cid = value; }
        public int UF { get => uf; set => uf = value; }
    }
}
