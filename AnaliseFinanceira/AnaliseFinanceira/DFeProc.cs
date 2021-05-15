using DFe.Utils;
using NFe.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace AnaliseFinanceira
{
    public class DFeProc
    {
        public IAppArquivo Arquivo { get; private set; }
        public nfeProc NfeProc { get; private set; }
        public SchemaXmlDFe SchemaXml { get; private set; }
        public System.Xml.XmlDocument Xml { get; private set; }
        public bool IsXmlDFe { get; private set; }
        public DFeProc(IAppArquivo arquivo)
        {
            Arquivo = arquivo;
            Iniciar();
        }
        private void Iniciar()
        {
            if (DeserializarXml() == false)
            {
                IsXmlDFe = false;
                return;
            }
            if (GetSchemaXml() == false)
            {
                IsXmlDFe = false;
                return;
            }
            TiparDFe();
        }
        private bool DeserializarXml()
        {
            if (Arquivo.Extensao.ToUpper() != ".XML")
            {
                Arquivo.MessageError = $"Erro - O Arquivo não é do tipo Xml. Nome Arquivo: {Arquivo.Nome}";
                return false;
            }
            Xml = new XmlDocument();
            try
            {
                using (MemoryStream ms = new MemoryStream(Arquivo.Conteudo))
                {
                    Xml.Load(ms);
                }
                return true;
            }
            catch (Exception ex)
            {
                Arquivo.MessageError = $"Erro - O Arquivo não é do tipo Xml. Nome Arquivo: {Arquivo.Nome}";
                return false;
            }
        }
        private bool GetSchemaXml()
        {
            var root = Xml.DocumentElement;
            switch (root.Name)
            {
                case "nfeProc":
                    SchemaXml = SchemaXmlDFe.nfeProc;
                    return true;
                case "NFe":
                    SchemaXml = SchemaXmlDFe.NFe;
                    return true;
                case "cteProc":
                    SchemaXml = SchemaXmlDFe.cteProc;
                    return true;
                case "CTe":
                    SchemaXml = SchemaXmlDFe.CTe;
                    return true;
                case "cteOSProc":
                    SchemaXml = SchemaXmlDFe.cteOSProc;
                    return true;
                default:
                    SchemaXml = SchemaXmlDFe.Erro;
                    Arquivo.MessageError = $"Erro - Arquivo XML com schema desconhecido. Nome Arquivo: {Arquivo.Nome}";
                    return false;
            }
        }
        private void TiparDFe()
        {
            switch (SchemaXml)
            {
                case SchemaXmlDFe.nfeProc:
                    CriarnfeProc();
                    break;
                case SchemaXmlDFe.NFe:
                    CriarTagnfeProc();
                    CriarnfeProc();
                    break;
                case SchemaXmlDFe.cteProc:
                    //criarcteProc();
                    break;
                case SchemaXmlDFe.CTe:
                    CriarTagcteProc();
                    // criarcteProc();
                    break;
                case SchemaXmlDFe.cteOSProc:
                    //criarcteOSProc();
                    break;
                case SchemaXmlDFe.procEventoNfe:
                    break;
                case SchemaXmlDFe.Erro:
                    break;
                default:
                    break;
            }
        }
        private void CriarnfeProc()
        {
            NfeProc = FuncoesXml.XmlStringParaClasse<nfeProc>(Xml.OuterXml);
        }
        private void CriarTagnfeProc()
        {
            XmlElement TnfeProc = Xml.CreateElement("nfeProc", "http://www.portalfiscal.inf.br/nfe");
            TnfeProc.SetAttribute("versao", Xml.GetElementsByTagName("infNFe")[0].Attributes["versao"].Value);
            var itens = Xml.GetElementsByTagName("NFe");
            for (int i = 0; i < itens.Count; i++)
            {
                TnfeProc.AppendChild(itens[i]);
            }
            Xml.AppendChild(TnfeProc);
        }
        //private void criarcteProc()
        //{
        //    cteProc = FuncoesXml.XmlStringParaClasse<cteProc>(Xml.OuterXml);
        //}
        private void CriarTagcteProc()
        {
            XmlElement TnfeProc = Xml.CreateElement("cteProc", "http://www.portalfiscal.inf.br/cte");
            TnfeProc.SetAttribute("versao", Xml.GetElementsByTagName("intCte")[0].Attributes["versao"].Value);
            var itens = Xml.GetElementsByTagName("CTe");
            for (int i = 0; i < itens.Count; i++)
            {
                TnfeProc.AppendChild(itens[i]);
            }
            Xml.AppendChild(TnfeProc);
        }
    }
}
