using ACBr.Net.Sat;
using DFe.Utils;
using NFe.Classes;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace AnaliseFinanceira
{
    public partial class frmCompras : Form
    {

        public XmlDocument Xml { get; private set; }
        public SchemaXmlDFe SchemaXml { get; private set; }

        public frmCompras()
        {
            InitializeComponent();
        }

        public void carregar()
        {
            var path = Caminho();
            if (path == null) return;
            
            FileInfo[] arquivos = new DirectoryInfo(path).GetFiles();

            var Lista = new List<prod>();

            progressBar1.Value = 0;
            progressBar1.Maximum = arquivos.Count();
            progressBar1.Step = 1;

            foreach (var arquivo in arquivos)
            {

                byte[] arquivosBytes = File.ReadAllBytes(arquivo.FullName);
                IAppArquivo arquivosStream;
                using (MemoryStream ms = new MemoryStream(arquivosBytes))
                {
                    arquivosStream = new AppArquivo(arquivo.Name, arquivo.Extension, ms);
                }

                var dfeproc = new DFeProc(arquivosStream);
                var nf = Mapper.MapperNF(dfeproc.nfeProc);

                var prod = Mapper.MapperDets(dfeproc.nfeProc, nf);
                Lista.AddRange(prod);

                progressBar1.PerformStep();
               
            }

            pivotGridControl1.DataSource = Lista;
            progressBar1.Value = 0;
        }

        public string Caminho()
        {
        //var b = @"C:\Users\adm_3\Desktop\Trabalhos em Andamento\BioTipo Farmácia\Xmls Compras e Vendas\xmls\nfe";
        // a = @"C:\Users\adm_3\Desktop\Trabalhos em Andamento\BioTipo Farmácia\Xmls Compras e Vendas\xmls\cupons";

            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.SelectedPath = @"C:\Users\ettor\source\repos\Desenvolvimento\BioTipo Farmácia\Xmls Compras e Vendas\xmls";
            folder.ShowDialog();
                        
            return folder.SelectedPath;

        }


        public void carregarCFe()
        {
            var path = Caminho();
            if (path == null) return;

            FileInfo[] arquivos = new DirectoryInfo(path).GetFiles();


            progressBar1.Value = 0;
            progressBar1.Maximum = arquivos.Count();
            progressBar1.Step = 1;

            var Lista = new List<prod>();

            foreach (var arquivo in arquivos)
            {
                byte[] arquivosBytes = File.ReadAllBytes(arquivo.FullName);
                CFe cfeProc;
                using (MemoryStream ms = new MemoryStream(arquivosBytes))
                {
                    cfeProc = CFe.Load(ms);
                }
                var cfeNF = Mapper.MapperCFe(cfeProc);

                var prod = Mapper.MapperDets(cfeProc, cfeNF);
                Lista.AddRange(prod);
                progressBar1.PerformStep();
            }

            pivotGridControl1.DataSource = Lista;
            progressBar1.Value = 0;
        }


        private void cFeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
          
            carregarCFe();
        }

        private void xmlNFeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            carregar();
        }
    }
}
