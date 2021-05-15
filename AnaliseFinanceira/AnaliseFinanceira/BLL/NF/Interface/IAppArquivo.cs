using System;
using System.Xml;
using ACBr.Net.Sat;
using NFe.Classes;

namespace AnaliseFinanceira
{
    public interface IAppArquivo
    {
        string Nome { get; }
        Guid Id { get; }
        byte[] Conteudo { get; }
        long Tamanho { get; }
        string Extensao { get; }
        string MessageError { get; set; }
        SchemaXmlDFe SchemaXmlDFe { get; set; }
        XmlDocument DocumentoXml { get; set; }
        TipoEntradaOuSaida TipoNFe { get; set; }
        nfeProc NfeProc { get; set; }
        CFe CfeProc { get; set; }
        bool IsValid { get; set; }
    }
}
