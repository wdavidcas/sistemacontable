namespace AppSistemaContable.VentasRegistroVentas
{
    partial class frmNuevaVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gcEncabezados = new DevExpress.XtraEditors.GroupControl();
            this.tablaDatosGenerales = new System.Windows.Forms.TableLayoutPanel();
            this.txtSerie = new DevExpress.XtraEditors.TextEdit();
            this.txtNoDoc = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtedFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cbxDocumento = new System.Windows.Forms.ComboBox();
            this.btnNuevoCliente = new DevExpress.XtraEditors.SimpleButton();
            this.gcDetalles = new DevExpress.XtraEditors.GroupControl();
            this.tablaDetalles = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoCombustible = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevoProducto = new DevExpress.XtraEditors.SimpleButton();
            this.lblTotalImpuestoDoc = new System.Windows.Forms.Label();
            this.cbxProductos = new System.Windows.Forms.ComboBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.optProductos = new System.Windows.Forms.RadioButton();
            this.cbxServicios = new System.Windows.Forms.ComboBox();
            this.optCombustible = new System.Windows.Forms.RadioButton();
            this.cbxCombustible = new System.Windows.Forms.ComboBox();
            this.optServicios = new System.Windows.Forms.RadioButton();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblGasolina = new System.Windows.Forms.Label();
            this.txtPrecioUnidad = new DevExpress.XtraEditors.TextEdit();
            this.lblPrecioUnidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.dgvListaDetalles = new System.Windows.Forms.DataGridView();
            this.lblTotalDoc = new System.Windows.Forms.Label();
            this.txtTotalDocumento = new DevExpress.XtraEditors.TextEdit();
            this.txtImpuestoDocumento = new DevExpress.XtraEditors.TextEdit();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevoServicio = new DevExpress.XtraEditors.SimpleButton();
            this.tablaGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.gcDocumentosingresados = new DevExpress.XtraEditors.GroupControl();
            this.tablaResumen = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalImpuestoResumen = new System.Windows.Forms.TextBox();
            this.txtTotalResumen = new System.Windows.Forms.TextBox();
            this.txtCantidadDocs = new System.Windows.Forms.TextBox();
            this.lblCantidadDocs = new System.Windows.Forms.Label();
            this.lblTotalImpuestoResumen = new System.Windows.Forms.Label();
            this.lblTotalResumen = new System.Windows.Forms.Label();
            this.dgvDocumentosRegistrados = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcEncabezados)).BeginInit();
            this.gcEncabezados.SuspendLayout();
            this.tablaDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtedFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtedFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalles)).BeginInit();
            this.gcDetalles.SuspendLayout();
            this.tablaDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuestoDocumento.Properties)).BeginInit();
            this.tablaGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocumentosingresados)).BeginInit();
            this.gcDocumentosingresados.SuspendLayout();
            this.tablaResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentosRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // gcEncabezados
            // 
            this.gcEncabezados.Controls.Add(this.tablaDatosGenerales);
            this.gcEncabezados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEncabezados.Location = new System.Drawing.Point(3, 23);
            this.gcEncabezados.Name = "gcEncabezados";
            this.gcEncabezados.Size = new System.Drawing.Size(717, 162);
            this.gcEncabezados.TabIndex = 1;
            this.gcEncabezados.Text = "Datos generales";
            // 
            // tablaDatosGenerales
            // 
            this.tablaDatosGenerales.ColumnCount = 5;
            this.tablaDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaDatosGenerales.Controls.Add(this.txtSerie, 1, 3);
            this.tablaDatosGenerales.Controls.Add(this.txtNoDoc, 3, 3);
            this.tablaDatosGenerales.Controls.Add(this.lblNombre, 0, 0);
            this.tablaDatosGenerales.Controls.Add(this.lblSerie, 0, 3);
            this.tablaDatosGenerales.Controls.Add(this.cbxCliente, 1, 0);
            this.tablaDatosGenerales.Controls.Add(this.lblTipoDoc, 0, 1);
            this.tablaDatosGenerales.Controls.Add(this.lblFecha, 0, 5);
            this.tablaDatosGenerales.Controls.Add(this.dtedFecha, 1, 5);
            this.tablaDatosGenerales.Controls.Add(this.lblDoc, 2, 3);
            this.tablaDatosGenerales.Controls.Add(this.lblDocumento, 2, 1);
            this.tablaDatosGenerales.Controls.Add(this.cbxTipoDocumento, 1, 1);
            this.tablaDatosGenerales.Controls.Add(this.cbxDocumento, 3, 1);
            this.tablaDatosGenerales.Controls.Add(this.btnNuevoCliente, 4, 0);
            this.tablaDatosGenerales.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablaDatosGenerales.Location = new System.Drawing.Point(2, 21);
            this.tablaDatosGenerales.Name = "tablaDatosGenerales";
            this.tablaDatosGenerales.RowCount = 6;
            this.tablaDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDatosGenerales.Size = new System.Drawing.Size(707, 139);
            this.tablaDatosGenerales.TabIndex = 0;
            // 
            // txtSerie
            // 
            this.txtSerie.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSerie.Location = new System.Drawing.Point(156, 63);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(150, 20);
            this.txtSerie.TabIndex = 5;
            // 
            // txtNoDoc
            // 
            this.txtNoDoc.Location = new System.Drawing.Point(408, 63);
            this.txtNoDoc.Name = "txtNoDoc";
            this.txtNoDoc.Size = new System.Drawing.Size(137, 20);
            this.txtNoDoc.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(3, 60);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(44, 19);
            this.lblSerie.TabIndex = 5;
            this.lblSerie.Text = "Serie";
            // 
            // cbxCliente
            // 
            this.tablaDatosGenerales.SetColumnSpan(this.cbxCliente, 3);
            this.cbxCliente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(156, 3);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(448, 24);
            this.cbxCliente.TabIndex = 1;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(3, 30);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(147, 19);
            this.lblTipoDoc.TabIndex = 3;
            this.lblTipoDoc.Text = "Tipo de documento";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(3, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 19);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // dtedFecha
            // 
            this.dtedFecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtedFecha.EditValue = null;
            this.dtedFecha.Location = new System.Drawing.Point(156, 89);
            this.dtedFecha.Name = "dtedFecha";
            this.dtedFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtedFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtedFecha.Size = new System.Drawing.Size(149, 20);
            this.dtedFecha.TabIndex = 7;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.Location = new System.Drawing.Point(312, 60);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(64, 19);
            this.lblDoc.TabIndex = 13;
            this.lblDoc.Text = "No. doc";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(312, 30);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(90, 19);
            this.lblDocumento.TabIndex = 7;
            this.lblDocumento.Text = "Documento";
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Location = new System.Drawing.Point(156, 33);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(150, 24);
            this.cbxTipoDocumento.TabIndex = 3;
            // 
            // cbxDocumento
            // 
            this.tablaDatosGenerales.SetColumnSpan(this.cbxDocumento, 2);
            this.cbxDocumento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDocumento.FormattingEnabled = true;
            this.cbxDocumento.Location = new System.Drawing.Point(408, 33);
            this.cbxDocumento.Name = "cbxDocumento";
            this.cbxDocumento.Size = new System.Drawing.Size(196, 24);
            this.cbxDocumento.TabIndex = 4;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Image = global::AppSistemaContable.Properties.Resources.agregar;
            this.btnNuevoCliente.Location = new System.Drawing.Point(610, 3);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(37, 23);
            this.btnNuevoCliente.TabIndex = 2;
            // 
            // gcDetalles
            // 
            this.gcDetalles.Controls.Add(this.tablaDetalles);
            this.gcDetalles.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDetalles.Location = new System.Drawing.Point(3, 191);
            this.gcDetalles.Name = "gcDetalles";
            this.gcDetalles.Size = new System.Drawing.Size(717, 394);
            this.gcDetalles.TabIndex = 2;
            this.gcDetalles.Text = "Detalles";
            // 
            // tablaDetalles
            // 
            this.tablaDetalles.ColumnCount = 6;
            this.tablaDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaDetalles.Controls.Add(this.btnNuevoCombustible, 3, 2);
            this.tablaDetalles.Controls.Add(this.btnNuevoProducto, 3, 1);
            this.tablaDetalles.Controls.Add(this.lblTotalImpuestoDoc, 0, 7);
            this.tablaDetalles.Controls.Add(this.cbxProductos, 1, 1);
            this.tablaDetalles.Controls.Add(this.lblServicio, 0, 3);
            this.tablaDetalles.Controls.Add(this.optProductos, 0, 0);
            this.tablaDetalles.Controls.Add(this.cbxServicios, 1, 3);
            this.tablaDetalles.Controls.Add(this.optCombustible, 1, 0);
            this.tablaDetalles.Controls.Add(this.cbxCombustible, 1, 2);
            this.tablaDetalles.Controls.Add(this.optServicios, 2, 0);
            this.tablaDetalles.Controls.Add(this.lblProducto, 0, 1);
            this.tablaDetalles.Controls.Add(this.lblGasolina, 0, 2);
            this.tablaDetalles.Controls.Add(this.txtPrecioUnidad, 5, 1);
            this.tablaDetalles.Controls.Add(this.lblPrecioUnidad, 4, 1);
            this.tablaDetalles.Controls.Add(this.numCantidad, 5, 2);
            this.tablaDetalles.Controls.Add(this.lblCantidad, 4, 2);
            this.tablaDetalles.Controls.Add(this.txtSubtotal, 5, 3);
            this.tablaDetalles.Controls.Add(this.lblSubtotal, 4, 3);
            this.tablaDetalles.Controls.Add(this.dgvListaDetalles, 0, 5);
            this.tablaDetalles.Controls.Add(this.lblTotalDoc, 0, 6);
            this.tablaDetalles.Controls.Add(this.txtTotalDocumento, 1, 6);
            this.tablaDetalles.Controls.Add(this.txtImpuestoDocumento, 1, 7);
            this.tablaDetalles.Controls.Add(this.btnEliminar, 5, 4);
            this.tablaDetalles.Controls.Add(this.btnAgregar, 4, 4);
            this.tablaDetalles.Controls.Add(this.btnGuardar, 4, 6);
            this.tablaDetalles.Controls.Add(this.btnCancelar, 5, 6);
            this.tablaDetalles.Controls.Add(this.btnNuevoServicio, 3, 3);
            this.tablaDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaDetalles.Location = new System.Drawing.Point(2, 21);
            this.tablaDetalles.Name = "tablaDetalles";
            this.tablaDetalles.RowCount = 8;
            this.tablaDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaDetalles.Size = new System.Drawing.Size(713, 371);
            this.tablaDetalles.TabIndex = 0;
            // 
            // btnNuevoCombustible
            // 
            this.btnNuevoCombustible.Image = global::AppSistemaContable.Properties.Resources.agregar;
            this.btnNuevoCombustible.Location = new System.Drawing.Point(311, 55);
            this.btnNuevoCombustible.Name = "btnNuevoCombustible";
            this.btnNuevoCombustible.Size = new System.Drawing.Size(37, 23);
            this.btnNuevoCombustible.TabIndex = 7;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Image = global::AppSistemaContable.Properties.Resources.agregar;
            this.btnNuevoProducto.Location = new System.Drawing.Point(311, 26);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(37, 23);
            this.btnNuevoProducto.TabIndex = 5;
            // 
            // lblTotalImpuestoDoc
            // 
            this.lblTotalImpuestoDoc.AutoSize = true;
            this.lblTotalImpuestoDoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalImpuestoDoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImpuestoDoc.Location = new System.Drawing.Point(3, 324);
            this.lblTotalImpuestoDoc.Name = "lblTotalImpuestoDoc";
            this.lblTotalImpuestoDoc.Size = new System.Drawing.Size(76, 47);
            this.lblTotalImpuestoDoc.TabIndex = 27;
            this.lblTotalImpuestoDoc.Text = "Impuesto";
            // 
            // cbxProductos
            // 
            this.tablaDetalles.SetColumnSpan(this.cbxProductos, 2);
            this.cbxProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxProductos.FormattingEnabled = true;
            this.cbxProductos.Location = new System.Drawing.Point(106, 26);
            this.cbxProductos.Name = "cbxProductos";
            this.cbxProductos.Size = new System.Drawing.Size(199, 21);
            this.cbxProductos.TabIndex = 4;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblServicio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(3, 81);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(64, 29);
            this.lblServicio.TabIndex = 21;
            this.lblServicio.Text = "Servicio";
            // 
            // optProductos
            // 
            this.optProductos.AutoSize = true;
            this.optProductos.Location = new System.Drawing.Point(3, 3);
            this.optProductos.Name = "optProductos";
            this.optProductos.Size = new System.Drawing.Size(73, 17);
            this.optProductos.TabIndex = 1;
            this.optProductos.TabStop = true;
            this.optProductos.Text = "Productos";
            this.optProductos.UseVisualStyleBackColor = true;
            // 
            // cbxServicios
            // 
            this.tablaDetalles.SetColumnSpan(this.cbxServicios, 2);
            this.cbxServicios.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxServicios.FormattingEnabled = true;
            this.cbxServicios.Location = new System.Drawing.Point(106, 84);
            this.cbxServicios.Name = "cbxServicios";
            this.cbxServicios.Size = new System.Drawing.Size(199, 21);
            this.cbxServicios.TabIndex = 8;
            // 
            // optCombustible
            // 
            this.optCombustible.AutoSize = true;
            this.optCombustible.Location = new System.Drawing.Point(106, 3);
            this.optCombustible.Name = "optCombustible";
            this.optCombustible.Size = new System.Drawing.Size(83, 17);
            this.optCombustible.TabIndex = 2;
            this.optCombustible.TabStop = true;
            this.optCombustible.Text = "Combustible";
            this.optCombustible.UseVisualStyleBackColor = true;
            // 
            // cbxCombustible
            // 
            this.tablaDetalles.SetColumnSpan(this.cbxCombustible, 2);
            this.cbxCombustible.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxCombustible.FormattingEnabled = true;
            this.cbxCombustible.Location = new System.Drawing.Point(106, 55);
            this.cbxCombustible.Name = "cbxCombustible";
            this.cbxCombustible.Size = new System.Drawing.Size(199, 21);
            this.cbxCombustible.TabIndex = 6;
            // 
            // optServicios
            // 
            this.optServicios.AutoSize = true;
            this.optServicios.Location = new System.Drawing.Point(195, 3);
            this.optServicios.Name = "optServicios";
            this.optServicios.Size = new System.Drawing.Size(67, 17);
            this.optServicios.TabIndex = 3;
            this.optServicios.TabStop = true;
            this.optServicios.Text = "Servicios";
            this.optServicios.UseVisualStyleBackColor = true;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(3, 23);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(72, 29);
            this.lblProducto.TabIndex = 16;
            this.lblProducto.Text = "Producto";
            // 
            // lblGasolina
            // 
            this.lblGasolina.AutoSize = true;
            this.lblGasolina.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGasolina.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasolina.Location = new System.Drawing.Point(3, 52);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(97, 29);
            this.lblGasolina.TabIndex = 14;
            this.lblGasolina.Text = "Combustible";
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPrecioUnidad.Location = new System.Drawing.Point(471, 26);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(146, 20);
            this.txtPrecioUnidad.TabIndex = 10;
            // 
            // lblPrecioUnidad
            // 
            this.lblPrecioUnidad.AutoSize = true;
            this.lblPrecioUnidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrecioUnidad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnidad.Location = new System.Drawing.Point(354, 23);
            this.lblPrecioUnidad.Name = "lblPrecioUnidad";
            this.lblPrecioUnidad.Size = new System.Drawing.Size(78, 29);
            this.lblPrecioUnidad.TabIndex = 24;
            this.lblPrecioUnidad.Text = "P. Unidad";
            // 
            // numCantidad
            // 
            this.numCantidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.numCantidad.Location = new System.Drawing.Point(471, 55);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(146, 21);
            this.numCantidad.TabIndex = 11;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCantidad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(354, 52);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(71, 29);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSubtotal.Location = new System.Drawing.Point(471, 84);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(146, 20);
            this.txtSubtotal.TabIndex = 12;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSubtotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(354, 81);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(67, 29);
            this.lblSubtotal.TabIndex = 27;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // dgvListaDetalles
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvListaDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDetalles.SetColumnSpan(this.dgvListaDetalles, 6);
            this.dgvListaDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaDetalles.Location = new System.Drawing.Point(3, 156);
            this.dgvListaDetalles.Name = "dgvListaDetalles";
            this.dgvListaDetalles.Size = new System.Drawing.Size(707, 115);
            this.dgvListaDetalles.TabIndex = 29;
            this.dgvListaDetalles.TabStop = false;
            // 
            // lblTotalDoc
            // 
            this.lblTotalDoc.AutoSize = true;
            this.lblTotalDoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalDoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDoc.Location = new System.Drawing.Point(3, 274);
            this.lblTotalDoc.Name = "lblTotalDoc";
            this.lblTotalDoc.Size = new System.Drawing.Size(67, 50);
            this.lblTotalDoc.TabIndex = 27;
            this.lblTotalDoc.Text = "Total Q.";
            // 
            // txtTotalDocumento
            // 
            this.tablaDetalles.SetColumnSpan(this.txtTotalDocumento, 2);
            this.txtTotalDocumento.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTotalDocumento.Enabled = false;
            this.txtTotalDocumento.Location = new System.Drawing.Point(106, 277);
            this.txtTotalDocumento.Name = "txtTotalDocumento";
            this.txtTotalDocumento.Size = new System.Drawing.Size(199, 20);
            this.txtTotalDocumento.TabIndex = 31;
            // 
            // txtImpuestoDocumento
            // 
            this.tablaDetalles.SetColumnSpan(this.txtImpuestoDocumento, 2);
            this.txtImpuestoDocumento.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtImpuestoDocumento.Enabled = false;
            this.txtImpuestoDocumento.Location = new System.Drawing.Point(106, 327);
            this.txtImpuestoDocumento.Name = "txtImpuestoDocumento";
            this.txtImpuestoDocumento.Size = new System.Drawing.Size(199, 20);
            this.txtImpuestoDocumento.TabIndex = 32;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.Image = global::AppSistemaContable.Properties.Resources.list_remove;
            this.btnEliminar.Location = new System.Drawing.Point(603, 113);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 37);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.Image = global::AppSistemaContable.Properties.Resources.list_add;
            this.btnAgregar.Location = new System.Drawing.Point(370, 113);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 37);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.Image = global::AppSistemaContable.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(354, 277);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 44);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Image = global::AppSistemaContable.Properties.Resources.dialog_close;
            this.btnCancelar.Location = new System.Drawing.Point(599, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 44);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnNuevoServicio
            // 
            this.btnNuevoServicio.Image = global::AppSistemaContable.Properties.Resources.agregar;
            this.btnNuevoServicio.Location = new System.Drawing.Point(311, 84);
            this.btnNuevoServicio.Name = "btnNuevoServicio";
            this.btnNuevoServicio.Size = new System.Drawing.Size(37, 23);
            this.btnNuevoServicio.TabIndex = 9;
            // 
            // tablaGeneral
            // 
            this.tablaGeneral.ColumnCount = 2;
            this.tablaGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaGeneral.Controls.Add(this.gcDocumentosingresados, 1, 1);
            this.tablaGeneral.Controls.Add(this.lblTitulo, 0, 0);
            this.tablaGeneral.Controls.Add(this.gcEncabezados, 0, 1);
            this.tablaGeneral.Controls.Add(this.gcDetalles, 0, 2);
            this.tablaGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaGeneral.Location = new System.Drawing.Point(0, 0);
            this.tablaGeneral.Name = "tablaGeneral";
            this.tablaGeneral.RowCount = 3;
            this.tablaGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaGeneral.Size = new System.Drawing.Size(1301, 590);
            this.tablaGeneral.TabIndex = 15;
            // 
            // gcDocumentosingresados
            // 
            this.gcDocumentosingresados.Controls.Add(this.tablaResumen);
            this.gcDocumentosingresados.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDocumentosingresados.Location = new System.Drawing.Point(726, 23);
            this.gcDocumentosingresados.Name = "gcDocumentosingresados";
            this.tablaGeneral.SetRowSpan(this.gcDocumentosingresados, 2);
            this.gcDocumentosingresados.Size = new System.Drawing.Size(572, 562);
            this.gcDocumentosingresados.TabIndex = 3;
            this.gcDocumentosingresados.Text = "Documentos ingresados";
            // 
            // tablaResumen
            // 
            this.tablaResumen.ColumnCount = 3;
            this.tablaResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaResumen.Controls.Add(this.txtTotalImpuestoResumen, 1, 3);
            this.tablaResumen.Controls.Add(this.txtTotalResumen, 1, 2);
            this.tablaResumen.Controls.Add(this.txtCantidadDocs, 1, 1);
            this.tablaResumen.Controls.Add(this.lblCantidadDocs, 0, 1);
            this.tablaResumen.Controls.Add(this.lblTotalImpuestoResumen, 0, 3);
            this.tablaResumen.Controls.Add(this.lblTotalResumen, 0, 2);
            this.tablaResumen.Controls.Add(this.dgvDocumentosRegistrados, 0, 0);
            this.tablaResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaResumen.Location = new System.Drawing.Point(2, 21);
            this.tablaResumen.Name = "tablaResumen";
            this.tablaResumen.RowCount = 4;
            this.tablaResumen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaResumen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaResumen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaResumen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaResumen.Size = new System.Drawing.Size(568, 539);
            this.tablaResumen.TabIndex = 0;
            // 
            // txtTotalImpuestoResumen
            // 
            this.txtTotalImpuestoResumen.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTotalImpuestoResumen.Enabled = false;
            this.txtTotalImpuestoResumen.Location = new System.Drawing.Point(252, 378);
            this.txtTotalImpuestoResumen.Name = "txtTotalImpuestoResumen";
            this.txtTotalImpuestoResumen.Size = new System.Drawing.Size(227, 21);
            this.txtTotalImpuestoResumen.TabIndex = 20;
            // 
            // txtTotalResumen
            // 
            this.txtTotalResumen.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTotalResumen.Enabled = false;
            this.txtTotalResumen.Location = new System.Drawing.Point(252, 351);
            this.txtTotalResumen.Name = "txtTotalResumen";
            this.txtTotalResumen.Size = new System.Drawing.Size(227, 21);
            this.txtTotalResumen.TabIndex = 21;
            // 
            // txtCantidadDocs
            // 
            this.txtCantidadDocs.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCantidadDocs.Enabled = false;
            this.txtCantidadDocs.Location = new System.Drawing.Point(252, 324);
            this.txtCantidadDocs.Name = "txtCantidadDocs";
            this.txtCantidadDocs.Size = new System.Drawing.Size(156, 21);
            this.txtCantidadDocs.TabIndex = 22;
            // 
            // lblCantidadDocs
            // 
            this.lblCantidadDocs.AutoSize = true;
            this.lblCantidadDocs.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCantidadDocs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDocs.Location = new System.Drawing.Point(3, 321);
            this.lblCantidadDocs.Name = "lblCantidadDocs";
            this.lblCantidadDocs.Size = new System.Drawing.Size(206, 27);
            this.lblCantidadDocs.TabIndex = 18;
            this.lblCantidadDocs.Text = "Documentos registrados";
            // 
            // lblTotalImpuestoResumen
            // 
            this.lblTotalImpuestoResumen.AutoSize = true;
            this.lblTotalImpuestoResumen.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalImpuestoResumen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImpuestoResumen.Location = new System.Drawing.Point(3, 375);
            this.lblTotalImpuestoResumen.Name = "lblTotalImpuestoResumen";
            this.lblTotalImpuestoResumen.Size = new System.Drawing.Size(243, 164);
            this.lblTotalImpuestoResumen.TabIndex = 17;
            this.lblTotalImpuestoResumen.Text = "Total impuesto registrado Q.";
            // 
            // lblTotalResumen
            // 
            this.lblTotalResumen.AutoSize = true;
            this.lblTotalResumen.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalResumen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResumen.Location = new System.Drawing.Point(3, 348);
            this.lblTotalResumen.Name = "lblTotalResumen";
            this.lblTotalResumen.Size = new System.Drawing.Size(163, 27);
            this.lblTotalResumen.TabIndex = 19;
            this.lblTotalResumen.Text = "Total registrado Q.";
            // 
            // dgvDocumentosRegistrados
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgvDocumentosRegistrados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocumentosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaResumen.SetColumnSpan(this.dgvDocumentosRegistrados, 3);
            this.dgvDocumentosRegistrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocumentosRegistrados.Location = new System.Drawing.Point(3, 3);
            this.dgvDocumentosRegistrados.Name = "dgvDocumentosRegistrados";
            this.dgvDocumentosRegistrados.Size = new System.Drawing.Size(562, 315);
            this.dgvDocumentosRegistrados.TabIndex = 23;
            this.dgvDocumentosRegistrados.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 20);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Registro de ventas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 590);
            this.Controls.Add(this.tablaGeneral);
            this.Name = "frmNuevaVenta";
            this.ShowIcon = false;
            this.Text = "Registro de nueva venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcEncabezados)).EndInit();
            this.gcEncabezados.ResumeLayout(false);
            this.tablaDatosGenerales.ResumeLayout(false);
            this.tablaDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtedFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtedFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalles)).EndInit();
            this.gcDetalles.ResumeLayout(false);
            this.tablaDetalles.ResumeLayout(false);
            this.tablaDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuestoDocumento.Properties)).EndInit();
            this.tablaGeneral.ResumeLayout(false);
            this.tablaGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocumentosingresados)).EndInit();
            this.gcDocumentosingresados.ResumeLayout(false);
            this.tablaResumen.ResumeLayout(false);
            this.tablaResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentosRegistrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcEncabezados;
        private System.Windows.Forms.TableLayoutPanel tablaDatosGenerales;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblSerie;
        private DevExpress.XtraEditors.TextEdit txtSerie;
        private System.Windows.Forms.ComboBox cbxDocumento;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDoc;
        private DevExpress.XtraEditors.DateEdit dtedFecha;
        private DevExpress.XtraEditors.TextEdit txtNoDoc;
        private DevExpress.XtraEditors.GroupControl gcDetalles;
        private System.Windows.Forms.TableLayoutPanel tablaDetalles;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private DevExpress.XtraEditors.TextEdit txtPrecioUnidad;
        private System.Windows.Forms.ComboBox cbxProductos;
        private System.Windows.Forms.Label lblPrecioUnidad;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.RadioButton optProductos;
        private System.Windows.Forms.ComboBox cbxServicios;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.RadioButton optCombustible;
        private System.Windows.Forms.ComboBox cbxCombustible;
        private System.Windows.Forms.RadioButton optServicios;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblGasolina;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private System.Windows.Forms.Label lblTotalImpuestoDoc;
        private System.Windows.Forms.DataGridView dgvListaDetalles;
        private System.Windows.Forms.Label lblTotalDoc;
        private DevExpress.XtraEditors.TextEdit txtTotalDocumento;
        private DevExpress.XtraEditors.TextEdit txtImpuestoDocumento;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.TableLayoutPanel tablaGeneral;
        private System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraEditors.GroupControl gcDocumentosingresados;
        private System.Windows.Forms.TableLayoutPanel tablaResumen;
        private System.Windows.Forms.TextBox txtTotalImpuestoResumen;
        private System.Windows.Forms.TextBox txtTotalResumen;
        private System.Windows.Forms.TextBox txtCantidadDocs;
        private System.Windows.Forms.Label lblCantidadDocs;
        private System.Windows.Forms.Label lblTotalImpuestoResumen;
        private System.Windows.Forms.Label lblTotalResumen;
        private System.Windows.Forms.DataGridView dgvDocumentosRegistrados;
        private DevExpress.XtraEditors.SimpleButton btnNuevoCliente;
        private DevExpress.XtraEditors.SimpleButton btnNuevoCombustible;
        private DevExpress.XtraEditors.SimpleButton btnNuevoProducto;
        private DevExpress.XtraEditors.SimpleButton btnNuevoServicio;
    }
}