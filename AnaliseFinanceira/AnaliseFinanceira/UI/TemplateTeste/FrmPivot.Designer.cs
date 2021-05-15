
namespace AnaliseFinanceira.UI.TemplateTeste
{
    partial class FrmPivot
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.colArea = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.colArea});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(800, 450);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // colArea
            // 
            this.colArea.Appearance.Cell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colArea.Appearance.Cell.Options.UseBackColor = true;
            this.colArea.Appearance.Cell.Options.UseTextOptions = true;
            this.colArea.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArea.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.colArea.Appearance.Header.Options.UseFont = true;
            this.colArea.Appearance.Header.Options.UseTextOptions = true;
            this.colArea.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArea.Appearance.Value.ForeColor = System.Drawing.Color.Blue;
            this.colArea.Appearance.Value.Options.UseForeColor = true;
            this.colArea.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colArea.AreaIndex = 0;
            this.colArea.CellFormat.FormatString = "n2";
            this.colArea.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colArea.Name = "colArea";
            // 
            // FrmPivot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "FrmPivot";
            this.Text = "FrmPivot";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField colArea;
    }
}