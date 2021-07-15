using AnaliseFinanceira.DAL;
using AnaliseFinanceira.UI.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraPivotGrid;
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
    public partial class FrmResultados : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly DataAccess dataAccess;
        public FrmResultados()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void BtnCarregar_ItemClick(object sender, ItemClickEventArgs e)
        {

            var table = dataAccess.ExecutaConsulta(
             $@"DECLARE @DT_INI AS DATE = '2021-01-01'
            DECLARE @DT_FIM AS DATE = '2021-04-30'
            select y.DRE, CAST(MONTH(y.Data) AS VARCHAR(2)) + '/' + CAST(YEAR(y.Data) AS VARCHAR(4)) AS Mes, y.Conta, SUM(y.ValorContabil) Valor from
            (
            select d.id dId, d.Data, p.Id, p.Conta, p.DRE, d.ValorContabil  as ValorContabil from ExtratoConciliado as d inner join PlanoContas as p on d.DebitoId = p.Id 
            where d.Data between @DT_INI and @DT_FIM and p.DRE <> 'Resultado'
            union
            select d.id, d.Data, p.Id, p.Conta, p.DRE, d.ValorContabil * -1 from ExtratoConciliado as d inner join PlanoContas as p on d.CreditoId = p.Id 
            where d.Data between @DT_INI and @DT_FIM and p.DRE <> 'Resultado'
            ) as y
            group by y.Conta, y.DRE, CAST(MONTH(y.Data) AS VARCHAR(2)) + '/' + CAST(YEAR(y.Data) AS VARCHAR(4))
            order by Y.DRE"
            );

          
            pivotGridControl1.Fields.Clear();
            pivotGridControl1.Fields.Add(PivotColumnTemplate.PivotString("DRE", 0));

            pivotGridControl1.Fields.Add(PivotColumnTemplate.PivotString("Mes", 0, "Mês", DevExpress.XtraPivotGrid.PivotArea.ColumnArea, DevExpress.Utils.HorzAlignment.Center).AppearanceValue(Color.Yellow, Color.Empty, FontStyle.Bold, DevExpress.Utils.HorzAlignment.Center));
            pivotGridControl1.Fields.Add(PivotColumnTemplate.PivotString("Conta", 1));
            pivotGridControl1.Fields.Add(PivotColumnTemplate.PivotNumero("Valor", 0));
            pivotGridControl1.DataSource = table;
            pivotGridControl1.BestFit();
        }
    }
}