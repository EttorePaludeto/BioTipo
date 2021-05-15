using ACBr.Net.Sat;
using AnaliseFinanceira.Utils;
using DFe.Utils;
using NFe.Classes;
using NFe.Classes.Informacoes.Detalhe;
using NFe.Classes.Informacoes.Detalhe.Tributacao;
using System;
using System.Collections.Generic;
namespace AnaliseFinanceira
{
    public static class SerializaAppArquivo
    {
        public static NF ParaNFCompra(IAppArquivo appArquivo)
        {
            var NfeProc = appArquivo.NfeProc;
            var nf = new NF
            {
                Numero = NfeProc.NFe.infNFe.ide.nNF,
                Data = ((DateTimeOffset)NfeProc.NFe.infNFe.ide.dhEmi).DateTime,
                Competencia = ((DateTimeOffset)NfeProc.NFe.infNFe.ide.dhEmi).DateTime.ExtrairCompetencia(),
                Emitente = new Emit
                {
                    CNPJ = NfeProc.NFe.infNFe.emit.CNPJ,
                    Nome = NfeProc.NFe.infNFe.emit.xNome,
                },
                Destinatario = new Dest
                {
                    CNPJ = NfeProc.NFe.infNFe.dest.CNPJ,
                    Nome = NfeProc.NFe.infNFe.dest.xNome
                }
            };
            nf.Produtos = new List<Prod>(MapperDets(NfeProc, nf));
            return nf;
        }
        private static IEnumerable<Prod> MapperDets(nfeProc nfeProc, NF nf)
        {
            var prods = new List<Prod>();
            foreach (var item in nfeProc.NFe.infNFe.det)
            {
                prods.Add(new Prod
                {
                    Codigo = item.prod.cProd,
                    Descricao = item.prod.xProd,
                    NCM = item.prod.NCM,
                    CFOP = item.prod.CFOP.ToString(),
                    Categoria = AtribuirCategoria.Compras(item.prod.CFOP.ToString()),
                    CEST = item.prod.CEST,
                    Un = item.prod.uCom,
                    Quantidade = item.prod.qCom,
                    Valor = item.prod.vProd,
                    ICMS = MapperICMS(item),
                    Nf = nf
                });
            }
            return prods;
        }
        private static ImpICMS MapperICMS(det item)
        {
            var icms = new ImpICMS
            {
                Cst = "",
                Bc = 0,
                Alq = 0,
                Imp = 0
            };
            if (item.imposto.ICMS != null)
            {
                icms.Cst = item.imposto.ICMS.TipoICMS.GetIcmsCst().ToString();
                icms.Bc = item.imposto.ICMS.TipoICMS.GetIcmsBcValue();
                icms.Alq = item.imposto.ICMS.TipoICMS.GetIcmsPercent();
                icms.Imp = item.imposto.ICMS.TipoICMS.GetIcmsValue();
            }
            return icms;
        }

        public static NF ParaNFVendas(IAppArquivo appArquivo)
        {
            var NfeProc = appArquivo.NfeProc;
            var nf = new NF
            {
                Numero = NfeProc.NFe.infNFe.ide.nNF,
                Data = ((DateTimeOffset)NfeProc.NFe.infNFe.ide.dhEmi).DateTime,
                Competencia = ((DateTimeOffset)NfeProc.NFe.infNFe.ide.dhEmi).DateTime.ExtrairCompetencia(),
                Emitente = new Emit
                {
                    CNPJ = NfeProc.NFe.infNFe.emit.CNPJ,
                    Nome = NfeProc.NFe.infNFe.emit.xNome,
                },
                Destinatario = new Dest
                {
                    CNPJ = NfeProc.NFe.infNFe.dest.CNPJ,
                    Nome = NfeProc.NFe.infNFe.dest.xNome
                }
            };
            nf.Produtos = new List<Prod>(MapperDetsVenda(NfeProc, nf));
            return nf;
        }
        private static IEnumerable<Prod> MapperDetsVenda(nfeProc nfeProc, NF nf)
        {
            var prods = new List<Prod>();
            foreach (var item in nfeProc.NFe.infNFe.det)
            {
                prods.Add(new Prod
                {
                    Codigo = item.prod.cProd,
                    Descricao = item.prod.xProd,
                    NCM = item.prod.NCM,
                    CFOP = item.prod.CFOP.ToString(),
                    Categoria = AtribuirCategoria.Vendas(item.prod.CFOP.ToString()),
                    CEST = item.prod.CEST,
                    Un = item.prod.uCom,
                    Quantidade = item.prod.qCom,
                    Valor = item.prod.vProd,
                    ICMS = MapperICMS(item),
                    Nf = nf
                });
            }
            return prods;
        }
      
