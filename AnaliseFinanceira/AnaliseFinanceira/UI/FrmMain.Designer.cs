
namespace AnaliseFinanceira.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnCompras = new DevExpress.XtraBars.BarButtonItem();
            this.BtnVendas = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExtratos = new DevExpress.XtraBars.BarButtonItem();
            this.BtnResultado = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDiario = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGeral = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupAnalises = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupFinanceiro = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.BtnCompras,
            this.BtnVendas,
            this.BtnExtratos,
            this.BtnResultado,
            this.BtnDiario});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageGeral});
            this.ribbon.Size = new System.Drawing.Size(1242, 163);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // BtnCompras
            // 
            this.BtnCompras.Caption = "Compras";
            this.BtnCompras.Id = 2;
            this.BtnCompras.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnCompras.ImageOptions.SvgImage")));
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCompras_ItemClick);
            // 
            // BtnVendas
            // 
            this.BtnVendas.Caption = "Vendas";
            this.BtnVendas.Id = 3;
            this.BtnVendas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnVendas.ImageOptions.SvgImage")));
            this.BtnVendas.Name = "BtnVendas";
            this.BtnVendas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnVendas_ItemClick);
            // 
            // BtnExtratos
            // 
            this.BtnExtratos.Caption = "Extratos";
            this.BtnExtratos.Id = 4;
            this.BtnExtratos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExtratos.ImageOptions.SvgImage")));
            this.BtnExtratos.Name = "BtnExtratos";
            this.BtnExtratos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExtratos_ItemClick);
            // 
            // BtnResultado
            // 
            this.BtnResultado.Caption = "Resultados";
            this.BtnResultado.Id = 5;
            this.BtnResultado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnResultado.ImageOptions.SvgImage")));
            this.BtnResultado.Name = "BtnResultado";
            this.BtnResultado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnResultado_ItemClick);
            // 
            // BtnDiario
            // 
            this.BtnDiario.Caption = "Diário";
            this.BtnDiario.Id = 6;
            this.BtnDiario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnDiario.ImageOptions.SvgImage")));
            this.BtnDiario.Name = "BtnDiario";
            this.BtnDiario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDiario_ItemClick);
            // 
            // ribbonPageGeral
            // 
            this.ribbonPageGeral.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupAnalises,
            this.ribbonPageGroupFinanceiro});
            this.ribbonPageGeral.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGeral.ImageOptions.SvgImage")));
            this.ribbonPageGeral.Name = "ribbonPageGeral";
            // 
            // ribbonPageGroupAnalises
            // 
            this.ribbonPageGroupAnalises.ItemLinks.Add(this.BtnCompras);
            this.ribbonPageGroupAnalises.ItemLinks.Add(this.BtnVendas, true);
            this.ribbonPageGroupAnalises.Name = "ribbonPageGroupAnalises";
            this.ribbonPageGroupAnalises.Text = "Análises Econômicas";
            // 
            // ribbonPageGroupFinanceiro
            // 
            this.ribbonPageGroupFinanceiro.ItemLinks.Add(this.BtnExtratos);
            this.ribbonPageGroupFinanceiro.ItemLinks.Add(this.BtnResultado);
            this.ribbonPageGroupFinanceiro.ItemLinks.Add(this.BtnDiario);
            this.ribbonPageGroupFinanceiro.Name = "ribbonPageGroupFinanceiro";
            this.ribbonPageGroupFinanceiro.Text = "Financeiro";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 801);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1242, 32);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 833);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageGeral;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAnalises;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BtnCompras;
        private DevExpress.XtraBars.BarButtonItem BtnVendas;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem BtnExtratos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupFinanceiro;
        private DevExpress.XtraBars.BarButtonItem BtnResultado;
        private DevExpress.XtraBars.BarButtonItem BtnDiario;
    }
}