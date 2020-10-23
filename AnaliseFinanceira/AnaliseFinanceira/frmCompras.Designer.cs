namespace AnaliseFinanceira
{
    partial class frmCompras
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldCodigo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDescricao1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNCM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCEST1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUn1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantidade1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNfData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField9 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField10 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.carregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlNFeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.fieldCEST1,
            this.fieldUn1,
            this.fieldQuantidade1,
            this.fieldValor1,
            this.fieldNfData,
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField5,
            this.pivotGridField6,
            this.pivotGridField7,
            this.pivotGridField8,
            this.pivotGridField9,
            this.pivotGridField10});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 24);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(863, 490);
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
            this.fieldCodigo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCodigo1.AreaIndex = 3;
            this.fieldCodigo1.Caption = "Codigo";
            this.fieldCodigo1.FieldName = "Codigo";
            this.fieldCodigo1.Name = "fieldCodigo1";
            // 
            // fieldDescricao1
            // 
            this.fieldDescricao1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDescricao1.AreaIndex = 4;
            this.fieldDescricao1.Caption = "Descricao";
            this.fieldDescricao1.FieldName = "Descricao";
            this.fieldDescricao1.Name = "fieldDescricao1";
            // 
            // fieldNCM1
            // 
            this.fieldNCM1.AreaIndex = 0;
            this.fieldNCM1.Caption = "NCM";
            this.fieldNCM1.FieldName = "NCM";
            this.fieldNCM1.Name = "fieldNCM1";
            // 
            // fieldCEST1
            // 
            this.fieldCEST1.AreaIndex = 1;
            this.fieldCEST1.Caption = "CEST";
            this.fieldCEST1.FieldName = "CEST";
            this.fieldCEST1.Name = "fieldCEST1";
            // 
            // fieldUn1
            // 
            this.fieldUn1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldUn1.AreaIndex = 5;
            this.fieldUn1.Caption = "Un";
            this.fieldUn1.FieldName = "Un";
            this.fieldUn1.Name = "fieldUn1";
            // 
            // fieldQuantidade1
            // 
            this.fieldQuantidade1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantidade1.AreaIndex = 0;
            this.fieldQuantidade1.Caption = "Quantidade";
            this.fieldQuantidade1.FieldName = "Quantidade";
            this.fieldQuantidade1.Name = "fieldQuantidade1";
            // 
            // fieldValor1
            // 
            this.fieldValor1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValor1.AreaIndex = 1;
            this.fieldValor1.Caption = "Valor";
            this.fieldValor1.FieldName = "Valor";
            this.fieldValor1.Name = "fieldValor1";
            // 
            // fieldNfData
            // 
            this.fieldNfData.AreaIndex = 2;
            this.fieldNfData.Caption = "Data";
            this.fieldNfData.FieldName = "Nf.Data";
            this.fieldNfData.Name = "fieldNfData";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Número";
            this.pivotGridField1.FieldName = "Nf.Numero";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 1;
            this.pivotGridField2.Caption = "Destinatário";
            this.pivotGridField2.FieldName = "Nf.Destinatario.CNPJ";
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 2;
            this.pivotGridField3.Caption = "Emitente";
            this.pivotGridField3.FieldName = "Nf.Emitente.Nome";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.AreaIndex = 3;
            this.pivotGridField4.Caption = "cst";
            this.pivotGridField4.FieldName = "ICMS.cst";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.AreaIndex = 4;
            this.pivotGridField5.Caption = "Bc Icms";
            this.pivotGridField5.FieldName = "ICMS.bc";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.AreaIndex = 5;
            this.pivotGridField6.Caption = "Alq Icms";
            this.pivotGridField6.FieldName = "ICMS.alq";
            this.pivotGridField6.Name = "pivotGridField6";
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.AreaIndex = 6;
            this.pivotGridField7.Caption = "Icms";
            this.pivotGridField7.FieldName = "ICMS.imp";
            this.pivotGridField7.Name = "pivotGridField7";
            // 
            // pivotGridField8
            // 
            this.pivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField8.AreaIndex = 0;
            this.pivotGridField8.Caption = "Bc Iss";
            this.pivotGridField8.FieldName = "ISS.bc";
            this.pivotGridField8.Name = "pivotGridField8";
            // 
            // pivotGridField9
            // 
            this.pivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField9.AreaIndex = 1;
            this.pivotGridField9.Caption = "Alq Iss";
            this.pivotGridField9.FieldName = "ISS.alq";
            this.pivotGridField9.Name = "pivotGridField9";
            // 
            // pivotGridField10
            // 
            this.pivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField10.AreaIndex = 2;
            this.pivotGridField10.Caption = "Iss";
            this.pivotGridField10.FieldName = "ISS.imp";
            this.pivotGridField10.Name = "pivotGridField10";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 491);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(863, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // carregarToolStripMenuItem
            // 
            this.carregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xmlNFeToolStripMenuItem,
            this.cFeToolStripMenuItem});
            this.carregarToolStripMenuItem.Name = "carregarToolStripMenuItem";
            this.carregarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.carregarToolStripMenuItem.Text = "Carregar";
            // 
            // xmlNFeToolStripMenuItem
            // 
            this.xmlNFeToolStripMenuItem.Name = "xmlNFeToolStripMenuItem";
            this.xmlNFeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.xmlNFeToolStripMenuItem.Text = "Xml NFe";
            this.xmlNFeToolStripMenuItem.Click += new System.EventHandler(this.xmlNFeToolStripMenuItem_Click);
            // 
            // cFeToolStripMenuItem
            // 
            this.cFeToolStripMenuItem.Name = "cFeToolStripMenuItem";
            this.cFeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cFeToolStripMenuItem.Text = "CFe";
            this.cFeToolStripMenuItem.Click += new System.EventHandler(this.cFeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 514);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCompras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private DevExpress.XtraPivotGrid.PivotGridField fieldCEST1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUn1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantidade1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNfData;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField9;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem carregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlNFeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cFeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

