using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseFinanceira
{
    public interface IAppArquivo
    {
        string Nome { get; }
        Guid Id { get; }
        byte[] Conteudo { get; }
        long Tamanho { get; }
        string Extensao { get; }

    }
}
