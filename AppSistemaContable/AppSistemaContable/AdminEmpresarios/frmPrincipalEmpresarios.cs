using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AppSistemaContable.AdminEmpresarios
{
    public partial class frmPrincipalEmpresarios : DevExpress.XtraEditors.XtraForm
    {
        public frmPrincipalEmpresarios()
        {
            InitializeComponent();
            this.gbTelefonos.Visible = false;
        }

        private void dgvListado_Click(object sender, EventArgs e)
        {
            this.gbTelefonos.Visible = true;
        }

        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            this.gbTelefonos.Visible = false;
        }
    }
}