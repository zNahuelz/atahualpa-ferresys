using atahualpa_ferresys.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atahualpa_ferresys.Forms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            tReloj.Enabled = true;
            foreach (Control c in this.Controls)
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
    }
}
