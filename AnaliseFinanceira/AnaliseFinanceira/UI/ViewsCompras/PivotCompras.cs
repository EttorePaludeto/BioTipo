using DevExpress.Data.PivotGrid;
using DevExpress.Utils;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseFinanceira.UI.ViewsCompras
{
    public static class PivotCompras
    {
        private static PivotGridField Id;
        private static PivotGridField Descricao;
        private static PivotGridField Ncm;
        private static PivotGridField Un;
        private static PivotGridField Qdade;
        private static PivotGridField Valor;
        private static PivotGridField Data;
        private static PivotGridField Competencia;
        private static PivotGridField Emitente;
        private static PivotGridField Numero;
        private static PivotGridField Cst;
        private static PivotGridField BcIcms;
        private static PivotGridField AliqIcms;
        private static PivotGridField Icms;
        private static PivotGridField Categoria;
        private static PivotGridField Cfop;
        private static PivotGridField Percentual;


        public static PivotGridField[] Fornecedores()
        {
            PivotGridField[] pivot = new PivotGridField[4];
            //// 
            //// pivotGridField3
            //// 
            Emitente = new PivotGridField();
            Emitente.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            Emitente.AreaIndex = 0;
            Emitente.Caption = "Emitente";
            Emitente.FieldName = "Nf.Emitente.Nome";
            Emitente.Width = 673;
            Emitente.Visible = true;
            //// 
            //// fieldValor1
            //// 
            Valor = new PivotGridField();
            Valor.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            Valor.AreaIndex = 0;
            Valor.Caption = "Valor";
            Valor.FieldName = "Valor";
            Valor.SortBySummaryInfo.Field = Descricao;
            Valor.SortBySummaryInfo.FieldName = "Emitente";
            Valor.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Value;
            //// 
            //// pivotGridField8
            Competencia = new PivotGridField();
            Competencia.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            Competencia.AreaIndex = 0;
            Competencia.Caption = "Mês";
            Competencia.FieldName = "Nf.Competencia";
            Competencia.Width = 113;

            //// pivotGridField9
            //// 
            Percentual = new PivotGridField();
            Percentual.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            Percentual.AreaIndex = 1;
            Percentual.Caption = "%";
            Percentual.CellFormat.FormatString = "P";
            Percentual.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            Percentual.FieldName = "Valor";
            Percentual.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn;


            pivot[0] = Emitente;
            pivot[1] = Valor;
            pivot[2] = Competencia;
            pivot[3] = Percentual;

            return pivot;


        }
        public static void Compras(this PivotGridField[] pivotGridFields)
        {
            Id.Visible = false;
            Descricao.Visible = false;
            Ncm.Visible = false;
            Un.Visible = false;
            Qdade.Visible = false;
            Valor.Visible = true;
            Data.Visible = false;
            Competencia.Visible = true;
            Emitente.Visible = true;
            Numero.Visible = false;
            Cst.Visible = false;
            BcIcms.Visible = false;
            AliqIcms.Visible = false;
            Icms.Visible = false;
            Categoria.Visible = false;
            Cfop.Visible = false;
            Percentual.Visible = true;
        }

        public static PivotGridField[] Todos()
        {
            PivotGridField[] pivot = new PivotGridField[17];

            Id = new PivotGridField();
            Id.AreaIndex = 10;
            Id.Caption = "Codigo";
            Id.FieldName = "Codigo";
            

            Descricao = new PivotGridField();
            Descricao.Area = PivotArea.RowArea;
            Descricao.AreaIndex = 0;
            Descricao.Caption = "Descricao";
            Descricao.FieldName = "Descricao";
            Descricao.SummaryType = PivotSummaryType.Count;
            Descricao.Width = 593;

            Ncm = new PivotGridField();
            Ncm.AreaIndex = 0;
            Ncm.Caption = "NCM";
            Ncm.FieldName = "NCM";

            Un = new PivotGridField();
            Un.AreaIndex = 0;
            Un.Caption = "Un";
            Un.FieldName = "Un";
            Un.Visible = false;

            Qdade = new PivotGridField();
            Qdade.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            Qdade.AreaIndex = 0;
            Qdade.Caption = "Quantidade";
            Qdade.CellFormat.FormatString = "N2";
            Qdade.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            Qdade.FieldName = "Quantidade";

            Emitente = new PivotGridField();
            Emitente.Area = PivotArea.RowArea;
            Emitente.AreaIndex = 0;
            Emitente.Caption = "Emitente";
            Emitente.FieldName = "Nf.Emitente.Nome";
            Emitente.Width = 673;

            Valor = new PivotGridField();
            Valor.Area = PivotArea.DataArea;
            Valor.AreaIndex = 0;
            Valor.Caption = "Valor";
            Valor.FieldName = "Valor";

            Data = new PivotGridField();
            Data.AreaIndex = 0;
            Data.Caption = "Data";
            Data.FieldName = "Nf.Data";

            Numero = new PivotGridField();
            Numero.AreaIndex = 0;
            Numero.Caption = "Número";
            Numero.FieldName = "Nf.Numero";

            Competencia = new PivotGridField();
            Competencia.Area = PivotArea.ColumnArea;
            Competencia.AreaIndex = 0;
            Competencia.Caption = "Mês";
            Competencia.FieldName = "Nf.Competencia";
            Competencia.Width = 113;

            Percentual = new PivotGridField();
            Percentual.Area = PivotArea.DataArea;
            Percentual.AreaIndex = 1;
            Percentual.Caption = "%";
            Percentual.CellFormat.FormatString = "P";
            Percentual.CellFormat.FormatType = FormatType.Numeric;
            Percentual.FieldName = "Valor";
            Percentual.SummaryDisplayType = PivotSummaryDisplayType.PercentOfColumn;

            Cst = new PivotGridField();
            Cst.AreaIndex = 0;
            Cst.Caption = "Cst";
            Cst.FieldName = "ICMS.Cst";

            BcIcms = new PivotGridField();
            BcIcms.AreaIndex = 0;
            BcIcms.Caption = "Bc Icms";
            BcIcms.FieldName = "ICMS.Bc";

            AliqIcms = new PivotGridField();
            AliqIcms.AreaIndex = 0;
            AliqIcms.Caption = "Alq Icms";
            AliqIcms.FieldName = "ICMS.Alq";
            AliqIcms.CellFormat.FormatString = "P";
            AliqIcms.CellFormat.FormatType = FormatType.Numeric;

            Icms = new PivotGridField();
            Icms.AreaIndex = 0;
            Icms.Caption = "Icms";
            Icms.FieldName = "ICMS.Imp";
            AliqIcms.CellFormat.FormatString = "N2";
            AliqIcms.CellFormat.FormatType = FormatType.Numeric;

            Cfop = new PivotGridField();
            Cfop.AreaIndex = 2;
            Cfop.Caption = "CFOP";
            Cfop.FieldName = "CFOP";

            Categoria = new PivotGridField();
            Categoria.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            Categoria.AreaIndex = 0;
            Categoria.FieldName = "Categoria";
            Categoria.Width = 320;

            Id.Visible = false;
            Descricao.Visible = false;
            Ncm.Visible = false;
            Un.Visible = false;
            Qdade.Visible = false;
            Valor.Visible = false;
            Data.Visible = false;
            Competencia.Visible = false;
            Emitente.Visible = false;
            Numero.Visible = false;
            Cst.Visible = false;
            BcIcms.Visible = false;
            AliqIcms.Visible = false;
            Icms.Visible = false;
            Categoria.Visible = false;
            Cfop.Visible = false;
            Percentual.Visible = false;

            pivot[0] = Id;
            pivot[1] = Descricao;
            pivot[2] = Ncm;
            pivot[3] = Un;
            pivot[4] = Qdade;
            pivot[5] = Valor;
            pivot[6] = Data;
            pivot[7] = Competencia;
            pivot[8] = Emitente;
            pivot[9] = Numero;
            pivot[10] = Cst;
            pivot[11] = BcIcms;
            pivot[12] = AliqIcms;
            pivot[13] = Icms;
            pivot[14] = Categoria;
            pivot[15] = Cfop;
            pivot[16] = Percentual;

            return pivot;
        }
    }
}
