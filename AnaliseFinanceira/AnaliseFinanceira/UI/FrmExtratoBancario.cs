using AnaliseFinanceira.DAL;
using AnaliseFinanceira.UI.Controls;
using DevExpress.XtraBars;
using System.Drawing;

namespace AnaliseFinanceira
{
    public partial class FrmExtratoBancario : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly DataAccess dataAccess;
        private int BancoId { get; set; }
        public FrmExtratoBancario()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
        }
     
        private void CarregarBanco(object sender, ItemClickEventArgs e)
        {
            BancoId = (int)e.Item.Tag;

            var table = dataAccess.ExecutaConsulta(
            $@"
                Declare @BancoId int = {BancoId}
                select E.Id, E.Data, E.Historico, E.Valor, Sum(E.Valor) Over (Order By E.Data, E.Id) as Saldo from Extrato E
                Where E.BancoId = @BancoId
                Group by E.Id, E.Data, E.Historico, E.Valor"
             );

            gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridControl1.DataSource = table;
            gridView1.Columns.Clear();
            gridView1.Columns.Add(GridColumnTemplate.ColNumero("Id", 0, null, DevExpress.Utils.HorzAlignment.Center));
            gridView1.Columns.Add(GridColumnTemplate.ColData("Data", 1));
            gridView1.Columns.Add(GridColumnTemplate.ColString("Historico", 2));
            gridView1.Columns.Add(GridColumnTemplate.ColNumero("Valor", 3,null, DevExpress.Utils.HorzAlignment.Default,null, null, DisplayFormatNumber.n2));
            gridView1.Columns.Add(GridColumnTemplate.ColNumero("Saldo", 4, null, DevExpress.Utils.HorzAlignment.Default, BackColor = Color.FromArgb(66,135,245),  ForeColor = Color.White, DisplayFormatNumber.n2));
            gridView1.BestFitColumns();
        }

        private void BtnConciliacao_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (BancoId == 0) return;
            
            var table = dataAccess.ExecutaConsulta(
            $@"
                Declare @BancoId int = {BancoId}
                select E.Id, E.Data, E.Historico HistExtrato, E.Valor Extrato, EC.Historico HistConciliacao, EC.Valor Conciliacao,
	            E.Valor - Sum(EC.Valor) Over (Partition by EC.ExtratoId) Diferenca
                from Extrato E left join
	            ExtratoConciliado EC on E.Id = EC.ExtratoId
                Where E.BancoId = @BancoId"
             );

            gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridControl1.DataSource = table;
            gridView1.Columns.Clear();
            gridView1.Columns.Add(GridColumnTemplate.ColNumero("Id", 0, null, DevExpress.Utils.HorzAlignment.Center));
            gridView1.Columns.Add(GridColumnTemplate.ColData("Data", 1));
            gridView1.Columns.Add(GridColumnTemplate.ColString("HistExtrato", 2,"Histórico Extrato"));
            gridView1.Columns.Add(GridColumnTemplate.ColNumero("Extrato", 3, "Valor Extrato", DevExpress.Utils.HorzAlignment.Default, null, null, DisplayFormatNumber.n2));
            gridView1.Columns.Add(GridColumnTemplate.ColString("HistConciliacao", 4, "Histórico Conciliação"));
            gridView1.Columns.Add(GridColumnTemplate.ColNumero("Conciliacao", 5, "Valor Conciliado", DevExpress.Utils.HorzAlignment.Default, null, null, DisplayFormatNumber.n2));
            gridView1.Columns.Add(GridColumnTemplate.ColNumero("Diferenca", 6, "Valor Diferença", DevExpress.Utils.HorzAlignment.Default, BackColor = Color.FromArgb(245, 108, 66), ForeColor = Color.White, DisplayFormatNumber.n2));
            gridView1.BestFitColumns();
        }
    }
}