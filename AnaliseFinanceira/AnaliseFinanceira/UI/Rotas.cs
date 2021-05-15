using DevExpress.XtraBars.Ribbon;
using System.Collections.Generic;

namespace AnaliseFinanceira.UI { 
    public static class Rotas {
        public static RibbonForm formMain;
        public static void AbrirFrmCompras() {
            if (!IsEmpresaLogada(true)) return;
            FrmCompras f = new FrmCompras();
            f.MdiParent = formMain;
            f.Show();
        }
        public static void AbrirFrmVendas()
        {
            if (!IsEmpresaLogada(true)) return;
            FrmVendas f = new FrmVendas();
            f.MdiParent = formMain;
            f.Show();
        }
        public static void AbrirFrmExtratoBancario()
        {
            if (!IsEmpresaLogada(true)) return;
            FrmExtratoBancario f = new FrmExtratoBancario();
            f.MdiParent = formMain;
            f.Show();
        }
        public static void AbrirFrmResultados()
        {
            if (!IsEmpresaLogada(true)) return;
            FrmResultados f = new FrmResultados();
            f.MdiParent = formMain;
            f.Show();
        }
        public static void AbrirFrmDiario()
        {
            if (!IsEmpresaLogada(true)) return;
            FrmDiario f = new FrmDiario();
            f.MdiParent = formMain;
            f.Show();
        }
        public static bool IsEmpresaLogada(bool abrirForm) {
            //if (DadosLogin.EmpresaLogin == null) {
            //    if (abrirForm) AbrirFrmEmpresa();
            //    if (DadosLogin.EmpresaLogin == null) return false;
            //    return true;
            //}
            return true;
        }
        public static void AbrilFrmMain() {
            FrmMain f = new FrmMain();
            f.Show();
        }

        public static void AbrirFrmErros(List<string> erros)
        {
            FrmListaError f = new FrmListaError(erros);
            f.ShowInTaskbar = true;
            f.ShowDialog();
        }
    }
}
