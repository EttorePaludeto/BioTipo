using AnaliseFinanceira.DAL;
using AnaliseFinanceira.Models;
using AnaliseFinanceira.UI;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AnaliseFinanceira.BLL.Extratos
{
    /// <summary>
    /// Importa os registros de uma tabela EXCEL para a tabela EXTRATOS. 
    /// Essa classe não está finalizada, mas contem estudo sobre o processo de importação do EXCEL com uso
    /// da dll XMLClosed
    /// </summary>
    public class ImportarExtratosExcel 
    {
        private readonly DataAccess ctxADO;
        private List<Extrato> listExtrato;
        private List<ExtratoConciliado> listExtratoConciliado;

        public ImportarExtratosExcel()
        {
            ctxADO = new DataAccess();
            listExtrato = new List<Extrato>();
            listExtratoConciliado = new List<ExtratoConciliado>();
        }

        public void ImportarExtratoXls()
        {
            var xls = new XLWorkbook(@"C:\Users\ettor\OneDrive\Área de Trabalho\ExtratoTeste.xlsx");

            foreach (var aba in xls.Worksheets)
            {
                var planilha = aba;
                var totalLinhas = planilha.Rows().Count();
                for (int i = 2; i <= totalLinhas; i++)
                {

                    var extRow = new Extrato(
                        id: i,
                        bancoId: Convert.ToInt32(planilha.Cell($"A{i}").Value),
                        data: Convert.ToDateTime(planilha.Cell($"B{i}").Value),
                        historico: planilha.Cell($"C{i}").Value.ToString(),
                        valor: planilha.Cell($"D{i}").Value.ToDecimalN2()
                        );
                    listExtrato.Add(extRow);
                }
            }
           // gridControl1.DataSource = listExtratoConciliado;
        }
        public void SalvarExtrato()
        {
            if (listExtrato.Count == 0) return;
            int registrosAfetados = ctxADO.InsertBulkSql(listExtrato.AsDataTable(), "Extrato");
            MessageBox.Show($"Foram importados {registrosAfetados}");
        }
        public void ImportarExtratoConciliado()
        {
            var xls = new XLWorkbook(@"C:\Users\ettor\OneDrive\Área de Trabalho\ExtratoMaquininhas.xlsx");

            int ultimoId = 3821;

            foreach (var aba in xls.Worksheets)
            {
                var planilha = aba;
                var totalLinhas = planilha.Rows().Count();
                //var totalLinhas = 3;
                for (int i = 2; i < totalLinhas; i++)
                {
                    ExtratoConciliado extRow = new ExtratoConciliado()
                    {
                        ExtratoId = ultimoId,
                        BancoId = Convert.ToInt32(planilha.Cell($"B{i}").Value),
                        Data = Convert.ToDateTime(planilha.Cell($"C{i}").Value),
                        Historico = planilha.Cell($"D{i}").Value.ToString(),
                        Valor = planilha.Cell($"E{i}").Value.ToDecimalN2(),
                        ValorContabil = planilha.Cell($"E{i}").Value.ToDecimalN2().ToModulo(),
                        DebitoId = Convert.ToInt32(planilha.Cell($"G{i}").Value),
                        CreditoId = Convert.ToInt32(planilha.Cell($"H{i}").Value)
                    };
                    ultimoId += 1;
                    listExtratoConciliado.Add(extRow);
                }
            }


        }
        public void SalvarExtratoConciliado()
        {
            if (listExtratoConciliado.Count == 0) return;
            int registrosAfetados = ctxADO.InsertBulkSql(listExtratoConciliado.AsDataTable(), "ExtratoConciliado");
            MessageBox.Show($"Foram importados {registrosAfetados}");
        }
    }

   

   

   

}