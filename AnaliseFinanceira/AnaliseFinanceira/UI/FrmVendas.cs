using ACBr.Net.Sat;
using DFe.Utils;
using NFe.Classes;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using Ookii.Dialogs.WinForms;
using System;
using System.Threading;

namespace AnaliseFinanceira.UI
{
    public partial class FrmVendas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XmlDocument Xml { get; private set; }
        public SchemaXmlDFe SchemaXml { get; private set; }
        private NFeService NFeServices { get; set; }

        public FrmVendas()
        {
            InitializeComponent();
        }
        private string Caminho()
        {
            VistaFolderBrowserDialog folder = new VistaFolderBrowserDialog();
            folder.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            folder.ShowDialog();
            return folder.SelectedPath;
        }
       
        private void BtnCarregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var path = Caminho();
            //var path = @"C:\Users\adm_3\Google Drive\BioTipo\BioTipo - Fiscal\Xmls Compras e Vendas\2021\SAIDA";
            var path = @"C:\Users\adm_3\Google Drive\BioTipo\BioTipo - Fiscal\Xmls Compras e Vendas\2021\SAIDA_e_TRANSF";
            if (Directory.Exists(path) == false) return;
            FileInfo[] arquivos = new DirectoryInfo(path).GetFiles("*.XML", SearchOption.TopDirectoryOnly);
            if (arquivos.Length == 0)
            {
                MessageBox.Show("O diretório não contém XMLs");
                return;
            }
         
            string[] cnpjs = new string[] { "03788376000109", "03788376000281" };
            DateTime[] rangeData = new DateTime[] { new DateTime(2021, 01, 01), new DateTime(2021, 03, 31, 23, 59, 59) };

            if (NFeServices == null) NFeServices = new NFeService(arquivos, cnpjs, rangeData, progressBar1);
            pivotGridControl1.DataSource = NFeServices.ListaProdutosVendas(progressBar1);

        }


       
        private void BtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.ShowRibbonPrintPreview();
        }

        private void BtnFornecedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.RestoreLayoutFromXml("UI/ViewsCompras/Clientes.xml");
        }

        private void BtnProdutos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.RestoreLayoutFromXml("UI/ViewsCompras/Produtos.xml");
        }

        private void BtnCategorias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.RestoreLayoutFromXml("UI/ViewsCompras/Categorias.xml");
        }

        private void BntICMS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.RestoreLayoutFromXml("UI/ViewsCompras/ICMSvendas.xml");
        }

        private void BtnISS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.OptionsLayout.Columns.AddNewColumns = true;
            pivotGridControl1.OptionsLayout.Columns.AddNewColumns = true;

            pivotGridControl1.RestoreLayoutFromXml("UI/ViewsCompras/ISSvendas.xml");
        }

        private void BtnVerErros_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NFeServices == null) return;
            List<string> erros = new List<string>();
            var appArquivosErros = NFeServices.ArquivosComErrors();

            foreach (var item in appArquivosErros)
            {
                erros.Add(item.Nome + " - " + item.MessageError);
            }
            Rotas.AbrirFrmErros(erros);
        }

      
    }
}