        public static NF ParaNFVendasCFe(IAppArquivo appArquivo)
        {
            var cFe = appArquivo.CfeProc;
            var nf = new CFeSat
            {
                Numero = cFe.InfCFe.Ide.NCFe,
                Data = cFe.InfCFe.Ide.DEmi,
                Competencia = ((DateTimeOffset)cFe.InfCFe.Ide.DEmi).DateTime.ExtrairCompetencia(),
                Emitente = new Emit
                {
                    CNPJ = cFe.InfCFe.Emit.CNPJ,
                    Nome = cFe.InfCFe.Emit.XNome,
                },
                Destinatario = new Dest
                {
                    CNPJ = cFe.InfCFe.Dest.CNPJ.DefaultIfNull(cFe.InfCFe.Dest.CPF),
                    Nome = cFe.InfCFe.Dest.Nome
                }
            };
            nf.Produtos = new List<Prod>(MapperDets(cFe, nf));
            return nf;
        }
        private static IEnumerable<Prod> MapperDets(CFe cFe, NF nf)
        {
            var prods = new List<Prod>();
            foreach (var item in cFe.InfCFe.Det)
            {
                prods.Add(new Prod
                {
                    Codigo = item.Prod.CProd,
                    Descricao = item.Prod.XProd,
                    NCM = item.Prod.NCM,
                    CFOP = item.Prod.CFOP,
                    Categoria = AtribuirCategoria.Vendas(item.Prod.CFOP.ToString()),
                    Un = item.Prod.UCom,
                    Quantidade = item.Prod.QCom,
                    Valor = item.Prod.VProd,
                    ISS = MapperISS(item),
                    ICMS = MapperICMS(item),
                    Nf = nf
                });
            }
            return prods;
        }
        private static ImpISS MapperISS(CFeDet item)
        {
            var iss = new ImpISS
            {
                Bc = 0,
                Alq = 0,
                Imp = 0
            };
            if (item.Imposto.Imposto != null)
            {
                if (item.Imposto.Imposto.GetType() == typeof(ImpostoIssqn))
                {
                    var issCFe = (ImpostoIssqn)item.Imposto.Imposto;
                    iss = new ImpISS
                    {
                        Bc = issCFe.VBc,
                        Alq = issCFe.VAliq,
                        Imp = issCFe.VIssqn
                    };
                }
                //iss.Alq = item.imposto.ISSQN.vAliq;
                //iss.Imp = item.imposto.ISSQN.vISSQN;
            }
            return iss;
        }
        private static ImpICMS MapperICMS(CFeDet item)
        {
            var icms = new ImpICMS
            {
                Cst = "",
                Bc = 0,
                Alq = 0,
                Imp = 0
            };
            if (item.Imposto.Imposto.GetType() == typeof(ImpostoIcms))
            {
                var icmsCFe = (ImpostoIcms)item.Imposto.Imposto;
                if (icmsCFe.Icms.GetType() == typeof(ImpostoIcms00))
                {
                    var tagICMS = ((ImpostoIcms00)icmsCFe.Icms);
                    icms = new ImpICMS
                    {
                        Cst = tagICMS.Cst,
                        Alq = tagICMS.PIcms,
                        Imp = tagICMS.VIcms,
                        Bc = tagICMS.VIcms / tagICMS.PIcms.ValorDividirZero() * 100
                    };
                }
                if (icmsCFe.Icms.GetType() == typeof(ImpostoIcms40))
                {
                    var tagICMS = ((ImpostoIcms40)icmsCFe.Icms);
                    icms = new ImpICMS
                    {
                        Cst = tagICMS.Cst,
                        Alq = 0,
                        Imp = 0,
                        Bc = 0
                    };
                }
                if (icmsCFe.Icms.GetType() == typeof(ImpostoIcmsSn102))
                {
                    var tagICMS = ((ImpostoIcmsSn102)icmsCFe.Icms);
                    icms = new ImpICMS
                    {
                        Cst = tagICMS.Csosn,
                        Alq = 0,
                        Imp = 0,
                        Bc = 0
                    };
                }
                if (icmsCFe.Icms.GetType() == typeof(ImpostoIcmsSn900))
                {
                    var tagICMS = ((ImpostoIcmsSn900)icmsCFe.Icms);
                    icms = new ImpICMS
                    {
                        Cst = tagICMS.Csosn,
                        Alq = tagICMS.PIcms,
                        Imp = tagICMS.VIcms,
                        Bc = tagICMS.VIcms / tagICMS.PIcms * 100
                    };
                }
            }
            return icms;
        }

    }
}
