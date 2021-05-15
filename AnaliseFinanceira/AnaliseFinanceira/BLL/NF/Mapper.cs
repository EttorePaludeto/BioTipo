using ACBr.Net.Sat;
using AnaliseFinanceira.Utils;
using NFe.Classes;
using NFe.Classes.Informacoes.Detalhe;
using NFe.Classes.Informacoes.Detalhe.Tributacao;
using System;
using System.Collections.Generic;
namespace AnaliseFinanceira
{
    public static class Mapper
    {
        public static IEnumerable<NF> MapperNFs(List<nfeProc> listnfeProc)
        {
            var nfs = new List<NF>();
            foreach (var nfeProc in listnfeProc)
            {
                nfs.Add(MapperNF(nfeProc));
            }
            return nfs;
        }
        public static NF MapperNF(nfeProc nfeProc)
        {
            var nf = new NF
            {
                Numero = nfeProc.NFe.infNFe.ide.nNF,
                Data = ((DateTimeOffset)nfeProc.NFe.infNFe.ide.dhEmi).DateTime,
                Competencia = ((DateTimeOffset)nfeProc.NFe.infNFe.ide.dhEmi).DateTime.ExtrairCompetencia(),
                Emitente = new Emit
                {
                    CNPJ = nfeProc.NFe.infNFe.emit.CNPJ,
                    Nome = nfeProc.NFe.infNFe.emit.xNome,
                },
                Destinatario = new Dest
                {
                    CNPJ = nfeProc.NFe.infNFe.dest.CNPJ,
                    Nome = nfeProc.NFe.infNFe.dest.xNome
                }
            };
            nf.Produtos = new List<Prod>(MapperDets(nfeProc, nf));
            return nf;
        }
        public static IEnumerable<Prod> MapperDets(nfeProc nfeProc, NF nf)
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
        public static ImpICMS MapperICMS(det item)
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
        public static ImpICMS MapperICMS(CFeDet item)
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
                if (icmsCFe.GetType() == typeof(ImpostoIcms00))
                {
                    var tagICMS = ((ImpostoIcms00)icmsCFe.Icms);
                    icms = new ImpICMS
                    {
                        Cst = tagICMS.Cst,
                        Alq = tagICMS.PIcms,
                        Imp = tagICMS.VIcms,
                        Bc = tagICMS.VIcms / tagICMS.PIcms * 100
                    };
                }
                if (icmsCFe.GetType() == typeof(ImpostoIcms40))
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
                if (icmsCFe.GetType() == typeof(ImpostoIcmsSn102))
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
                if (icmsCFe.GetType() == typeof(ImpostoIcmsSn900))
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
        public static CFeSat MapperCFe(CFe cFe)
        {
            var nf = new CFeSat
            {
                Numero = cFe.InfCFe.Ide.NCFe,
                Data = cFe.InfCFe.Ide.DEmi,
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
        public static IEnumerable<Prod> MapperDets(CFe cFe, NF nf)
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
        public static ImpISS MapperISS(det item)
        {
            var iss = new ImpISS
            {
                Bc = 0,
                Alq = 0,
                Imp = 0
            };
            if (item.imposto.ISSQN != null)
            {
                iss.Bc = item.imposto.ISSQN.vBC;
                iss.Alq = item.imposto.ISSQN.vAliq;
                iss.Imp = item.imposto.ISSQN.vISSQN;
            }
            return iss;
        }
        public static ImpISS MapperISS(CFeDet item)
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
    }
}
