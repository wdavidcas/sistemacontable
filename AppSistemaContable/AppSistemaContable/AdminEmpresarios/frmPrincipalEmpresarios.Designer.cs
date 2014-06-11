namespace AppSistemaContable.AdminEmpresarios
{
    partial class frmPrincipalEmpresarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barraHerramientasFormulario = new DevExpress.XtraBars.Bar();
            this.btnAtras = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnAdelante = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbTelefonos = new System.Windows.Forms.GroupBox();
            this.dgvTelefonos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chxHabilitado = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxHabilitado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvListado, 3);
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvListado.Location = new System.Drawing.Point(3, 32);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(660, 348);
            this.dgvListado.TabIndex = 2;
            this.dgvListado.TabStop = false;
            this.dgvListado.Click += new System.EventHandler(this.dgvListado_Click);
            this.dgvListado.DoubleClick += new System.EventHandler(this.dgvListado_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(74, 3);
            this.txtBuscar.MenuManager = this.barManager1;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Properties.Appearance.Options.UseFont = true;
            this.txtBuscar.Size = new System.Drawing.Size(322, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.ToolTip = "Escribe el nombre a buscar";
            this.txtBuscar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barraHerramientasFormulario,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAtras,
            this.btnAdelante,
            this.btnNuevo,
            this.btnEditar,
            this.barEditItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // barraHerramientasFormulario
            // 
            this.barraHerramientasFormulario.BarName = "Herramientas";
            this.barraHerramientasFormulario.DockCol = 0;
            this.barraHerramientasFormulario.DockRow = 0;
            this.barraHerramientasFormulario.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barraHerramientasFormulario.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAtras),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdelante),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditar)});
            this.barraHerramientasFormulario.Text = "Herramientas";
            // 
            // btnAtras
            // 
            this.btnAtras.Caption = "Atrás";
            this.btnAtras.Hint = "Navegar hacia atrás";
            this.btnAtras.Id = 0;
            this.btnAtras.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.btnAtras.LargeGlyph = global::AppSistemaContable.Properties.Resources.atras;
            this.btnAtras.Name = "btnAtras";
            // 
            // btnAdelante
            // 
            this.btnAdelante.Caption = "Adelante";
            this.btnAdelante.Hint = "Navegar hacia adelante";
            this.btnAdelante.Id = 1;
            this.btnAdelante.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
            this.btnAdelante.LargeGlyph = global::AppSistemaContable.Properties.Resources.adelante;
            this.btnAdelante.Name = "btnAdelante";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Hint = "Nuevo registro";
            this.btnNuevo.Id = 2;
            this.btnNuevo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnNuevo.LargeGlyph = global::AppSistemaContable.Properties.Resources.document_new;
            this.btnNuevo.Name = "btnNuevo";
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Hint = "Editar registro seleccionado";
            this.btnEditar.Id = 3;
            this.btnEditar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnEditar.LargeGlyph = global::AppSistemaContable.Properties.Resources.document_edit;
            this.btnEditar.Name = "btnEditar";
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            this.bar2.Visible = false;
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(830, 87);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 470);
            this.barDockControlBottom.Size = new System.Drawing.Size(830, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 87);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 383);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(830, 87);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 383);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Activo";
            this.barEditItem1.Edit = this.repositoryItemCheckEdit1;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbTelefonos, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvListado, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBuscar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chxHabilitado, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(830, 383);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // gbTelefonos
            // 
            this.gbTelefonos.Controls.Add(this.dgvTelefonos);
            this.gbTelefonos.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbTelefonos.Location = new System.Drawing.Point(669, 32);
            this.gbTelefonos.Name = "gbTelefonos";
            this.gbTelefonos.Size = new System.Drawing.Size(158, 348);
            this.gbTelefonos.TabIndex = 14;
            this.gbTelefonos.TabStop = false;
            this.gbTelefonos.Text = "Teléfonos";
            // 
            // dgvTelefonos
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvTelefonos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTelefonos.Location = new System.Drawing.Point(3, 17);
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefonos.Size = new System.Drawing.Size(152, 328);
            this.dgvTelefonos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nombre";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chxHabilitado
            // 
            this.chxHabilitado.Location = new System.Drawing.Point(402, 3);
            this.chxHabilitado.MenuManager = this.barManager1;
            this.chxHabilitado.Name = "chxHabilitado";
            this.chxHabilitado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxHabilitado.Properties.Appearance.Options.UseFont = true;
            this.chxHabilitado.Properties.Caption = "Habilitado";
            this.chxHabilitado.Size = new System.Drawing.Size(108, 23);
            this.chxHabilitado.TabIndex = 2;
            this.chxHabilitado.ToolTip = "Ver los registros habilitados/deshabilitados de  la lista";
            // 
            // frmPrincipalEmpresarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPrincipalEmpresarios";
            this.ShowIcon = false;
            this.Text = "Listado de empresarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbTelefonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxHabilitado.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraEditors.TextEdit txtBuscar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barraHerramientasFormulario;
        private DevExpress.XtraBars.BarLargeButtonItem btnAtras;
        private DevExpress.XtraBars.BarLargeButtonItem btnAdelante;
        private DevExpress.XtraBars.BarLargeButtonItem btnNuevo;
        private DevExpress.XtraBars.BarLargeButtonItem btnEditar;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.CheckEdit chxHabilitado;
        private System.Windows.Forms.GroupBox gbTelefonos;
        private System.Windows.Forms.DataGridView dgvTelefonos;
    }
}