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
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            Rotas.formMain = this;
        }

        private void BtnCompras_ItemClick(object sender, ItemClickEventArgs e)
        {
            Rotas.AbrirFrmCompras();
        }

        private void BtnVendas_ItemClick(object sender, ItemClickEventArgs e)
        {
            Rotas.AbrirFrmVendas();
        }

        private void BtnExtratos_ItemClick(object sender, ItemClickEventArgs e)
        {
            Rotas.AbrirFrmExtratoBancario();
        }

        private void BtnResultado_ItemClick(object sender, ItemClickEventArgs e)
        {
            Rotas.AbrirFrmResultados();
        }

        private void BtnDiario_ItemClick(object sender, ItemClickEventArgs e)
        {
            Rotas.AbrirFrmDiario();
        }
    }
}