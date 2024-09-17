using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendaRaizes.Model
{
    public class PedidoItemModel
    {
        public DateTime DataVenda { get; set; }

        public int Bloco { get; set; }

        public int AP { get; set; }

        public string Cliente { get; set; }

        public string Tipo { get; set; }

        public string Produto { get; set; }

        public string VUni { get; set; }

        public int Qtde { get; set; }

        public string Pag { get; set; }

        public string VTotal { get; set; }

        public string Local { get; set; }

    }
}
