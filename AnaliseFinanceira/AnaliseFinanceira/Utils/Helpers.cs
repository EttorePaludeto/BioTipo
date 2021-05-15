using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseFinanceira.Utils
{
    public static class Helpers
    {
        public static string ExtrairCompetencia(this DateTime data)
        {
            return data.ToString().Substring(3, 2) + "/" + data.ToString().Substring(6, 4);
        }

        public static decimal ValorDividirZero(this decimal data)
        {
            if (data == 0) return 1;
            return data;
        }
    }
}
