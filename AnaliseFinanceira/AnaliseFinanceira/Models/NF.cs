using System;
using System.Collections.Generic;

namespace AnaliseFinanceira
{
    public class NF
    {
        public long Numero { get; set; }
        public DateTime Data { get; set; }
        public string Competencia { get; set; }
        public Emit Emitente { get; set; }
        public Dest Destinatario { get; set; }
        public List<Prod> Produtos {get;set;}
        public List<Dup> Duplicatas { get; set; }
        public NF()
        {
            Produtos = new List<Prod>();
            Duplicatas = new List<Dup>();
        }
    }

    public class Emit
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
    }
    public class Dest
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
    }

    public class Prod
    {
        public string Codigo { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string NCM { get; set; }
        public string CEST { get; set; }
        public string CFOP { get; set; }
        public string Un { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
        public ImpICMS ICMS { get; set; }
        public ImpISS ISS { get; set; }
        public virtual NF Nf { get; set; }
    }

    public class Dup
    {
        public string Duplicata { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
        public virtual NF Nf { get; set; }
    }

    public class ImpICMS
    {
        public string Cst { get; set; }
        public decimal Bc { get; set; }
        public decimal Alq { get; set; }
        public decimal Imp { get; set; }
    }

    public class ImpISS
    {
        public decimal Bc { get; set; }
        public decimal Alq { get; set; }
        public decimal Imp { get; set; }
    }

    public class CFeSat: NF { }
}
