using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ACBr.Net.Sat;

namespace AnaliseFinanceira
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();

            carregarCFe();

          
            
        }


        public void carregarCFe()
        {
            string Diretorio = @"C:\Users\adm_3\Desktop\Trabalhos em Andamento\BioTipo Farmácia\Xmls Compras e Vendas\xmls\cupons";
            FileInfo[] arquivos = new DirectoryInfo(Diretorio).GetFiles();

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
            }

           // pivotGridControl1.DataSource = Lista;

        }
    }
}
