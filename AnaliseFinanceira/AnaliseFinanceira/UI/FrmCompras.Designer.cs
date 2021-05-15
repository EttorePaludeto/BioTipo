namespace AnaliseFinanceira.UI
{
    partial class FrmCompras
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldCodigo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDescricao1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNCM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUn1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantidade1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNfData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCFOP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField9 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField10 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoria = new DevExpress.XtraPivotGrid.PivotGridField();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnCarregar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFornecedores = new DevExpress.XtraBars.BarButtonItem();
            this.BtnProdutos = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnVerErros = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCategorias = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGerar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupGerar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupNotifications = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.BtnICMS = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.produtosBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCodigo1,
            this.fieldDescricao1,
            this.fieldNCM1,
            this.fieldUn1,
            this.fieldQuantidade1,
            this.fieldValor1,
            this.fieldNfData,
            this.pivotGridField1,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField5,
            this.pivotGridField6,
            this.pivotGridField7,
            this.fieldCFOP,
            this.pivotGridField8,
            this.pivotGridField9,
            this.pivotGridField10,
            this.fieldCategoria});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 144);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(1185, 503);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.nFBindingSource;
            // 
            // nFBindingSource
            // 
            this.nFBindingSource.DataSource = typeof(AnaliseFinanceira.NF);
            // 
            // fieldCodigo1
            // 
            this.fieldCodigo1.AreaIndex = 10;
            this.fieldCodigo1.Caption = "Codigo";
            this.fieldCodigo1.FieldName = "Codigo";
            this.fieldCodigo1.Name = "fieldCodigo1";
            this.fieldCodigo1.Visible = false;
            // 
            // fieldDescricao1
            // 
            this.fieldDescricao1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDescricao1.AreaIndex = 0;
            this.fieldDescricao1.Caption = "Descricao";
            this.fieldDescricao1.FieldName = "Descricao";
            this.fieldDescricao1.Name = "fieldDescricao1";
            this.fieldDescricao1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            this.fieldDescricao1.Visible = false;
            this.fieldDescricao1.Width = 593;
            // 
            // fieldNCM1
            // 
            this.fieldNCM1.AreaIndex = 0;
            this.fieldNCM1.Caption = "NCM";
            this.fieldNCM1.FieldName = "NCM";
            this.fieldNCM1.Name = "fieldNCM1";
            this.fieldNCM1.Visible = false;
            // 
            // fieldUn1
            // 
            this.fieldUn1.AreaIndex = 0;
            this.fieldUn1.Caption = "Un";
            this.fieldUn1.FieldName = "Un";
            this.fieldUn1.Name = "fieldUn1";
            this.fieldUn1.Visible = false;
            // 
            // fieldQuantidade1
            // 
            this.fieldQuantidade1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantidade1.AreaIndex = 0;
            this.fieldQuantidade1.Caption = "Quantidade";
            this.fieldQuantidade1.CellFormat.FormatString = "N2";
            this.fieldQuantidade1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuantidade1.FieldName = "Quantidade";
            this.fieldQuantidade1.Name = "fieldQuantidade1";
            this.fieldQuantidade1.Visible = false;
            // 
            // fieldValor1
            // 
            this.fieldValor1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValor1.AreaIndex = 0;
            this.fieldValor1.Caption = "Valor";
            this.fieldValor1.FieldName = "Valor";
            this.fieldValor1.Name = "fieldValor1";
            this.fieldValor1.SortBySummaryInfo.Field = this.fieldDescricao1;
            this.fieldValor1.SortBySummaryInfo.FieldName = "Descricao";
            this.fieldValor1.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Value;
            // 
            // fieldNfData
            // 
            this.fieldNfData.AreaIndex = 0;
            this.fieldNfData.Caption = "Data";
            this.fieldNfData.FieldName = "Nf.Data";
            this.fieldNfData.Name = "fieldNfData";
            this.fieldNfData.Visible = false;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Número";
            this.pivotGridField1.FieldName = "Nf.Numero";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Visible = false;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "Emitente";
            this.pivotGridField3.FieldName = "Nf.Emitente.Nome";
            this.pivotGridField3.Name = "pivotGridField3";
            this.pivotGridField3.Visible = false;
            this.pivotGridField3.Width = 673;
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.Caption = "cst";
            this.pivotGridField4.FieldName = "ICMS.Cst";
            this.pivotGridField4.Name = "pivotGridField4";
            this.pivotGridField4.Visible = false;
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.AreaIndex = 0;
            this.pivotGridField5.Caption = "Bc Icms";
            this.pivotGridField5.FieldName = "ICMS.Bc";
            this.pivotGridField5.Name = "pivotGridField5";
            this.pivotGridField5.Visible = false;
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.AreaIndex = 0;
            this.pivotGridField6.Caption = "Alq Icms";
            this.pivotGridField6.FieldName = "ICMS.Alq";
            this.pivotGridField6.Name = "pivotGridField6";
            this.pivotGridField6.Visible = false;
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.AreaIndex = 0;
            this.pivotGridField7.Caption = "Icms";
            this.pivotGridField7.FieldName = "ICMS.Imp";
            this.pivotGridField7.Name = "pivotGridField7";
            this.pivotGridField7.Visible = false;
            // 
            // fieldCFOP
            // 
            this.fieldCFOP.AreaIndex = 2;
            this.fieldCFOP.Caption = "CFOP";
            this.fieldCFOP.FieldName = "CFOP";
            this.fieldCFOP.Name = "fieldCFOP";
            this.fieldCFOP.Visible = false;
            // 
            // pivotGridField8
            // 
            this.pivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField8.AreaIndex = 0;
            this.pivotGridField8.Caption = "Mês";
            this.pivotGridField8.FieldName = "Nf.Competencia";
            this.pivotGridField8.Name = "pivotGridField8";
            this.pivotGridField8.Width = 113;
            // 
            // pivotGridField9
            // 
            this.pivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField9.AreaIndex = 1;
            this.pivotGridField9.Caption = "%";
            this.pivotGridField9.CellFormat.FormatString = "P";
            this.pivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField9.FieldName = "Valor";
            this.pivotGridField9.Name = "pivotGridField9";
            this.pivotGridField9.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn;
            this.pivotGridField9.Visible = false;
            // 
            // pivotGridField10
            // 
            this.pivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField10.AreaIndex = 1;
            this.pivotGridField10.Caption = "Destinatário";
            this.pivotGridField10.FieldName = "Nf.Destinatario.Nome";
            this.pivotGridField10.Name = "pivotGridField10";
            this.pivotGridField10.UnboundFieldName = "pivotGridField10";
            this.pivotGridField10.Visible = false;
            // 
            // fieldCategoria
            // 
            this.fieldCategoria.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoria.AreaIndex = 0;
            this.fieldCategoria.FieldName = "Categoria";
            this.fieldCategoria.Name = "fieldCategoria";
            this.fieldCategoria.Width = 320;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 647);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1185, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnCarregar,
            this.BtnFornecedores,
            this.BtnProdutos,
            this.BtnExportar,
            this.BtnVerErros,
            this.BtnCategorias,
            this.BtnICMS});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageGerar});
            this.ribbonControl1.Size = new System.Drawing.Size(1185, 144);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.Caption = "Carregar";
            this.BtnCarregar.Id = 1;
            this.BtnCarregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnCarregar.ImageOptions.SvgImage")));
            this.BtnCarregar.Name = "BtnCarregar";
            this.BtnCarregar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCarregar_ItemClick);
            // 
            // BtnFornecedores
            // 
            this.BtnFornecedores.Caption = "Fornecedores";
            this.BtnFornecedores.Id = 2;
            this.BtnFornecedores.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnFornecedores.ImageOptions.SvgImage")));
            this.BtnFornecedores.Name = "BtnFornecedores";
            this.BtnFornecedores.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFornecedores_ItemClick);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Caption = "Produtos";
            this.BtnProdutos.Id = 3;
            this.BtnProdutos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnProdutos.ImageOptions.SvgImage")));
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnProdutos_ItemClick);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Caption = "Exportar";
            this.BtnExportar.Id = 4;
            this.BtnExportar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportar.ImageOptions.SvgImage")));
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportar_ItemClick);
            // 
            // BtnVerErros
            // 
            this.BtnVerErros.Caption = "Erros Arquivos";
            this.BtnVerErros.Id = 5;
            this.BtnVerErros.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnVerErros.ImageOptions.SvgImage")));
            this.BtnVerErros.Name = "BtnVerErros";
            this.BtnVerErros.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnVerErros_ItemClick);
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.Caption = "Categorias";
            this.BtnCategorias.Id = 6;
            this.BtnCategorias.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnCategorias.ImageOptions.SvgImage")));
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCategorias_ItemClick);
            // 
            // ribbonPageGerar
            // 
            this.ribbonPageGerar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupGerar,
            this.ribbonPageGroupNotifications});
            this.ribbonPageGerar.Name = "ribbonPageGerar";
            this.ribbonPageGerar.Text = "Compras";
            // 
            // ribbonPageGroupGerar
            // 
            this.ribbonPageGroupGerar.ItemLinks.Add(this.BtnCarregar, true);
            this.ribbonPageGroupGerar.ItemLinks.Add(this.BtnFornecedores, true);
            this.ribbonPageGroupGerar.ItemLinks.Add(this.BtnProdutos);
            this.ribbonPageGroupGerar.ItemLinks.Add(this.BtnCategorias);
            this.ribbonPageGroupGerar.ItemLinks.Add(this.BtnICMS, true);
            this.ribbonPageGroupGerar.ItemLinks.Add(this.BtnExportar, true);
            this.ribbonPageGroupGerar.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroupGerar.Name = "ribbonPageGroupGerar";
            // 
            // ribbonPageGroupNotifications
            // 
            this.ribbonPageGroupNotifications.ItemLinks.Add(this.BtnVerErros);
            this.ribbonPageGroupNotifications.Name = "ribbonPageGroupNotifications";
            this.ribbonPageGroupNotifications.Text = "Notificações";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 670);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1185, 32);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // BtnICMS
            // 
            this.BtnICMS.Caption = "ICMS";
            this.BtnICMS.Id = 7;
            this.BtnICMS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnICMS.ImageOptions.SvgImage")));
            this.BtnICMS.Name = "BtnICMS";
            this.BtnICMS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnICMS_ItemClick);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 702);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmCompras";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource nFBindingSource;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCodigo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDescricao1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNCM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUn1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantidade1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNfData;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCFOP;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageGerar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupGerar;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem BtnCarregar;
        private DevExpress.XtraBars.BarButtonItem BtnFornecedores;
        private DevExpress.XtraBars.BarButtonItem BtnProdutos;
        private DevExpress.XtraBars.BarButtonItem BtnExportar;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField9;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField10;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoria;
        private DevExpress.XtraBars.BarButtonItem BtnVerErros;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNotifications;
        private DevExpress.XtraBars.BarButtonItem BtnCategorias;
        private DevExpress.XtraBars.BarButtonItem BtnICMS;
    }
}

