using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using System.Drawing;

namespace AnaliseFinanceira.UI.Controls
{
    public enum DisplayFormatNumber
    {
        n0 = 0,
        n1 = 1,
        n2 = 2,
        n3 = 3,
        n4 = 4,
        n5 = 5
    }
    public static class GridColumnTemplate
    {
        private static GridColumn ColBase(string fieldName, HorzAlignment alinha, int order, Color? backColor, Color? foreColor, string caption = "")
        {
            if (caption == "") caption = fieldName;

            GridColumn colBase = new GridColumn();
            colBase.Caption = caption;
            colBase.FieldName = fieldName;
            colBase.Name = fieldName;
            colBase.Visible = true;
            colBase.VisibleIndex = order;
            colBase.AppearanceCell.Options.UseTextOptions = true;
            colBase.AppearanceCell.Options.UseBackColor = true;
            colBase.AppearanceCell.Options.UseForeColor = true;
            colBase.AppearanceCell.TextOptions.HAlignment = alinha;
            colBase.AppearanceCell.BackColor = backColor?? Color.Empty;
            colBase.AppearanceCell.ForeColor = foreColor?? Color.Empty;
            
            //Cabeçalho Padrão
            colBase.AppearanceHeader.Options.UseTextOptions = true;
            colBase.AppearanceHeader.Options.UseFont = true;
            colBase.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            colBase.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            return colBase;

        }

        public static GridColumn ColData(string fieldName, int order = 1, string caption = "", HorzAlignment alinha = HorzAlignment.Center,
            Color? backColor = null, Color? foreColor = null)
        {
            GridColumn col = ColBase(fieldName, alinha, order, backColor, foreColor, caption);
            col.DisplayFormat.FormatString = "d";
            col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            return col;
        }

        public static GridColumn ColNumero(string fieldName, int order = 1, string caption = "",
            HorzAlignment alinha = HorzAlignment.Default, Color? backColor = null, Color? foreColor = null, DisplayFormatNumber casas = DisplayFormatNumber.n0)
        {
            GridColumn col = ColBase(fieldName, alinha, order, backColor, foreColor, caption);
            col.DisplayFormat.FormatString = casas.ToString();
            col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            return col;
        }

        public static GridColumn ColString(string fieldName, int order = 1, string caption = "",
            HorzAlignment alinha = HorzAlignment.Default, Color? backColor = null, Color? foreColor = null)
        {
            GridColumn col = ColBase(fieldName, alinha, order, backColor, foreColor, caption);
            return col;
        }
    }
}
