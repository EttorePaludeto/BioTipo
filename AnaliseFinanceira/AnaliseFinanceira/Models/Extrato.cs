using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseFinanceira.Models
{
    public class Extrato
    {
        public int Id { get; set; }
        public int BancoId { get; set; }
        public DateTime Data { get; set; }
        public string Historico { get; set; }
        public decimal Valor { get; set; }

        public Extrato()
        {

        }
        public Extrato(int id, int bancoId, DateTime data, string historico, decimal valor)
        {
            Id = id;
            BancoId = bancoId;
            Data = data;
            Historico = historico;
            Valor = valor;
        }
    }
}
