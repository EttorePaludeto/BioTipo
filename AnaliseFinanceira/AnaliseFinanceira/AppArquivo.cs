using System;
using System.IO;

namespace AnaliseFinanceira
{
    public class AppArquivo : IAppArquivo
    {
        public string Nome { get; private set; }
        public Guid Id { get; private set; }
        public byte[] Conteudo { get; private set; }
        public long Tamanho { get; private set; }
        public string Extensao { get; private set; }

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
    }
}
