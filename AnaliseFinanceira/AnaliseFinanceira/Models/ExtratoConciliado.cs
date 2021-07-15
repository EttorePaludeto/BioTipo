using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseFinanceira.Models
{
    public class ExtratoConciliado
    {
        public int Id { get; set; }
        public int BancoId { get; set; }
        public int ExtratoId { get; set; }
        public int ParticipanteId { get; set; }
        public DateTime Data { get; set; }
        public int DebitoId { get; set; }
        public int CreditoId { get; set; }
        public string Historico { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorContabil { get; set; }

        public ExtratoConciliado()
        {

        }
        public ExtratoConciliado(int id, int bancoId, int extratoId, int participanteId, DateTime data, string historico, int debitoId, int creditoId, decimal valor, decimal valorContabil)
        {
            Id = id;
            BancoId = bancoId;
            ExtratoId = extratoId;
            ParticipanteId = participanteId;
            Data = data;
            Historico = historico;
            DebitoId = debitoId;
            CreditoId = creditoId;
            Valor = valor;
            ValorContabil = valorContabil;
        }
    }
}
