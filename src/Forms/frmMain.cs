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
        private frmSuppliers SuppliersForm;
        private Comprobantes frmComprobantes;
        private frmCustomers CustomersForm;
        private frmProductList ProductListForm;
        private frmProductManagement ProductManagementForm;
        private frmUnitType UnitTypesForm;
        private frmSell SellForm;

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
        private void btnProveedores_Click(object sender, EventArgs e) { OpenForm(ref SuppliersForm, (s, ev) => CloseForm(ref SuppliersForm, s, ev)); }
        private void btnComprobantes_Click(object sender, EventArgs e) {  }
        private void btnClientes_Click(object sender, EventArgs e){ OpenForm(ref CustomersForm, (s, ev) => CloseForm(ref CustomersForm, s, ev));  }


        private void OpenForm<T>(ref T formInstance, FormClosedEventHandler formClosedHandler) where T : Form, new()
        {
            if (formInstance == null)
            {
                formInstance = new T
                {
                    MdiParent = this
                };
                formInstance.FormClosed += formClosedHandler;
                formInstance.Show();
            }
        }

        private void CloseForm<T>(ref T formInstance, object sender, FormClosedEventArgs eventArgs) where T : Form
        {
            formInstance = null;
        }

        private void lISTADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(ref ProductListForm, (s, ev) => CloseForm(ref ProductListForm, s, ev));
        }

        private void gESTIONARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(ref ProductManagementForm, (s, ev) => CloseForm(ref ProductManagementForm, s, ev));
        }

        private void btnUnitTypes_Click(object sender, EventArgs e)
        {
            OpenForm(ref UnitTypesForm, (s, ev) => CloseForm(ref UnitTypesForm, s, ev));
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            OpenForm(ref SellForm, (s, ev) => CloseForm(ref SellForm, s, ev));
        }
    }
}
