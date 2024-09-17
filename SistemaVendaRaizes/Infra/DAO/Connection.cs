using SistemaVendaRaizes.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendaRaizes.Infra.DAO
{
    class Connection
    {
        public static string GGConfeitaria()
        {
            return Constant.Connection();
        }
    }
}
