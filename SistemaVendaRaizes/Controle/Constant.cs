using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendaRaizes.Controle
{
    public class Constant
    {
        public static string Connection()
        {
            return ConfigurationManager.AppSettings["Connection"];
        }
    }
}
