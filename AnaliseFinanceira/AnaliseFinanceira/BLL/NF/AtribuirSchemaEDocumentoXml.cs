using ACBr.Net.Sat;
using DFe.Utils;
using NFe.Classes;
using System;
using System.IO;
using System.Linq;
using System.Xml;

namespace AnaliseFinanceira
{
    public static class AtribuirSchemaEDocumentoXml
    {
        public static SchemaXmlDFe SetXML(this IAppArquivo appArquivo)
        {
            if (appArquivo.Extensao.ToUpper() != ".XML")
            {
                appArquivo.MessageError = "Arquivo não é do tipo XML";
                appArquivo.IsValid = false;
                return appArquivo.SchemaXmlDFe = SchemaXmlDFe.Erro;
            }
            XmlDocument xml = new XmlDocument();
            try
            {
                using (MemoryStream ms = new MemoryStream(appArquivo.Conteudo))
                {
                    xml.Load(ms);
                }
            }
            catch (Exception ex)
            {
                appArquivo.MessageError = "Erro ao deserializar o arquivo";
                appArquivo.IsValid = false;
                return appArquivo.SchemaXmlDFe = SchemaXmlDFe.Erro;
            }

            var root = xml.DocumentElement;
            switch (root.Name)
            {
                case "nfeProc":
                    appArquivo.IsValid = true;
                    appArquivo.DocumentoXml = xml;
                    CriarnfeProc(appArquivo);
                    return SchemaXmlDFe.nfeProc;
                case "NFe":
                    appArquivo.IsValid = true;
                    CriarTagnfeProc(xml);
                    appArquivo.DocumentoXml = xml;
                    CriarnfeProc(appArquivo);
                    return SchemaXmlDFe.nfeProc;
                case "cteProc":
                    appArquivo.IsValid = true;
                    appArquivo.DocumentoXml = xml;
                    return SchemaXmlDFe.cteProc;
                case "CTe":
                    appArquivo.IsValid = true;
                    CriarTagcteProc(xml);
                    appArquivo.DocumentoXml = xml;
                    return SchemaXmlDFe.cteProc;
                case "cteOSProc":
                    appArquivo.IsValid = true;
                    appArquivo.DocumentoXml = xml;
                    return SchemaXmlDFe.cteOSProc;
                case "CFe":
                    appArquivo.IsValid = true;
                    appArquivo.DocumentoXml = xml;
                    CriarcfeProc(appArquivo);
                    return SchemaXmlDFe.CFe;
                default:
                    appArquivo.IsValid = false;
                    appArquivo.MessageError = "O schema do Xml não é reconhecido pelo programa";
                    return SchemaXmlDFe.Erro;
            }
        }

        private static void CriarnfeProc(IAppArquivo appArquivo)
        {
            try
            {
                appArquivo.NfeProc = FuncoesXml.XmlStringParaClasse<nfeProc>(appArquivo.DocumentoXml.OuterXml);
            }
            catch (Exception)
            {
                appArquivo.IsValid = false;
                appArquivo.MessageError = "Erro ao deserializar nfeProc";
            }
        }
        private static void CriarTagnfeProc(XmlDocument xml)
        {
            XmlElement TnfeProc = xml.CreateElement("nfeProc", "http://www.portalfiscal.inf.br/nfe");
            TnfeProc.SetAttribute("versao", xml.GetElementsByTagName("infNFe")[0].Attributes["versao"].Value);
            var itens = xml.GetElementsByTagName("NFe");
            for (int i = 0; i < itens.Count; i++)
            {
                TnfeProc.AppendChild(itens[i]);
            }
            xml.AppendChild(TnfeProc);
        }
        private static void CriarTagcteProc(XmlDocument xml)
        {
            XmlElement TnfeProc = xml.CreateElement("cteProc", "http://www.portalfiscal.inf.br/cte");
            TnfeProc.SetAttribute("versao", xml.GetElementsByTagName("intCte")[0].Attributes["versao"].Value);
            var itens = xml.GetElementsByTagName("CTe");
            for (int i = 0; i < itens.Count; i++)
            {
                TnfeProc.AppendChild(itens[i]);
            }
            xml.AppendChild(TnfeProc);
        }
        private static void CriarcfeProc(IAppArquivo appArquivo)
        {
            try
            {
                appArquivo.CfeProc = CFe.Load(appArquivo.DocumentoXml.OuterXml);
            }
            catch (Exception)
            {
                appArquivo.IsValid = false;
                appArquivo.MessageError = "Erro ao deserializar cfeProc";
            }
        }
    }

    public static class AtribuirTipoNFePertecenceEmpresa
    {
        public static TipoEntradaOuSaida SetTipoNFe(this IAppArquivo appArquivo, string[] cnpjs)
        {
            if (appArquivo.NfeProc != null)
            {
                string CNPJemit = appArquivo.NfeProc.NFe.infNFe.emit.CNPJ;
                string CNPJdest = appArquivo.NfeProc.NFe.infNFe.dest.CNPJ;
                int tipoNF = (int)appArquivo.NfeProc.NFe.infNFe.ide.tpNF;

                if (cnpjs.Contains(CNPJemit) && tipoNF == 1) return appArquivo.TipoNFe = TipoEntradaOuSaida.Saida;
                if (cnpjs.Contains(CNPJemit) && tipoNF == 0) return appArquivo.TipoNFe = TipoEntradaOuSaida.Entrada;
                if (cnpjs.Contains(CNPJdest) && tipoNF == 1) return appArquivo.TipoNFe = TipoEntradaOuSaida.Entrada;
                appArquivo.IsValid = false;
                appArquivo.MessageError = "Xml não pertence a empresa";
            }
            if (appArquivo.CfeProc != null)
            {
                string CNPJemit = appArquivo.CfeProc.InfCFe.Emit.CNPJ;
                
                if (cnpjs.Contains(CNPJemit)) return appArquivo.TipoNFe = TipoEntradaOuSaida.Saida;
                appArquivo.IsValid = false;
                appArquivo.MessageError = "CFe não pertence a empresa";
            }

            return TipoEntradaOuSaida.Entrada;
        }
    }
    public static class AtribuirRangeDatas
    {
        public static void RangeDatas(this IAppArquivo appArquivo, DateTime[] rangeDatas)
        {
            if (appArquivo.NfeProc != null)
            {
                DateTime dataEmi = appArquivo.NfeProc.NFe.infNFe.ide.dhEmi.DateTime;

                if (dataEmi < rangeDatas[0] || dataEmi > rangeDatas[1])
                {
                    appArquivo.IsValid = false;
                    appArquivo.MessageError = $"Arquivos estão fora do range de data inicial {rangeDatas[0].ToString("dd/MM/yy")} e final {rangeDatas[1].ToString("dd/MM/yy")}";

                }
            }
            if (appArquivo.CfeProc != null)
            {
                DateTime dataEmi = appArquivo.CfeProc.InfCFe.Ide.DEmi;
                if (dataEmi < rangeDatas[0] || dataEmi > rangeDatas[1])
                {
                    appArquivo.IsValid = false;
                    appArquivo.MessageError = $"Arquivos estão fora do range de data inicial {rangeDatas[0].ToString("dd/MM/yy")} e final {rangeDatas[1].ToString("dd/MM/yy")}";

                }
            }
        }
    }
}
