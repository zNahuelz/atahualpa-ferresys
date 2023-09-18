﻿namespace atahualpa_ferresys.Forms
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.tcProductos = new System.Windows.Forms.TabControl();
            this.tpPrincipal = new System.Windows.Forms.TabPage();
            this.lblError = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tpNuevoProducto = new System.Windows.Forms.TabPage();
            this.tpDetalle = new System.Windows.Forms.TabPage();
            this.tpEliminarProducto = new System.Windows.Forms.TabPage();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbOpBuscar = new System.Windows.Forms.ComboBox();
            this.btnResetear = new System.Windows.Forms.Button();
            this.cbBusquedaAux = new System.Windows.Forms.ComboBox();
            this.dtpBusqueda = new System.Windows.Forms.DateTimePicker();
            this.tcProductos.SuspendLayout();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
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
            this.tpNuevoProducto.Location = new System.Drawing.Point(4, 28);
            this.tpNuevoProducto.Name = "tpNuevoProducto";
            this.tpNuevoProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tpNuevoProducto.Size = new System.Drawing.Size(1097, 571);
            this.tpNuevoProducto.TabIndex = 1;
            this.tpNuevoProducto.Text = "NUEVO PRODUCTO";
            this.tpNuevoProducto.UseVisualStyleBackColor = true;
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
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Location = new System.Drawing.Point(10, 62);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(261, 22);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
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
            // cbBusquedaAux
            // 
            this.cbBusquedaAux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusquedaAux.FormattingEnabled = true;
            this.cbBusquedaAux.Location = new System.Drawing.Point(289, 21);
            this.cbBusquedaAux.Name = "cbBusquedaAux";
            this.cbBusquedaAux.Size = new System.Drawing.Size(261, 24);
            this.cbBusquedaAux.TabIndex = 3;
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
            // Productos
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
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar - Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.tcProductos.ResumeLayout(false);
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
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
    }
}