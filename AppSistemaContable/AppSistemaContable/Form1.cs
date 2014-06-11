using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace AppSistemaContable
{
    public partial class Form1 : RibbonForm
    {
        /// <summary>
        /// constructor principal del formulario
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
        }

        /// <summary>
        /// inicializa el skin predeterminado
        /// </summary>
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }      

        /// <summary>
        /// ADMINISTRACION>>>ACTIVIDAD ECONOMICA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActividadEconomica_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pbImagenFondo.Visible = false;
            ActividadEconomica.frmPrincipalActividadEconómica actividad=new ActividadEconomica.frmPrincipalActividadEconómica();
            actividad.MdiParent = this;
            actividad.Show();            
        }

        /// <summary>
        /// ADMINISTRACION>>ORG. LEGAL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrganizacionLegal_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pbImagenFondo.Visible = false;
            OrganizacionLegal.frmPrincipalOrgLegal organizacionLegal = new OrganizacionLegal.frmPrincipalOrgLegal();
            organizacionLegal.MdiParent = this;
            organizacionLegal.Show();
        }

        /// <summary>
        /// VENTAS>>REGISTRO DE VENTAS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVentas_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pbImagenFondo.Visible = false;
            VentasRegistroVentas.frmNuevaVenta nueva = new VentasRegistroVentas.frmNuevaVenta();
            nueva.MdiParent = this;
            nueva.Show();
            
        }

        /// <summary>
        /// COMPRAS>>REGISTRO DE COMPRAS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompras_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pbImagenFondo.Visible = false;
            ComprasRegistroCompras.frmNuevaCompra nueva = new ComprasRegistroCompras.frmNuevaCompra();
            nueva.MdiParent = this;
            nueva.Show();
        }

        /// <summary>
        /// ADMINISTRACION>>EMPRESAS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpresas_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pbImagenFondo.Visible = false;
            AdminEmpresas.frmPrincipalEmpresas empresas = new AdminEmpresas.frmPrincipalEmpresas();
            empresas.MdiParent = this;
            empresas.Show();
        }

        /// <summary>
        /// ADMINISTRACION>>EMPRESARIOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpresarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pbImagenFondo.Visible = false;
            AdminEmpresarios.frmPrincipalEmpresarios empresarios = new AdminEmpresarios.frmPrincipalEmpresarios();
            empresarios.MdiParent = this;
            empresarios.Show();
        }

    }
}