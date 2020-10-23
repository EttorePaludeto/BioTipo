using ACBr.Net.Sat;
using DevExpress.DataProcessing;
using DevExpress.Utils.Extensions;
using DFe.Utils;
using NFe.Classes;
using NFe.Classes.Informacoes.Detalhe;
using NFe.Classes.Informacoes.Detalhe.Tributacao;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseFinanceira
{
    public static class Mapper
    {
        public static IEnumerable<NF> MapperNFs(List<nfeProc> ListnfeProc)
        {
            var nfs = new List<NF>();

            foreach (var nfeProc in ListnfeProc)
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
                Emitente = new emit
                {
                    CNPJ = nfeProc.NFe.infNFe.emit.CNPJ,
                    Nome = nfeProc.NFe.infNFe.emit.xNome,
                },
                Destinatario = new dest
                {
                    CNPJ = nfeProc.NFe.infNFe.dest.CNPJ,
                    Nome = nfeProc.NFe.infNFe.dest.xNome
                }
            };

            nf.Produtos = new List<prod>(MapperDets(nfeProc, nf));

            return nf;

        }

        public static IEnumerable<prod> MapperDets(nfeProc nfeProc, NF nf)
        {
            var prods = new List<prod>();

            foreach (var item in nfeProc.NFe.infNFe.det)
            {
                prods.Add(new prod
                {
                    Codigo = item.prod.cProd,
                    Descricao = item.prod.xProd,
                    NCM = item.prod.NCM,
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

        public static impICMS MapperICMS(det item)
        {
            var icms = new impICMS
            {
                cst = "",
                bc = 0,
                alq = 0,
                imp = 0
            };

            if (item.imposto.ICMS != null)
            {
                icms.cst = item.imposto.ICMS.TipoICMS.GetIcmsCst().ToString();
                icms.bc = item.imposto.ICMS.TipoICMS.GetIcmsBcValue();
                icms.alq = item.imposto.ICMS.TipoICMS.GetIcmsPercent();
                icms.imp = item.imposto.ICMS.TipoICMS.GetIcmsValue();
            }

            return icms;

        }

        public static impICMS MapperICMS(CFeDet item)
        {
            var icms = new impICMS
            {
                cst = "",
                bc = 0,
                alq = 0,
                imp = 0
            };

            if (item.Imposto.Imposto.GetType() == typeof(ImpostoIcms))
            {
                var icmsCFe = (ImpostoIcms)item.Imposto.Imposto;

                if (icmsCFe.GetType() == typeof(ImpostoIcms00))
                {
                    var tagICMS = ((ImpostoIcms00)icmsCFe.Icms);
                    icms = new impICMS
                    {
                        cst = tagICMS.Cst,
                        alq = tagICMS.PIcms,
                        imp = tagICMS.VIcms,
                        bc = tagICMS.VIcms / tagICMS.PIcms * 100
                    };
                }
                if (icmsCFe.GetType() == typeof(ImpostoIcms40))
                {
                    var tagICMS = ((ImpostoIcms40)icmsCFe.Icms);
                    icms = new impICMS
                    {
                        cst = tagICMS.Cst,
                        alq = 0,
                        imp = 0,
                        bc = 0
                    };
                }
                if (icmsCFe.GetType() == typeof(ImpostoIcmsSn102))
                {
                    var tagICMS = ((ImpostoIcmsSn102)icmsCFe.Icms);
                    icms = new impICMS
                    {
                        cst = tagICMS.Csosn,
                        alq = 0,
                        imp = 0,
                        bc = 0
                    };
                }
                if (icmsCFe.GetType() == typeof(ImpostoIcmsSn900))
                {
                    var tagICMS = ((ImpostoIcmsSn900)icmsCFe.Icms);
                    icms = new impICMS
                    {
                        cst = tagICMS.Csosn,
                        alq = tagICMS.PIcms,
                        imp = tagICMS.VIcms,
                        bc = tagICMS.VIcms / tagICMS.PIcms * 100
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
                Emitente = new emit
                {
                    CNPJ = cFe.InfCFe.Emit.CNPJ,
                    Nome = cFe.InfCFe.Emit.XNome,
                },
                Destinatario = new dest
                {
                    CNPJ = cFe.InfCFe.Dest.CNPJ,
                    Nome = cFe.InfCFe.Dest.Nome
                }
            };

            nf.Produtos = new List<prod>(MapperDets(cFe, nf));

            return nf;

        }

        public static IEnumerable<prod> MapperDets(CFe cFe, NF nf)
        {
            var prods = new List<prod>();

            foreach (var item in cFe.InfCFe.Det)
            {
                prods.Add(new prod
                {
                    Codigo = item.Prod.CProd,
                    Descricao = item.Prod.XProd,
                    NCM = item.Prod.NCM,
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

        public static impISS MapperISS(det item)
        {
            var iss = new impISS
            {
                bc = 0,
                alq = 0,
                imp = 0
            };

            if (item.imposto.ISSQN != null)
            {
                iss.bc = item.imposto.ISSQN.vBC;
                iss.alq = item.imposto.ISSQN.vAliq;
                iss.imp = item.imposto.ISSQN.vISSQN;
            }

            return iss;

        }
        public static impISS MapperISS(CFeDet item)
        {

            var iss = new impISS
            {
                bc = 0,
                alq = 0,
                imp = 0
            };

            if (item.Imposto.Imposto != null)
            {
                if (item.Imposto.Imposto.GetType() == typeof(ImpostoIssqn))
                {
                    var issCFe = (ImpostoIssqn)item.Imposto.Imposto;

                    iss = new impISS
                    {
                        bc = issCFe.VBc,
                        alq = issCFe.VAliq,
                        imp = issCFe.VIssqn
                    };


                }



                //iss.alq = item.imposto.ISSQN.vAliq;
                //iss.imp = item.imposto.ISSQN.vISSQN;
            }

            return iss;

        }


    }
}
