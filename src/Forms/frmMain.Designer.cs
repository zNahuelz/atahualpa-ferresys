namespace atahualpa_ferresys.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnNuevaVenta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProductos = new System.Windows.Forms.ToolStripDropDownButton();
            this.lISTADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProveedores = new System.Windows.Forms.ToolStripButton();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.btnComprobantes = new System.Windows.Forms.ToolStripButton();
            this.btnTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnUnitTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblHora = new System.Windows.Forms.ToolStripLabel();
            this.btnUsuario = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMiPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tReloj = new System.Windows.Forms.Timer(this.components);
            this.tsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tsPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevaVenta,
            this.toolStripSeparator1,
            this.btnProductos,
            this.btnProveedores,
            this.btnClientes,
            this.btnComprobantes,
            this.btnTools,
            this.toolStripSeparator2,
            this.lblHora,
            this.btnUsuario});
            this.tsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsPrincipal.Size = new System.Drawing.Size(190, 771);
            this.tsPrincipal.TabIndex = 1;
            this.tsPrincipal.Text = "toolStrip1";
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaVenta.Image")));
            this.btnNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevaVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(187, 68);
            this.btnNuevaVenta.Text = "NUEVA VENTA";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // btnProductos
            // 
            this.btnProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTADOToolStripMenuItem,
            this.gESTIONARToolStripMenuItem});
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(187, 68);
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // lISTADOToolStripMenuItem
            // 
            this.lISTADOToolStripMenuItem.Name = "lISTADOToolStripMenuItem";
            this.lISTADOToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.lISTADOToolStripMenuItem.Text = "LISTADO";
            this.lISTADOToolStripMenuItem.Click += new System.EventHandler(this.lISTADOToolStripMenuItem_Click);
            // 
            // gESTIONARToolStripMenuItem
            // 
            this.gESTIONARToolStripMenuItem.Name = "gESTIONARToolStripMenuItem";
            this.gESTIONARToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.gESTIONARToolStripMenuItem.Text = "GESTIONAR";
            this.gESTIONARToolStripMenuItem.Click += new System.EventHandler(this.gESTIONARToolStripMenuItem_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProveedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(187, 68);
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(187, 68);
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnComprobantes
            // 
            this.btnComprobantes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobantes.Image = ((System.Drawing.Image)(resources.GetObject("btnComprobantes.Image")));
            this.btnComprobantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprobantes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnComprobantes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComprobantes.Name = "btnComprobantes";
            this.btnComprobantes.Size = new System.Drawing.Size(187, 68);
            this.btnComprobantes.Text = "COMPROBANTES";
            this.btnComprobantes.Click += new System.EventHandler(this.btnComprobantes_Click);
            // 
            // btnTools
            // 
            this.btnTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUnitTypes});
            this.btnTools.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTools.Image = ((System.Drawing.Image)(resources.GetObject("btnTools.Image")));
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(187, 68);
            this.btnTools.Text = "VARIOS";
            // 
            // btnUnitTypes
            // 
            this.btnUnitTypes.Name = "btnUnitTypes";
            this.btnUnitTypes.Size = new System.Drawing.Size(184, 22);
            this.btnUnitTypes.Text = "PRESENTACIONES";
            this.btnUnitTypes.Click += new System.EventHandler(this.btnUnitTypes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // lblHora
            // 
            this.lblHora.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(187, 21);
            this.lblHora.Text = "<------------>";
            // 
            // btnUsuario
            // 
            this.btnUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMiPerfil,
            this.btnCerrarSesion,
            this.btnSalir});
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(187, 68);
            this.btnUsuario.Text = "USUARIO";
            // 
            // btnMiPerfil
            // 
            this.btnMiPerfil.Name = "btnMiPerfil";
            this.btnMiPerfil.Size = new System.Drawing.Size(193, 24);
            this.btnMiPerfil.Text = "CONFIGURACIÓN";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(193, 24);
            this.btnCerrarSesion.Text = "CERRAR SESIÓN";
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(193, 24);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tReloj
            // 
            this.tReloj.Tick += new System.EventHandler(this.tReloj_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::atahualpa_ferresys.Properties.Resources.logo_transparent1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1122, 771);
            this.ControlBox = false;
            this.Controls.Add(this.tsPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FERRETERIA ATAHUALPA - ADMINISTRACIÓN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripButton btnProveedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnNuevaVenta;
        private System.Windows.Forms.ToolStripButton btnComprobantes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblHora;
        private System.Windows.Forms.Timer tReloj;
        private System.Windows.Forms.ToolStripDropDownButton btnUsuario;
        private System.Windows.Forms.ToolStripMenuItem btnMiPerfil;
        private System.Windows.Forms.ToolStripMenuItem btnCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripDropDownButton btnProductos;
        private System.Windows.Forms.ToolStripMenuItem lISTADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONARToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnTools;
        private System.Windows.Forms.ToolStripMenuItem btnUnitTypes;
    }
}