using AnaliseFinanceira.DAL;
using AnaliseFinanceira.Models;
using ClosedXML.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AnaliseFinanceira.UI
{
    public partial class FrmImportarExtrato : Form
    {
        private readonly DataAccess ctxADO;
        private BindingList<ExtratoImportado> listExtratoImportado;

        public FrmImportarExtrato()
        {
            InitializeComponent();
            ctxADO = new DataAccess();
          
            gridView1.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Append;
            listExtratoImportado = new BindingList<ExtratoImportado>();
           
            gridControl1.DataSource = listExtratoImportado;
           
        }
               
        private void gridControl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                gridView1.DeleteSelectedRows();
        }

        private void BtnSalvarConciliacao_Click(object sender, EventArgs e)
        {
            var listaExtrato = listExtratoImportado.ToExtrato();
            ctxADO.InsertBulkSql(listaExtrato.AsDataTable(), "Extrato");
        }
    }

    public class ExtratoImportado : INotifyPropertyChanged
    {
        private int seqId;
        public int SeqId { get { return seqId; } set { seqId = value; OnPropertyChanged("seqId"); } }
        private int bancoId;
        public int BancoId { get { return bancoId; } set { bancoId = value; OnPropertyChanged("BancoId"); } }
        private DateTime data;
        public DateTime Data { get { return data; } set { data = value; OnPropertyChanged("Data"); } }
        private int debitoId;
        public int DebitoId { get { return debitoId; } set { debitoId = value; OnPropertyChanged("DebitoId"); } }
        private int creditoId;
        public int CreditoId { get { return creditoId; } set { creditoId = value; OnPropertyChanged("CreditoId"); } }
        private string historico = string.Empty;
        public string Historico { get { return historico; } set { historico = value; OnPropertyChanged("Historico"); } }
        private decimal valor;
        public decimal Valor { get { return valor; } set { valor = value; OnPropertyChanged("Valor"); } }

        public ExtratoImportado()
        {
            this.seqId = 0;
            this.BancoId = 0;
            this.Data = DateTime.MinValue;
            this.DebitoId = 0;
            this.CreditoId = 0;
            this.Historico = null;
            this.Valor = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    public static class Map
    {
        public static List<Extrato> ToExtrato(this BindingList<ExtratoImportado> importado)
        {
            var listExtrato = new List<Extrato>();

            foreach (var item in importado)
            {
                listExtrato.Add(new Extrato(
                    id: 0,
                    bancoId: item.BancoId,
                    data: item.Data,
                    historico: item.Historico,
                    valor: item.Valor));
            }

            return listExtrato;
        }
    }

    public static class ADOExtentions
    {
        public static DataTable AsDataTable<T>(this IEnumerable<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
    
    public static class ConvertTypes
    {
        public static decimal ToDecimalN2(this object valor)
        {
            decimal retorno = Convert.ToDecimal(valor.ToString());
            retorno.ToString("N2");
            return Decimal.Round(retorno, 2);
        }

        public static decimal ToModulo(this object valor)
        {
            decimal retorno = Convert.ToDecimal(valor.ToString());
            return Math.Abs(retorno);
        }
    }

    

   

}
