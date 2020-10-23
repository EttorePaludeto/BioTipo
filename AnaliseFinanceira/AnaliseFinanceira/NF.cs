using DevExpress.Utils.Win;
using NFe.Classes.Informacoes.Detalhe.Tributacao;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseFinanceira
{
    public class NF
    {
        public long Numero { get; set; }
        public DateTime Data { get; set; }
        public emit Emitente { get; set; }
        public dest Destinatario { get; set; }
        public List<prod> Produtos {get;set;}
        public NF()
        {
            Produtos = new List<prod>();
        }
    }

    public class emit
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
    }
    public class dest
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
    }

    public class prod
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string NCM { get; set; }
        public string CEST { get; set; }
        public string Un { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
        public impICMS ICMS { get; set; }
        public impISS ISS { get; set; }

        public virtual NF Nf { get; set; }
    }

    public class impICMS
    {
        public string cst { get; set; }
        public decimal bc { get; set; }
        public decimal alq { get; set; }
        public decimal imp { get; set; }
    }

    public class impISS
    {
        public decimal bc { get; set; }
        public decimal alq { get; set; }
        public decimal imp { get; set; }
    }

    public class CFeSat: NF { }
}
