using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atahualpa_ferresys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tReloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "FECHA: " + DateTime.Now.ToShortDateString() + " HORA: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tReloj.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
