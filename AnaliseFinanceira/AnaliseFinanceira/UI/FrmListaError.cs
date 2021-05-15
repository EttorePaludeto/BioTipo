using Ookii.Dialogs.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseFinanceira.UI
{
    public partial class FrmListaError : Form
    {
        private List<string> Log = new List<string>();

        public FrmListaError(List<string> erros)
        {
            InitializeComponent();
            Log = erros;
            CarregarLogs();
        }

        private void CarregarLogs()
        {
            Log.ForEach(c => listBoxControl1.Items.Add(c));
        }

        private void GerarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            VistaFolderBrowserDialog folder = new VistaFolderBrowserDialog();
            folder.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            folder.ShowDialog();

            if (Directory.Exists(folder.SelectedPath) == false)
            {
                MessageBox.Show("Diretório de destino é invalido");
                return;
            }

            // Set a variable to the Documents path.
            string docPath = folder.SelectedPath;
              //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "log.txt")))
            {
                foreach (string line in Log)
                    outputFile.WriteLine(line);
            }

            MessageBox.Show($"Arquivo Log.txt criado com sucesso na sua pasta: {folder.SelectedPath}");


        }
    }
}
