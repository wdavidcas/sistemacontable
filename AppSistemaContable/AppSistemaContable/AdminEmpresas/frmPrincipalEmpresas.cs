using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AppSistemaContable.AdminEmpresas
{
    public partial class frmPrincipalEmpresas : DevExpress.XtraEditors.XtraForm
    {
        public frmPrincipalEmpresas()
        {
            InitializeComponent();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AdminEmpresas.frmAgregaEditaEmpresa nuevo = new AdminEmpresas.frmAgregaEditaEmpresa();
            nuevo.ShowDialog();            
        }
    }
}