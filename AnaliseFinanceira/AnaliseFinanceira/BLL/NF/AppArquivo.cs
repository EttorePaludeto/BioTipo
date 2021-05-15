using System;
using System.IO;
using System.Xml;
using ACBr.Net.Sat;
using NFe.Classes;

namespace AnaliseFinanceira
{
    public class AppArquivo : IAppArquivo
    {
        public string Nome { get; private set; }
        public Guid Id { get; private set; }
        public byte[] Conteudo { get; private set; }
        public long Tamanho { get; private set; }
        public string Extensao { get; private set; }
        public SchemaXmlDFe SchemaXmlDFe { get; set; }
        public XmlDocument DocumentoXml { get; set; }
        public nfeProc NfeProc { get; set; }
        public CFe CfeProc { get; set; }
        public TipoEntradaOuSaida TipoNFe { get; set; }
        public string MessageError { get; set; }
        public bool IsValid { get; set; }

        public AppArquivo(string nome, string extensao, byte[] conteudo, long tamanho)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Conteudo = conteudo;
            Tamanho = tamanho;
            Extensao = extensao;
        }

        public AppArquivo(string nome, string extensao, MemoryStream stream)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Conteudo = stream.ToArray();
            Tamanho = stream.Length;
            Extensao = extensao;
            stream.Dispose();
        }
        public AppArquivo(FileInfo fileInfo, string[] cnpjs, DateTime[] rangeData)
        {
            Id = Guid.NewGuid();
            Nome = fileInfo.Name;
            Conteudo = File.ReadAllBytes(fileInfo.FullName);
            Tamanho = fileInfo.Length;
            Extensao = fileInfo.Extension;
            SchemaXmlDFe = AtribuirSchemaEDocumentoXml.SetXML(this);
            AtribuirRangeDatas.RangeDatas(this, rangeData);
            TipoNFe = AtribuirTipoNFePertecenceEmpresa.SetTipoNFe(this, cnpjs);
        }

    }
}
