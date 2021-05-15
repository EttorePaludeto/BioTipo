using DevExpress.XtraPivotGrid;
using DevExpress.Utils;
using System.Drawing;

namespace AnaliseFinanceira.UI.Controls
{
    public static class PivotColumnTemplate
    {

        private static PivotGridField PivotBase(string fieldName, string caption, PivotArea pivotArea, int areaIndex, HorzAlignment horzAlignment, Color? backColor, Color? foreColor)
        {
            PivotGridField pivot = new PivotGridField();
          //  pivot.Name = fieldName;
            pivot.FieldName = fieldName;
            pivot.Caption = caption ?? fieldName;
            pivot.Area = pivotArea;
            pivot.AreaIndex = areaIndex;
            //Header padrão
            pivot.Appearance.Header.Options.UseFont = true;
            pivot.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            pivot.Appearance.Header.Options.UseTextOptions = true;
            pivot.Appearance.Header.TextOptions.HAlignment = HorzAlignment.Center;
            //Cell customizavel
            pivot.Appearance.Cell.Options.UseBackColor = true;
            pivot.Appearance.Cell.BackColor = backColor?? Color.Empty;
            pivot.Appearance.Value.Options.UseForeColor = true;
            pivot.Appearance.Value.ForeColor = foreColor ?? Color.Empty;
            pivot.Appearance.Cell.Options.UseTextOptions = true;
            pivot.Appearance.Cell.TextOptions.HAlignment = horzAlignment;

            return pivot;
        }

        public static PivotGridField PivotData(string fieldName, int areaIndex = 1, string caption = "", PivotArea pivotArea = PivotArea.RowArea, HorzAlignment horzAlignment = HorzAlignment.Center, Color? backColor = null, Color? foreColor = null) 
        {
            PivotGridField pivot = PivotBase(fieldName, caption, pivotArea, areaIndex, horzAlignment, backColor, foreColor);
            pivot.CellFormat.FormatString = "d";
            pivot.CellFormat.FormatType = FormatType.DateTime;
            return pivot;
        }
        public static PivotGridField PivotNumero(string fieldName, int areaIndex = 1, string caption = "", PivotArea pivotArea = PivotArea.DataArea, HorzAlignment horzAlignment = HorzAlignment.Default, Color? backColor = null, Color? foreColor = null, DisplayFormatNumber casasDecimais = DisplayFormatNumber.n2)
        {
            PivotGridField pivot = PivotBase(fieldName, caption, pivotArea, areaIndex, horzAlignment, backColor, foreColor);
            pivot.CellFormat.FormatString = casasDecimais.ToString();
            pivot.CellFormat.FormatType = FormatType.Numeric;
            return pivot;
        }
        public static PivotGridField PivotString(string fieldName, int areaIndex = 1, string caption = "", PivotArea pivotArea = PivotArea.RowArea, HorzAlignment horzAlignment = HorzAlignment.Default, Color? backColor = null, Color? foreColor = null)
        {
            PivotGridField pivot = PivotBase(fieldName, caption, pivotArea, areaIndex, horzAlignment, backColor, foreColor);
            return pivot;
        }

        public static PivotGridField AppearanceValue(this PivotGridField field, Color backColor, Color foreColor, FontStyle fontStyle, HorzAlignment horzAlignment)
        {
            field.Appearance.Value.Options.UseFont = true;
            field.Appearance.Value.ForeColor = foreColor;
            field.Appearance.Value.Font = new Font("Segoe UI", 8.25F, fontStyle);
            field.Appearance.Value.Options.UseTextOptions = true;
            field.Appearance.Value.TextOptions.HAlignment = horzAlignment;
            field.Appearance.Value.Options.UseBackColor = true;
            field.Appearance.Value.BackColor = backColor;

            return field;
        }


    }
}
