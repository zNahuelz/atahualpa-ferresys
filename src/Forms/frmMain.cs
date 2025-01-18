using atahualpa_ferresys.Forms.Product;
using atahualpa_ferresys.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atahualpa_ferresys.Forms
{
    public partial class frmMain : Form
    {
        private frmProducts frmProductos;
        private Proveedores frmProveedores;
        private Comprobantes frmComprobantes;
        private Clientes frmClientes;
        private frmProductList ProductListForm;
        private frmProductManagement ProductManagementForm;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            tReloj.Enabled = true;
            foreach (Control c in Controls)
            {
                MdiClient client = c as MdiClient;
                if (client != null) { client.BackColor = Color.Black; break; }
            }
        }

        private void tReloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "FECHA: " + DateTime.Now.ToShortDateString() + Environment.NewLine+"HORA: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult pg = MessageBox.Show("¿Esta seguro que desea salir del sistema?", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pg == DialogResult.Yes) { Application.Exit(); }
        }

        private void btnProductos_Click(object sender, EventArgs e){ //AbrirFormularios(0);
                                                                     }
        private void btnProveedores_Click(object sender, EventArgs e) { AbrirFormularios(1); }
        private void btnComprobantes_Click(object sender, EventArgs e) { AbrirFormularios(2); }
        private void btnClientes_Click(object sender, EventArgs e){ AbrirFormularios(3); }


        private void AbrirFormularios(int c)
        {
            switch (c)
            {
                case 0:
                    if(frmProductos == null)
                    {
                        frmProductos = new frmProducts();
                        frmProductos.MdiParent = this;
                        frmProductos.FormClosed += new FormClosedEventHandler(CerrarProductos);
                        frmProductos.Show();
                    }
                    break;
                case 1:
                    if(frmProveedores == null)
                    {
                        frmProveedores = new Proveedores();
                        frmProveedores.MdiParent = this;
                        frmProveedores.FormClosed += new FormClosedEventHandler(CerrarProveedores);
                        frmProveedores.Show();
                    }
                    break;
                case 2:
                    if(frmComprobantes == null)
                    {
                        frmComprobantes = new Comprobantes();
                        frmComprobantes.MdiParent = this;
                        frmComprobantes.FormClosed += new FormClosedEventHandler(CerrarComprobantes);
                        frmComprobantes.Show();
                    }
                    break;
                case 3:
                    if (frmClientes == null)
                    {
                        frmClientes = new Clientes();
                        frmClientes.MdiParent = this;
                        frmClientes.FormClosed += new FormClosedEventHandler(CerrarClientes);
                        frmClientes.Show();
                    }
                    break;
                default: break;
            }
        }

        private void OpenForm(int o)
        {
            switch (o)
            {
                case 0:
                    if(ProductListForm == null)
                    {
                        ProductListForm = new frmProductList();
                        ProductListForm.MdiParent = this;
                        ProductListForm.FormClosed += new FormClosedEventHandler(CloseProductListForm);
                        ProductListForm.Show();
                    }
                    break;
                case 1:
                    if (ProductManagementForm == null)
                    {
                        ProductManagementForm = new frmProductManagement();
                        ProductManagementForm.MdiParent = this;
                        ProductManagementForm.FormClosed += new FormClosedEventHandler(CloseProductManagementForm);
                        ProductManagementForm.Show();
                    }
                    break;
                default: break;
            }
        }

        private void CerrarProductos(object sender, FormClosedEventArgs e) { frmProductos = null; }
        private void CerrarProveedores(object sender, FormClosedEventArgs e) { frmProveedores = null; }
        private void CerrarComprobantes(object sender, FormClosedEventArgs e) { frmComprobantes = null; }
        private void CerrarClientes(object sender, FormClosedEventArgs e) { frmClientes = null; }

        private void CloseProductListForm(object sender, FormClosedEventArgs e) { ProductListForm = null; }
        private void CloseProductManagementForm(object sender, FormClosedEventArgs e) { ProductManagementForm = null; }

        private void lISTADOToolStripMenuItem_Click(object sender, EventArgs e){ OpenForm(0); }

        private void gESTIONARToolStripMenuItem_Click(object sender, EventArgs e){ OpenForm(1); }
    }
}
