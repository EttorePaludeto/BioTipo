using AnaliseFinanceira.DAL;
using AnaliseFinanceira.UI.Controls;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseFinanceira.UI
{
    public partial class FrmDiario : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly DataAccess dataAccess;
        public FrmDiario()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void BtnCarregar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var table = dataAccess.ExecutaConsulta(
          $@"Select B.Banco, EC.Id, EC.Data, EC.Historico, CONCAT(Deb.Id,' ',Deb.Conta) Debito, CONCAT(Cre.Id,' ',Cre.Conta) Credito,
	        EC.Valor from ExtratoConciliado EC inner join
			  Bancos B on EC.BancoId = B.Id inner join
			  PlanoContas Deb on EC.DebitoId = Deb.Id inner join
			  PlanoContas Cre on Ec.CreditoId = Cre.id"

         );
            
            gridControl1.DataSource = table;
      
            //pivotGridControl1.Fields.Clear();
            //pivotGridControl1.Fields.Add(PivotColumnTemplate.PivotString("Banco", 0));

            //pivotGridControl1.Fields.Add(PivotColumnTemplate.PivotString("Data", 1, "Data", DevExpress.XtraPivotGrid.PivotArea.RowArea, DevExpress.Utils.HorzAlignment.Center).AppearanceValue(Color.Yellow, Color.Empty, FontStyle.Bold, DevExpress.Utils.HorzAlignment.Center));
            //pivotGridControl1.Fields.Add(PivotColumnTemplate.PivotString("Historico", 2,"Histórico"));
            //pivotGridControl1.Fields.Add(PivotColumnTemplate.PivotString("Debito", 3, "Débito"));
            //pivotGridControl1.Fields.Add(PivotColumnTemplate.PivotString("Credito", 4, "Crédito"));
            //pivotGridControl1.Fields.Add(PivotColumnTemplate.PivotNumero("Valor", 0));
            //pivotGridControl1.DataSource = table;
            //pivotGridControl1.BestFit();

        }

        private void BtnRecarregar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnCarregar_ItemClick(sender, e);
            gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridView1.Columns.Clear();
            gridView1.Columns.Add(GridColumnTemplate.ColNumero("Banco", 0, null, DevExpress.Utils.HorzAlignment.Center));
            gridView1.Columns.Add(GridColumnTemplate.ColData("Data", 1));
            gridView1.Columns.Add(GridColumnTemplate.ColString("Historico", 2));
            gridView1.Columns.Add(GridColumnTemplate.ColString("Debito", 3));
            gridView1.Columns.Add(GridColumnTemplate.ColString("Credito", 4));
            gridView1.Columns.Add(GridColumnTemplate.ColNumero("Valor", 5, null, DevExpress.Utils.HorzAlignment.Default, null, null, DisplayFormatNumber.n2));

            gridView1.Columns.Add(GridColumnTemplate.ColNumero("Id", 0, null, DevExpress.Utils.HorzAlignment.Center));
            gridView1.BestFitColumns();
        }
    }
}