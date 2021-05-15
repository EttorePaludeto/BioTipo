using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AnaliseFinanceira
{
    public class NFeService
    {
        public List<NF> NFs { get; set; }
        private List<AppArquivo> AppArquivos { get; set; }
        public NFeService(FileInfo[] arquivos, string[] cnpjs, DateTime[] rangeData, ProgressBar progressBar)
        {
            progressBar.Value = 0;
            progressBar.Maximum = arquivos.Count();
            progressBar.Step = 1;

            AppArquivos = new List<AppArquivo>();
            foreach (var item in arquivos)
            {
                var appArquivo = new AppArquivo(item, cnpjs, rangeData);
                AppArquivos.Add(appArquivo);
                progressBar.PerformStep();
            }
            progressBar.Value = 0;
        }
        public List<AppArquivo> ArquivosComErrors()
        {
            return AppArquivos.Where(c => c.IsValid == false).ToList();
        }
        public List<Prod> ListaProdutosCompras(ProgressBar progressBar)
        {
            List<Prod> prods = new List<Prod>();
            List<AppArquivo> listaCompras = AppArquivos.Where(c => c.IsValid == true && c.TipoNFe == TipoEntradaOuSaida.Entrada).Where(c => c.SchemaXmlDFe == SchemaXmlDFe.nfeProc || c.SchemaXmlDFe == SchemaXmlDFe.NFe).ToList();
            {
                foreach (var item in listaCompras)
                {
                    NF nF = SerializaAppArquivo.ParaNFCompra(item);
                    if (nF != null)
                    {
                        prods.AddRange(nF.Produtos);
                    }

                    progressBar.PerformStep();
                }
                progressBar.Value = 0;
                return prods;
            }
        }
        public List<Prod> ListaProdutosVendas(ProgressBar progressBar)
        {
            List<Prod> prods = new List<Prod>();

            List<AppArquivo> listaCFeVendas = AppArquivos.Where(c => c.IsValid == true && c.TipoNFe == TipoEntradaOuSaida.Saida).Where(c => c.SchemaXmlDFe == SchemaXmlDFe.CFe).ToList();

            progressBar.Value = 0;
            progressBar.Maximum = listaCFeVendas.Count();
            progressBar.Step = 1;

            {
                foreach (var item in listaCFeVendas)
                {
                    NF nF = SerializaAppArquivo.ParaNFVendasCFe(item);
                    if (nF != null)
                    {
                        prods.AddRange(nF.Produtos);
                    }

                    progressBar.PerformStep();
                }
                progressBar.Value = 0;
            }

            List<AppArquivo> listaNFeVendas = AppArquivos.Where(c => c.IsValid == true && c.TipoNFe == TipoEntradaOuSaida.Saida).Where(c => c.SchemaXmlDFe == SchemaXmlDFe.nfeProc).ToList();

            progressBar.Value = 0;
            progressBar.Maximum = listaNFeVendas.Count();
            progressBar.Step = 1;

            {
                foreach (var item in listaNFeVendas)
                {
                    NF nF = SerializaAppArquivo.ParaNFVendas(item);
                    if (nF != null)
                    {
                        prods.AddRange(nF.Produtos);
                    }

                    progressBar.PerformStep();
                }
                progressBar.Value = 0;
                
            }
            return prods;
        }

    }
}
