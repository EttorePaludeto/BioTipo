
namespace AnaliseFinanceira
{
    partial class FrmExtratoBancario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExtratoBancario));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnCarregar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSantader = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBB = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSantander2 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnConciliacao = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMaquininhas = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.BtnAriane = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEmerson = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAnaFlavia = new DevExpress.XtraBars.BarButtonItem();
            this.BtnElizabeth = new DevExpress.XtraBars.BarButtonItem();
            this.BtnJoao = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEnio = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMariaOdila = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBenedita = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCheques = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCaixa = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupBancos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.BtnCarregar,
            this.BtnSantader,
            this.BtnBB,
            this.barButtonItem1,
            this.btnSantander2,
            this.BtnConciliacao,
            this.BtnMaquininhas,
            this.BtnCheques,
            this.BtnCaixa,
            this.BtnAnaFlavia,
            this.BtnBenedita,
            this.BtnElizabeth,
            this.BtnEnio,
            this.BtnJoao,
            this.BtnMariaOdila,
            this.BtnAriane,
            this.BtnEmerson});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1159, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.Caption = "Carregar";
            this.BtnCarregar.Id = 1;
            this.BtnCarregar.Name = "BtnCarregar";
            // 
            // BtnSantader
            // 
            this.BtnSantader.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.BtnSantader.Caption = "C/C 11523";
            this.BtnSantader.GroupIndex = 1;
            this.BtnSantader.Id = 3;
            this.BtnSantader.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSantader.ImageOptions.Image")));
            this.BtnSantader.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.BtnSantader.Name = "BtnSantader";
            this.BtnSantader.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnSantader.Tag = 1;
            this.BtnSantader.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // BtnBB
            // 
            this.BtnBB.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.BtnBB.Caption = "C/C 16940-4";
            this.BtnBB.GroupIndex = 1;
            this.BtnBB.Id = 4;
            this.BtnBB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnBB.ImageOptions.SvgImage")));
            this.BtnBB.Name = "BtnBB";
            this.BtnBB.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnBB.Tag = 4;
            this.BtnBB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItem1.Caption = "C/C 63100-8";
            this.barButtonItem1.GroupIndex = 1;
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Tag = 3;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // btnSantander2
            // 
            this.btnSantander2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.btnSantander2.Caption = "C/C 11530";
            this.btnSantander2.GroupIndex = 1;
            this.btnSantander2.Id = 6;
            this.btnSantander2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSantander2.ImageOptions.Image")));
            this.btnSantander2.Name = "btnSantander2";
            this.btnSantander2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSantander2.Tag = 2;
            this.btnSantander2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // BtnConciliacao
            // 
            this.BtnConciliacao.Caption = "Conciliação";
            this.BtnConciliacao.Id = 7;
            this.BtnConciliacao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnConciliacao.ImageOptions.SvgImage")));
            this.BtnConciliacao.Name = "BtnConciliacao";
            this.BtnConciliacao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnConciliacao_ItemClick);
            // 
            // BtnMaquininhas
            // 
            this.BtnMaquininhas.ActAsDropDown = true;
            this.BtnMaquininhas.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.BtnMaquininhas.Caption = "Maquininhas";
            this.BtnMaquininhas.DropDownControl = this.popupMenu1;
            this.BtnMaquininhas.GroupIndex = 1;
            this.BtnMaquininhas.Id = 8;
            this.BtnMaquininhas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnMaquininhas.ImageOptions.SvgImage")));
            this.BtnMaquininhas.Name = "BtnMaquininhas";
            this.BtnMaquininhas.Tag = 7;
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.BtnAriane);
            this.popupMenu1.ItemLinks.Add(this.BtnEmerson);
            this.popupMenu1.ItemLinks.Add(this.BtnAnaFlavia);
            this.popupMenu1.ItemLinks.Add(this.BtnElizabeth);
            this.popupMenu1.ItemLinks.Add(this.BtnJoao);
            this.popupMenu1.ItemLinks.Add(this.BtnEnio);
            this.popupMenu1.ItemLinks.Add(this.BtnMariaOdila);
            this.popupMenu1.ItemLinks.Add(this.BtnBenedita);
            this.popupMenu1.ItemLinks.Add(this.BtnElizabeth);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // BtnAriane
            // 
            this.BtnAriane.Caption = "Ariane";
            this.BtnAriane.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.BtnAriane.Id = 19;
            this.BtnAriane.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAriane.ImageOptions.SvgImage")));
            this.BtnAriane.Name = "BtnAriane";
            this.BtnAriane.Tag = 20;
            this.BtnAriane.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // BtnEmerson
            // 
            this.BtnEmerson.Caption = "Emerson";
            this.BtnEmerson.Id = 20;
            this.BtnEmerson.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnEmerson.ImageOptions.SvgImage")));
            this.BtnEmerson.Name = "BtnEmerson";
            this.BtnEmerson.Tag = 19;
            this.BtnEmerson.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // BtnAnaFlavia
            // 
            this.BtnAnaFlavia.Caption = "Ana Flávia";
            this.BtnAnaFlavia.Id = 13;
            this.BtnAnaFlavia.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAnaFlavia.ImageOptions.SvgImage")));
            this.BtnAnaFlavia.Name = "BtnAnaFlavia";
            this.BtnAnaFlavia.Tag = 14;
            this.BtnAnaFlavia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // BtnElizabeth
            // 
            this.BtnElizabeth.Caption = "Elizabeth";
            this.BtnElizabeth.Id = 15;
            this.BtnElizabeth.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnElizabeth.ImageOptions.SvgImage")));
            this.BtnElizabeth.Name = "BtnElizabeth";
            this.BtnElizabeth.Tag = 16;
            this.BtnElizabeth.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // BtnJoao
            // 
            this.BtnJoao.Caption = "João";
            this.BtnJoao.Id = 17;
            this.BtnJoao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnJoao.ImageOptions.SvgImage")));
            this.BtnJoao.Name = "BtnJoao";
            this.BtnJoao.Tag = 18;
            this.BtnJoao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // BtnEnio
            // 
            this.BtnEnio.Caption = "Enio";
            this.BtnEnio.Id = 16;
            this.BtnEnio.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnEnio.ImageOptions.SvgImage")));
            this.BtnEnio.Name = "BtnEnio";
            this.BtnEnio.Tag = 17;
            this.BtnEnio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // BtnMariaOdila
            // 
            this.BtnMariaOdila.Caption = "Maria Odila";
            this.BtnMariaOdila.Id = 18;
            this.BtnMariaOdila.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnMariaOdila.ImageOptions.SvgImage")));
            this.BtnMariaOdila.Name = "BtnMariaOdila";
            this.BtnMariaOdila.Tag = 13;
            this.BtnMariaOdila.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // BtnBenedita
            // 
            this.BtnBenedita.Caption = "Benedita";
            this.BtnBenedita.Id = 14;
            this.BtnBenedita.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnBenedita.ImageOptions.SvgImage")));
            this.BtnBenedita.Name = "BtnBenedita";
            this.BtnBenedita.Tag = 15;
            this.BtnBenedita.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // BtnCheques
            // 
            this.BtnCheques.Caption = "Cheques";
            this.BtnCheques.GroupIndex = 1;
            this.BtnCheques.Id = 9;
            this.BtnCheques.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnCheques.ImageOptions.SvgImage")));
            this.BtnCheques.Name = "BtnCheques";
            this.BtnCheques.Tag = 12;
            this.BtnCheques.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // BtnCaixa
            // 
            this.BtnCaixa.Caption = "Caixa";
            this.BtnCaixa.GroupIndex = 1;
            this.BtnCaixa.Id = 10;
            this.BtnCaixa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnCaixa.ImageOptions.SvgImage")));
            this.BtnCaixa.Name = "BtnCaixa";
            this.BtnCaixa.Tag = 11;
            this.BtnCaixa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CarregarBanco);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupBancos,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Extratos";
            // 
            // ribbonPageGroupBancos
            // 
            this.ribbonPageGroupBancos.ItemLinks.Add(this.BtnSantader);
            this.ribbonPageGroupBancos.ItemLinks.Add(this.BtnBB);
            this.ribbonPageGroupBancos.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroupBancos.ItemLinks.Add(this.btnSantander2);
            this.ribbonPageGroupBancos.ItemLinks.Add(this.BtnMaquininhas);
            this.ribbonPageGroupBancos.ItemLinks.Add(this.BtnCheques);
            this.ribbonPageGroupBancos.ItemLinks.Add(this.BtnCaixa);
            this.ribbonPageGroupBancos.Name = "ribbonPageGroupBancos";
            this.ribbonPageGroupBancos.Text = "Bancos";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnConciliacao);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Controles";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 774);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1159, 32);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridControl1.Location = new System.Drawing.Point(0, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1159, 630);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // FrmExtratoBancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 806);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "FrmExtratoBancario";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Extratos";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BtnCarregar;
        private DevExpress.XtraBars.BarButtonItem BtnSantader;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBancos;
        private DevExpress.XtraBars.BarButtonItem BtnBB;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnSantander2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem BtnConciliacao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnMaquininhas;
        private DevExpress.XtraBars.BarButtonItem BtnCheques;
        private DevExpress.XtraBars.BarButtonItem BtnCaixa;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem BtnAnaFlavia;
        private DevExpress.XtraBars.BarButtonItem BtnBenedita;
        private DevExpress.XtraBars.BarButtonItem BtnAriane;
        private DevExpress.XtraBars.BarButtonItem BtnEmerson;
        private DevExpress.XtraBars.BarButtonItem BtnElizabeth;
        private DevExpress.XtraBars.BarButtonItem BtnEnio;
        private DevExpress.XtraBars.BarButtonItem BtnJoao;
        private DevExpress.XtraBars.BarButtonItem BtnMariaOdila;
    }
}