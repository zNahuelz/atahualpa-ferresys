namespace atahualpa_ferresys.Forms
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.tcProductos = new System.Windows.Forms.TabControl();
            this.tpPrincipal = new System.Windows.Forms.TabPage();
            this.lblError = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tpNuevoProducto = new System.Windows.Forms.TabPage();
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbUnitType = new System.Windows.Forms.ComboBox();
            this.lblUnitT = new System.Windows.Forms.Label();
            this.lblSupp = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.cbVisible = new System.Windows.Forms.CheckBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblSP = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.lblBP = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.txtPDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.tpDetalle = new System.Windows.Forms.TabPage();
            this.tpEliminarProducto = new System.Windows.Forms.TabPage();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.dtpBusqueda = new System.Windows.Forms.DateTimePicker();
            this.cbBusquedaAux = new System.Windows.Forms.ComboBox();
            this.btnResetear = new System.Windows.Forms.Button();
            this.cbOpBuscar = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.tcProductos.SuspendLayout();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tpNuevoProducto.SuspendLayout();
            this.gbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcProductos
            // 
            this.tcProductos.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tcProductos.Controls.Add(this.tpPrincipal);
            this.tcProductos.Controls.Add(this.tpNuevoProducto);
            this.tcProductos.Controls.Add(this.tpDetalle);
            this.tcProductos.Controls.Add(this.tpEliminarProducto);
            this.tcProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcProductos.Location = new System.Drawing.Point(12, 139);
            this.tcProductos.Name = "tcProductos";
            this.tcProductos.SelectedIndex = 0;
            this.tcProductos.Size = new System.Drawing.Size(1105, 603);
            this.tcProductos.TabIndex = 0;
            this.tcProductos.SelectedIndexChanged += new System.EventHandler(this.tcProductos_SelectedIndexChanged);
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.lblError);
            this.tpPrincipal.Controls.Add(this.dgvProductos);
            this.tpPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPrincipal.Location = new System.Drawing.Point(4, 28);
            this.tpPrincipal.Name = "tpPrincipal";
            this.tpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrincipal.Size = new System.Drawing.Size(1097, 571);
            this.tpPrincipal.TabIndex = 0;
            this.tpPrincipal.Text = "PRODUCTOS";
            this.tpPrincipal.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(145, 203);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(807, 25);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "¡NO SE ENCONTRARON PRODUCTOS SEGÚN EL CRITERIO SELECCIONADO!";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.GridColor = System.Drawing.Color.HotPink;
            this.dgvProductos.Location = new System.Drawing.Point(6, 6);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(1085, 479);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // tpNuevoProducto
            // 
            this.tpNuevoProducto.Controls.Add(this.gbTest);
            this.tpNuevoProducto.Controls.Add(this.btnClear);
            this.tpNuevoProducto.Controls.Add(this.btnSave);
            this.tpNuevoProducto.Controls.Add(this.cbUnitType);
            this.tpNuevoProducto.Controls.Add(this.lblUnitT);
            this.tpNuevoProducto.Controls.Add(this.lblSupp);
            this.tpNuevoProducto.Controls.Add(this.cbSupplier);
            this.tpNuevoProducto.Controls.Add(this.cbVisible);
            this.tpNuevoProducto.Controls.Add(this.lblStock);
            this.tpNuevoProducto.Controls.Add(this.txtStock);
            this.tpNuevoProducto.Controls.Add(this.lblSP);
            this.tpNuevoProducto.Controls.Add(this.txtSellPrice);
            this.tpNuevoProducto.Controls.Add(this.lblBP);
            this.tpNuevoProducto.Controls.Add(this.txtBuyPrice);
            this.tpNuevoProducto.Controls.Add(this.txtPDesc);
            this.tpNuevoProducto.Controls.Add(this.lblDesc);
            this.tpNuevoProducto.Controls.Add(this.lblName);
            this.tpNuevoProducto.Controls.Add(this.txtPName);
            this.tpNuevoProducto.Location = new System.Drawing.Point(4, 28);
            this.tpNuevoProducto.Name = "tpNuevoProducto";
            this.tpNuevoProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tpNuevoProducto.Size = new System.Drawing.Size(1097, 571);
            this.tpNuevoProducto.TabIndex = 1;
            this.tpNuevoProducto.Text = "NUEVO PRODUCTO";
            this.tpNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // gbTest
            // 
            this.gbTest.Location = new System.Drawing.Point(551, 35);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(492, 514);
            this.gbTest.TabIndex = 18;
            this.gbTest.TabStop = false;
            this.gbTest.Text = "ÚLTIMO PRODUCTO GUARDADO";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(157, 515);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(314, 34);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "LIMPIAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(157, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(314, 34);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_ClickAsync);
            // 
            // cbUnitType
            // 
            this.cbUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnitType.FormattingEnabled = true;
            this.cbUnitType.Location = new System.Drawing.Point(157, 414);
            this.cbUnitType.Name = "cbUnitType";
            this.cbUnitType.Size = new System.Drawing.Size(314, 24);
            this.cbUnitType.TabIndex = 15;
            this.cbUnitType.SelectedIndexChanged += new System.EventHandler(this.cbUnitType_SelectedIndexChanged);
            // 
            // lblUnitT
            // 
            this.lblUnitT.AutoSize = true;
            this.lblUnitT.Location = new System.Drawing.Point(54, 410);
            this.lblUnitT.Name = "lblUnitT";
            this.lblUnitT.Size = new System.Drawing.Size(67, 32);
            this.lblUnitT.TabIndex = 14;
            this.lblUnitT.Text = "TIPO DE\r\nUNIDAD";
            // 
            // lblSupp
            // 
            this.lblSupp.AutoSize = true;
            this.lblSupp.Location = new System.Drawing.Point(19, 367);
            this.lblSupp.Name = "lblSupp";
            this.lblSupp.Size = new System.Drawing.Size(102, 16);
            this.lblSupp.TabIndex = 13;
            this.lblSupp.Text = "PROVEEDOR";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(157, 363);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(314, 24);
            this.cbSupplier.TabIndex = 12;
            // 
            // cbVisible
            // 
            this.cbVisible.AutoSize = true;
            this.cbVisible.Checked = true;
            this.cbVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVisible.Location = new System.Drawing.Point(293, 306);
            this.cbVisible.Name = "cbVisible";
            this.cbVisible.Size = new System.Drawing.Size(82, 20);
            this.cbVisible.TabIndex = 11;
            this.cbVisible.Text = "VISIBLE";
            this.cbVisible.UseVisualStyleBackColor = true;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(64, 308);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(57, 16);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "STOCK";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(157, 305);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(93, 22);
            this.txtStock.TabIndex = 8;
            this.txtStock.Text = "0";
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(293, 245);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(63, 32);
            this.lblSP.TabIndex = 7;
            this.lblSP.Text = "PRECIO\r\nVENTA";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(378, 250);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(93, 22);
            this.txtSellPrice.TabIndex = 6;
            this.txtSellPrice.Text = "0.00";
            this.txtSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellPrice_KeyPress);
            // 
            // lblBP
            // 
            this.lblBP.AutoSize = true;
            this.lblBP.Location = new System.Drawing.Point(64, 245);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(71, 32);
            this.lblBP.TabIndex = 5;
            this.lblBP.Text = "PRECIO\r\nCOMPRA";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(157, 250);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(93, 22);
            this.txtBuyPrice.TabIndex = 4;
            this.txtBuyPrice.Text = "0.00";
            this.txtBuyPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyPrice_KeyPress);
            // 
            // txtPDesc
            // 
            this.txtPDesc.Location = new System.Drawing.Point(157, 83);
            this.txtPDesc.Multiline = true;
            this.txtPDesc.Name = "txtPDesc";
            this.txtPDesc.Size = new System.Drawing.Size(314, 121);
            this.txtPDesc.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(27, 89);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(109, 16);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "DESCRIPCIÓN";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NOMBRE";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(157, 35);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(314, 22);
            this.txtPName.TabIndex = 0;
            // 
            // tpDetalle
            // 
            this.tpDetalle.Location = new System.Drawing.Point(4, 28);
            this.tpDetalle.Name = "tpDetalle";
            this.tpDetalle.Size = new System.Drawing.Size(1097, 571);
            this.tpDetalle.TabIndex = 2;
            this.tpDetalle.Text = "DETALLE";
            this.tpDetalle.UseVisualStyleBackColor = true;
            // 
            // tpEliminarProducto
            // 
            this.tpEliminarProducto.Location = new System.Drawing.Point(4, 28);
            this.tpEliminarProducto.Name = "tpEliminarProducto";
            this.tpEliminarProducto.Size = new System.Drawing.Size(1097, 571);
            this.tpEliminarProducto.TabIndex = 3;
            this.tpEliminarProducto.Text = "ELIMINAR PRODUCTOS";
            this.tpEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.dtpBusqueda);
            this.gbPrincipal.Controls.Add(this.cbBusquedaAux);
            this.gbPrincipal.Controls.Add(this.btnResetear);
            this.gbPrincipal.Controls.Add(this.cbOpBuscar);
            this.gbPrincipal.Controls.Add(this.txtBusqueda);
            this.gbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrincipal.Location = new System.Drawing.Point(12, 13);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(1101, 120);
            this.gbPrincipal.TabIndex = 1;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "HERRAMIENTAS";
            // 
            // dtpBusqueda
            // 
            this.dtpBusqueda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBusqueda.Location = new System.Drawing.Point(289, 62);
            this.dtpBusqueda.Name = "dtpBusqueda";
            this.dtpBusqueda.Size = new System.Drawing.Size(261, 22);
            this.dtpBusqueda.TabIndex = 4;
            this.dtpBusqueda.ValueChanged += new System.EventHandler(this.dtpBusqueda_ValueChanged);
            // 
            // cbBusquedaAux
            // 
            this.cbBusquedaAux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusquedaAux.FormattingEnabled = true;
            this.cbBusquedaAux.Location = new System.Drawing.Point(289, 21);
            this.cbBusquedaAux.Name = "cbBusquedaAux";
            this.cbBusquedaAux.Size = new System.Drawing.Size(261, 24);
            this.cbBusquedaAux.TabIndex = 3;
            this.cbBusquedaAux.SelectedIndexChanged += new System.EventHandler(this.cbBusquedaAux_SelectedIndexChanged);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(10, 90);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(261, 23);
            this.btnResetear.TabIndex = 2;
            this.btnResetear.Text = "RESET";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // cbOpBuscar
            // 
            this.cbOpBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpBuscar.FormattingEnabled = true;
            this.cbOpBuscar.Location = new System.Drawing.Point(10, 21);
            this.cbOpBuscar.Name = "cbOpBuscar";
            this.cbOpBuscar.Size = new System.Drawing.Size(261, 24);
            this.cbOpBuscar.TabIndex = 1;
            this.cbOpBuscar.SelectedIndexChanged += new System.EventHandler(this.cbOpBuscar_SelectedIndexChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Location = new System.Drawing.Point(10, 62);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(261, 22);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1129, 754);
            this.Controls.Add(this.gbPrincipal);
            this.Controls.Add(this.tcProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar - Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.tcProductos.ResumeLayout(false);
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tpNuevoProducto.ResumeLayout(false);
            this.tpNuevoProducto.PerformLayout();
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcProductos;
        private System.Windows.Forms.TabPage tpPrincipal;
        private System.Windows.Forms.TabPage tpNuevoProducto;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.TabPage tpDetalle;
        private System.Windows.Forms.TabPage tpEliminarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.ComboBox cbOpBuscar;
        private System.Windows.Forms.ComboBox cbBusquedaAux;
        private System.Windows.Forms.DateTimePicker dtpBusqueda;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtPDesc;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.CheckBox cbVisible;
        private System.Windows.Forms.Label lblSupp;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.ComboBox cbUnitType;
        private System.Windows.Forms.Label lblUnitT;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbTest;
    }
}