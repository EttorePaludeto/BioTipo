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
using AnaliseFinanceira.UI.ViewsCompras;
using DevExpress.XtraPivotGrid;

namespace AnaliseFinanceira.UI
{
    public partial class FrmCompras : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XmlDocument Xml { get; private set; }
        public SchemaXmlDFe SchemaXml { get; private set; }
        private PivotGridField[] pivot = new PivotGridField[17];
        private NFeService NFeServices { get; set; }

        public FrmCompras()
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
            var path = @"C:\Users\adm_3\Google Drive\BioTipo\BioTipo - Fiscal\Xmls Compras e Vendas\2021\ENTRADA";
            if (Directory.Exists(path) == false) return;
            FileInfo[] arquivos = new DirectoryInfo(path).GetFiles("*.XML", SearchOption.TopDirectoryOnly);
            if (arquivos.Length == 0)
            {
                MessageBox.Show("O diretório não contém XMLs");
                return;
            }
          
            string[] cnpjs = new string[] { "03788376000109", "03788376000281" };
            DateTime[] rangeData = new DateTime[] { new DateTime(2021, 01, 01), new DateTime(2021, 03, 31) };

            pivotGridControl1.Fields.Clear();
            pivot = PivotCompras.Todos();
            pivotGridControl1.Fields.AddRange(pivot);

            NFeServices = new NFeService(arquivos, cnpjs, rangeData, progressBar1);
            pivotGridControl1.DataSource = NFeServices.ListaProdutosCompras(progressBar1);
        }
       
        private void BtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.ShowRibbonPrintPreview();
        }

        private void BtnFornecedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivot.Compras();
            //pivotGridControl1.RestoreLayoutFromXml("UI/ViewsCompras/Fornecedores.xml");
        }

        private void BtnProdutos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.RestoreLayoutFromXml("UI/ViewsCompras/Produtos.xml");
        }

        private void BtnCategorias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.RestoreLayoutFromXml("UI/ViewsCompras/Categorias.xml");
        }
        private void BtnICMS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.RestoreLayoutFromXml("UI/ViewsCompras/ICMSvendas.xml");
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
